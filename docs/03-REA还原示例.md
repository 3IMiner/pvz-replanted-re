# REA 还原实测：从汇编到 C#

> 目标：验证"用逆向分析（REA）还原原版逻辑"这条路的可行性和成本
> 工具：`re\rea_extract.py`（按类名+方法名提取 ISIL 反汇编）
> 数据源：Cpp2IL 输出 `re\isil\IsilDump\`（14,554 个文件 / 371.8 MB 逐方法汇编）

---

## 结论先说

**REA 可行，而且还原精度很高。** 我拿 3 个方法做了完整闭环：汇编 → C# → 用游戏数据验证语义正确。

**但全量还原 145,833 个方法不现实。** 文末有成本估算。

---

## 1. 工具

```powershell
# 列出一个类的所有方法
python re\rea_extract.py Plant Animate

# 提取单个方法的汇编
python re\rea_extract.py Plant MakesSun
python re\rea_extract.py Board AddPlant
```

---

## 2. 三个方法的完整还原

### 2.1 `Plant.IsFlying(SeedType)` — 3 条指令

汇编：

```asm
cmp ecx,23h      ; ecx = theSeedtype；0x23 = 35
sete al          ; al = (theSeedtype == 35)
ret
```

还原：

```csharp
public static bool IsFlying(SeedType theSeedtype)
{
    return theSeedtype == SeedType.InstantCoffee;   // 35
}
```

> 有意思的是：语义上"飞行"却只匹配 `InstantCoffee`（速溶咖啡豆）。机器码就是这样——REA 会暴露反直觉的真实逻辑，这正是它的价值。

### 2.2 `Plant.MakesSun()` — 5 条指令

汇编：

```asm
cmp dword ptr [rcx+70h],1     ; mSeedType == 1
je  L_true
cmp dword ptr [rcx+70h],29h   ; mSeedType == 41
je  L_true
cmp dword ptr [rcx+70h],9     ; mSeedType == 9
sete al
ret
L_true: mov al,1; ret
```

还原：

```csharp
public bool MakesSun()
{
    // [rcx+0x70] 是 mSeedType 字段偏移
    return mSeedType == SeedType.Sunflower        // 1
        || mSeedType == SeedType.Twinsunflower    // 41
        || mSeedType == SeedType.Sunshroom;       // 9
}
```

**验证**：`SeedType` 枚举里 1=Sunflower、9=Sunshroom、41=Twinsunflower——正好是全部产阳光植物。✅

### 2.3 `Plant.IsNocturnal(SeedType)` — 位掩码写法

汇编：

```asm
cmp ecx,1Fh              ; if (seedtype > 31) goto L2
ja  L2
mov eax,8100F700h        ; 位掩码
bt  eax,ecx              ; 测试第 seedtype 位
jae L2                   ; 位为 0 → 不是夜间植物
mov al,1
ret
L2: cmp ecx,2Ah          ; 42 = Gloomshroom
    sete al
    ret
```

还原：

```csharp
public static bool IsNocturnal(SeedType theSeedtype)
{
    if ((uint)theSeedtype <= 31)
    {
        // 0x8100F700 的置位：8,9,10,12,13,14,15,24,31
        return ((0x8100F700u >> (int)theSeedtype) & 1u) != 0;
    }
    return theSeedtype == SeedType.Gloomshroom;   // 42
}
```

**位掩码解码**（`0x8100F700`）：

| 位 | SeedType | 植物 |
|---|---|---|
| 8 | Puffshroom | 小喷菇 |
| 9 | Sunshroom | 阳光菇 |
| 10 | Fumeshroom | 大喷菇 |
| 12 | Hypnoshroom | 魅惑菇 |
| 13 | Scaredyshroom | 胆小菇 |
| 14 | Iceshroom | 寒冰菇 |
| 15 | Doomshroom | 毁灭菇 |
| 24 | Seashroom | 海蘑菇 |
| 31 | Magnetshroom | 磁力菇 |
| 42 | Gloomshroom | 忧郁菇 |

**验证**：正好是 PvZ 全部夜间植物（只能在夜晚关卡种植）。✅

---

## 3. 还原质量评估

| 方法 | 汇编行数 | 还原耗时 | 结果 |
|---|---|---|---|
| IsFlying | 3 | 1 分钟 | 精确 |
| MakesSun | 9 | 2 分钟 | 精确 |
| IsNocturnal（含位掩码） | 10 | 5 分钟 | 精确 |
| Plant.Animate | **673** | 数小时～数天 | 可能，但极慢 |

简单方法（<20 条指令）几乎可以逐条直译，准确率接近 100%。
复杂方法（数百条指令、多态调用、异常处理、浮点常量池）需要逐段还原控制流和调用目标，难度指数上升。

---

## 4. 成本估算（关键）

| 指标 | 数值 |
|---|---|
| 总方法数 | **145,833** |
| 总汇编体积 | 371.8 MB |
| `Plant` 一个类 | 112 个方法 |
| `Board` 一个类 | 615 个方法 |
| 平均方法体积 | ≈ 2.5 KB 汇编（约 60–80 条指令） |
| 熟练 RE 工程师日产量 | 20–40 个中等方法 / 天 |
| 全量还原耗时 | **约 10–20 人年** |

而且这只是"逻辑代码"，还没有算：

- 重建 Unity 工程（场景、prefab、脚本绑定、Addressables 配置）
- Shader 从 D3D11 转 GLES/Vulkan
- Spine 动画状态机的接线
- Android 平台适配（触控、输入、存档路径）

**所以：REA 是"能还原"的路，但不是"能做完"的路。** 对于一个 14.5 万方法的商业游戏，这属于一个团队数年的工程。

---

## 5. 实务上 REA 的正确用法

1. **定位关键逻辑**：用 REA 还原几十个核心方法（伤害公式、波次生成、动画状态选择），照着写进自己的实现——这是现在做的事的升级版。
2. **验证行为一致性**：拿原版 dump 出的常量和分支，校准重写版。
3. **写补丁**：Harmony 补丁直接对着汇编改行为（不用还原整段逻辑）。

不建议：试图逐方法还原全部代码再重编。

---

## 6. 文件

| 文件 | 说明 |
|---|---|
| `re\rea_extract.py` | 按类+方法名提取汇编的工具 |
| `re\isil\IsilDump\` | 14,554 个逐方法反汇编 |
| `re\source\DiffableCs\` | 12,578 个结构源码（方法体为空） |
| `re\data\*.json` | 植物/僵尸/关卡数值表 |
