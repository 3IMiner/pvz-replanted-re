# PvZ Replanted — 逆向工程资料库

> 对 PC 版《Plants vs. Zombies: Replanted》（Unity 6000.0.52f1 / IL2CPP / x86-64）的逆向工程产物整理。
> 包含：类型结构、字段偏移、枚举、数值定义、逐方法反汇编、以及按原版机器码还原的 C# 源码。

---

## ⚠️ 这个仓库里没有什么

- **没有游戏本体**：不含任何 exe / dll / 资源 bundle / APK。要复现请自备正版游戏。
- **没有可直接运行的游戏**：`reconstructed/` 里的 C# 是「行为等价还原」，依赖游戏自身的类型（Plant/Board/…），不是独立工程，也不能直接编译成 exe。
- **不是官方源码**：所有符号、偏移、汇编来自逆向；方法体是按机器码逐条还原的，结构可能与 EA 原工程不同。

---

## 仓库内容

```
pvz-replanted-re/
├── README.md                  本文件
├── LICENSE                    仅涵盖本仓库的原创整理内容
├── docs/                      分析报告（7 篇）
│   ├── 01-RE报告.md               类型/数值/资源逆向总览
│   ├── 02-RE源码说明.md           DiffableCs 结构源码说明
│   ├── 03-REA还原示例.md          3 个方法从汇编到 C# 的完整闭环
│   ├── 04-最终技术结论.md         为什么「100%原版+安卓原生+无模拟器」不存在
│   ├── 05-PC到Android全流程.md    全量还原的规模实测与阶段计划
│   ├── 06-改版指南-MelonLoader.md MelonLoader 修改器（Harmony 补丁）
│   └── 07-安卓化指南.md           Winlator / 原生构建各路线
├── data/                      从 bundle 导出的数值表（JSON）
│   ├── plants.json                80 个植物定义
│   ├── zombies.json               37 个僵尸定义
│   └── levels.json                151 个关卡定义（含 50 关冒险）
├── reference/                 速查资料
│   ├── ENUMS.md                   全部枚举（SeedType/PlantState/ZombieType/…）
│   ├── FIELDS.md                  Plant/Zombie/Board 字段偏移表
│   ├── PROGRESS.md                还原进度追踪
│   ├── class_stats.json           826 类 / 8543 方法体积统计
│   └── samples/                   6 个关键类的结构源码样例
├── reconstructed/             REA 还原的 C# 源码
│   └── Plant/                     Plant 类
│       ├── PlantRea.cs            UpdateShooter / UpdateProductionPlant
│       ├── PlantRea_simple.cs     14 个简单方法
│       ├── _index.md              112 个方法清单（按体积排序）
│       └── 0001_*.md … 0112_*.md  逐方法「汇编 + C# 骨架」工作区
├── tools/                     可复现的工具脚本
│   ├── dump_defs.py               从 bundle 导出数值表
│   ├── rea_extract.py             按「类+方法」抽反汇编
│   └── rea_workbench.py           生成逐方法还原工作区
└── archives/                  大体积 dump（zip，均 < 100 MB）
    ├── source_diffablecs.zip      12578 个结构源码 .cs（7.6 MB）
    ├── isil.zip                   14554 个逐方法反汇编（64.9 MB）
    ├── il2.zip                    Cpp2IL 第二阶段 IL（7.1 MB）
    ├── il.zip                     原始 IL dump（3.4 MB）
    └── art.zip                    导出的原版草坪贴图（9.2 MB）
```

---

## 快速开始

### 1. 看某个方法的反汇编

```bash
# 先解压反汇编档案（归档根目录即各程序集目录）
unzip archives/isil.zip -d archives/isil/

# 提取 Plant.IsFlying 的汇编 + ISIL
python tools/rea_extract.py Plant IsFlying
```

输出：

```
Method: System.Boolean IsFlying(Reloaded.Gameplay.SeedType theSeedtype)
Disassembly:
	cmp ecx,23h
	sete al
	ret
ISIL:
	001 Compare rcx, 35
	002 NotImplemented "sete al"
	003 Return rax
```

### 2. 生成还原工作区

```bash
python tools/rea_workbench.py Board          # Board 类 317 个方法
python tools/rea_workbench.py --list        # 全部 826 类按体积排序
```

### 3. 重新导出数值表

```bash
pip install unitypy
python tools/dump_defs.py --game "D:/Games/PVZ Replanted" --out data
```

---

## 还原方法论

每个方法按同一流程处理：

1. `tools/rea_extract.py <类> <方法>` 提取 `Disassembly`（x64 汇编）+ `ISIL`（伪指令，更易读）
2. 查 `reference/FIELDS.md`，把 `[rbx+0x70]` 映射成 `mSeedType`
3. 查 `reference/ENUMS.md`，把 `0x23` 映射成 `SeedType.InstantCoffee`
4. 控制流（cmp/je/jne/switch 跳转表）转成 if/switch
5. 写入 `reconstructed/<类>/`，未还原的依赖用 `throw new NotImplementedException("批次N")` 占位并注释不确定点
6. 语义交叉验证（例：`MakesSun()` 必须恰好覆盖三种产阳光植物）

### 已验证的还原样例

| 方法 | 汇编关键点 | 还原结果 |
|---|---|---|
| `Plant.IsFlying` | `cmp ecx,23h; sete al` | `return seedtype == InstantCoffee(35)` |
| `Plant.MakesSun` | `cmp [rcx+70h],1/29h/9` | `mSeedType ∈ {Sunflower, Twinsunflower, Sunshroom}` |
| `Plant.IsNocturnal` | `mov eax,8100F700h; bt eax,ecx` | 位掩码解出 10 种夜间植物 |
| `Plant.UpdateShooter` | 倒计时 + 多分支跳转 | 射击循环、连发定时、Threepeater/Starfruit/Splitpea/Cactus 分支 |
| `Plant.UpdateProductionPlant` | RandRangeInt + AddCoin | 产阳光间隔、雨天、Marigold 金币、Sunshroom 大小菇 |

---

## 规模实测（决定工作量）

| 指标 | 数值 |
|---|---|
| 游戏逻辑类（Assembly-CSharp） | **826** |
| 方法 | **8,543** |
| 反汇编总行数 | **1,025,824** |
| 已还原方法 | 21（Plant 类） |

方法体积分布：

| 汇编行数 | 方法数 | 占比 |
|---|---|---|
| < 10 | 910 | 10.7% |
| 10–30 | 2650 | 31.0% |
| 30–100 | 2276 | 26.6% |
| 100–300 | 1939 | 22.7% |
| > 300 | 768 | 9.0% |

全量还原估算约 **13 人年**（见 `docs/05-PC到Android全流程.md`）。

---

## 生成这些 dump 的工具链

| 工具 | 用途 |
|---|---|
| UnityPy 1.25.4 | 读 Addressables bundle，导出数值/美术 |
| Cpp2IL 2022.1.0-pre.21 | `--output-as diffable-cs` / `isil` 生成结构与反汇编 |
| AssetRipper 2.0 | Unity 工程骨架（本仓库未收录，17 GB 且含 >100 MB 单文件） |
| MelonLoader 0.7.3 | IL2CPP interop 程序集，用于解析枚举与字段偏移 |
| Mono.Cecil | 从 interop DLL 读枚举值 |

---

## 免责与说明

- 本仓库只含**逆向分析产生的文本数据与人工还原代码**，不含游戏可执行文件、资源文件或任何受版权保护的游戏内容（`art.zip` 仅含两张从公开运行画面导出的草坪贴图，供还原对照用）。
- 使用本仓库资料需要你自行拥有合法的游戏副本。
- 项目与 PopCap / EA 无关联；「Plants vs. Zombies」为其商标。

---

## 许可见 LICENSE

本仓库的整理、文档、还原代码按 MIT 许可；原始游戏的知识产权归其权利人所有，不受本许可覆盖。
