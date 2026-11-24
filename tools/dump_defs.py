#!/usr/bin/env python3
"""
从游戏原始 Addressables bundle 导出数值定义表。

需要：UnityPy（pip install unitypy），以及本地安装的《PvZ Replanted》PC 版。
用法：
  python dump_defs.py --game "D:/Games/PVZ Replanted" --out ../data

默认输出 plants.json / zombies.json / levels.json（仓库 data/ 目录里的就是这么生成的）。
"""
import argparse
import json
import os
import sys

try:
    import UnityPy
except ImportError:
    print("需要 UnityPy：pip install unitypy", file=sys.stderr)
    sys.exit(1)


def dump_bundle(aa_dir, prefix, outname, out_dir):
    files = [x for x in os.listdir(aa_dir) if x.startswith(prefix)]
    rows = []
    for fn in files:
        env = UnityPy.load(os.path.join(aa_dir, fn))
        for obj in env.objects:
            if obj.type.name != "MonoBehaviour":
                continue
            try:
                rows.append(obj.read_typetree())
            except Exception:
                continue
    with open(os.path.join(out_dir, outname), "w", encoding="utf-8") as f:
        json.dump(rows, f, ensure_ascii=False, indent=1)
    print(prefix, "->", outname, len(rows), "entries")


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--game", required=True, help="游戏安装目录（含 Replanted_Data）")
    ap.add_argument("--out", default="../data")
    args = ap.parse_args()
    aa = os.path.join(args.game, "Replanted_Data", "StreamingAssets", "aa", "StandaloneWindows64")
    if not os.path.isdir(aa):
        print("找不到 Addressables 目录:", aa, file=sys.stderr)
        return 1
    os.makedirs(args.out, exist_ok=True)
    dump_bundle(aa, "defaultlocalgroup_assets_plantdefinitiondata", "plants.json", args.out)
    dump_bundle(aa, "defaultlocalgroup_assets_zombiedefinitiondata", "zombies.json", args.out)
    dump_bundle(aa, "defaultlocalgroup_assets_leveldata", "levels.json", args.out)
    return 0


if __name__ == "__main__":
    sys.exit(main())
