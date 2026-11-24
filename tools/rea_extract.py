#!/usr/bin/env python3
"""
REA 方法提取器：从 Cpp2IL 的 ISIL dump 里按「类 + 方法名」提取反汇编，
方便逐个方法还原成 C#。

用法：
  python rea_extract.py <类名> <方法名关键字> [--isil 目录]
例：
  python rea_extract.py Plant IsFlying
  python rea_extract.py Board AddPlant

--isil 默认指向本仓库的 archives/isil_dump.zip 解压后的 IsilDump 目录。
也可以直接用 --isil 指向你自己的 Cpp2IL 输出目录。
"""
import argparse
import os
import re
import sys

# 仓库内相对路径：archives/isil.zip 解压后得到各程序集目录
_HERE = os.path.dirname(os.path.abspath(__file__))
_REPO = os.path.dirname(_HERE)
DEFAULT_ISIL = os.path.join(_REPO, "archives", "isil", "Assembly-CSharp")


def find_file(root, cls):
    for dirpath, _, files in os.walk(root):
        for f in files:
            if f == cls + ".txt":
                return os.path.join(dirpath, f)
    return None


def split_methods(text):
    """返回 [(method_header, body_lines)]"""
    lines = text.splitlines()
    starts = [(i, l) for i, l in enumerate(lines) if l.startswith("Method: ")]
    out = []
    for idx, (i, header) in enumerate(starts):
        end = starts[idx + 1][0] if idx + 1 < len(starts) else len(lines)
        out.append((header[len("Method: "):], lines[i + 1:end]))
    return out


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("cls")
    ap.add_argument("method")
    ap.add_argument("--isil", default=DEFAULT_ISIL)
    args = ap.parse_args()

    path = find_file(args.isil, args.cls)
    if not path:
        print("找不到类文件:", args.cls, "（在", args.isil, "下）", file=sys.stderr)
        print("提示：先解压 archives/isil_dump.zip，或用 --isil 指向 Cpp2IL 的 IsilDump 目录", file=sys.stderr)
        return 1

    with open(path, encoding="utf-8", errors="replace") as f:
        methods = split_methods(f.read())

    hits = [(h, b) for h, b in methods if args.method.lower() in h.lower()]
    if not hits:
        print("没有匹配的方法。该类的全部方法：")
        for h, _ in methods:
            print("  ", h)
        return 1

    for header, body in hits:
        print("=" * 70)
        print("Method:", header)
        print("-" * 70)
        print("\n".join(body).rstrip())
        print()
    return 0


if __name__ == "__main__":
    sys.exit(main())
