#!/usr/bin/env python3
"""
REA 还原工作台：
把 Cpp2IL 的 ISIL dump 拆成「一方法一文件」的还原任务，并生成 C# 骨架。

用法：
  python rea_workbench.py <类名>            # 生成该类的还原工作区
  python rea_workbench.py --list            # 列出所有类及方法数/体积
  python rea_workbench.py Board --min 200   # 只看大方法

输出：
  reconstructed/<类名>/
      _index.md                 方法清单（按体积排序，便于先易后难）
      0001_<方法名>.md          单个方法的汇编 + C# 骨架
"""
import argparse
import os
import re
import sys

_HERE = os.path.dirname(os.path.abspath(__file__))
_REPO = os.path.dirname(_HERE)
ISIL_ROOT = os.path.join(_REPO, "archives", "isil", "Assembly-CSharp")
OUT_ROOT = os.path.join(_REPO, "reconstructed")


def find_class_file(cls):
    for dp, _, fs in os.walk(ISIL_ROOT):
        for f in fs:
            if f == cls + ".txt":
                return os.path.join(dp, f)
    return None


def parse_methods(path):
    lines = open(path, encoding="utf-8", errors="replace").read().splitlines()
    starts = [(i, l) for i, l in enumerate(lines) if l.startswith("Method: ")]
    out = []
    for idx, (i, header) in enumerate(starts):
        end = starts[idx + 1][0] if idx + 1 < len(starts) else len(lines)
        out.append((header[len("Method: "):], lines[i + 1:end]))
    return out


def sanitize(name):
    return re.sub(r"[^\w\.]+", "_", name)[:90]


def cs_name(sig):
    m = re.search(r"([\w<>`]+)\(([^)]*)\)", sig)
    return m.group(1) if m else sanitize(sig)


def emit(cls, outdir, only_big=None):
    src = find_class_file(cls)
    if not src:
        print("找不到类:", cls, file=sys.stderr)
        return 1
    methods = parse_methods(src)
    methods.sort(key=lambda m: len(m[1]))
    os.makedirs(outdir, exist_ok=True)

    index = ["# " + cls + " 还原清单", "",
             "| # | 方法 | 汇编行数 | 文件 |", "|---|---|---|---|"]
    n = 0
    for i, (sig, body) in enumerate(methods, 1):
        if only_big and len(body) < only_big:
            continue
        n += 1
        fname = f"{i:04d}_{sanitize(cs_name(sig))}.md"
        index.append(f"| {i} | `{sig}` | {len(body)} | [{fname}]({fname}) |")
        with open(os.path.join(outdir, fname), "w", encoding="utf-8") as f:
            f.write(f"# {sig}\n\n- 类：`{cls}`\n- 汇编行数：{len(body)}\n\n")
            f.write("## 反汇编\n\n```asm\n")
            f.write("\n".join(body).rstrip())
            f.write("\n```\n\n## C# 还原\n\n```csharp\n")
            f.write("// TODO: 按上面汇编还原\npublic static ??? Method()\n{\n    throw new NotImplementedException();\n}\n")
            f.write("```\n")
    with open(os.path.join(outdir, "_index.md"), "w", encoding="utf-8") as f:
        f.write("\n".join(index) + "\n")
    print(f"{cls}: {n} 个方法 -> {outdir}")
    return 0


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("cls", nargs="?")
    ap.add_argument("--min", type=int, default=0)
    ap.add_argument("--list", action="store_true")
    args = ap.parse_args()

    if args.list or not args.cls:
        rows = []
        for dp, _, fs in os.walk(ISIL_ROOT):
            for f in fs:
                if not f.endswith(".txt"):
                    continue
                t = open(os.path.join(dp, f), encoding="utf-8", errors="replace").read()
                m = len(re.findall(r"(?m)^Method: ", t))
                rows.append((t.count("\n"), m, f[:-4]))
        rows.sort(reverse=True)
        print(f"{'lines':>8} {'methods':>8}  class")
        for l, m, n in rows[:40]:
            print(f"{l:>8} {m:>8}  {n}")
        print("... total classes:", len(rows), "methods:", sum(r[1] for r in rows))
        return 0
    return emit(args.cls, os.path.join(OUT_ROOT, args.cls), args.min or None)


if __name__ == "__main__":
    sys.exit(main())
