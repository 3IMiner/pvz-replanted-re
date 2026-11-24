# 逆向还原进度追踪

> 目标：把 Assembly-CSharp 的 826 类 / 8543 方法全部还原成可编译 C#。
> 产物：`re\port_src\<类>\PlantRea*.cs`（可编译）+ `re\<类>_workbench`（逐方法 md）
> 还原顺序：先易后难，按汇编行数升序。

## 总览

| 指标 | 数值 |
|---|---|
| 总类数 | 826 |
| 总方法数 | 8,543 |
| 已还原方法 | **21** |
| 已生成工作区 | Plant（112 方法） |
| 已解析字段偏移 | Plant(48) / Zombie(约90) / Board(179) |
| 已解析枚举 | SeedType / PlantState / PlantWeapon / PlantSubClass / ZombieType / ZombiePhase / ZombieHeight / HelmType / ShieldType |

## Plant 类进度（112 方法）

### 已完成（21 个，可编译）

**简单方法组（PlantRea_simple.cs，14 个）**
- DrawSeedType / PreloadPlantResources / UpdateNeedsFood → 空实现 stub（汇编只有 ret）
- AttachBlinkAnim → 恒返回 null
- IsOnBoard → `mBoard==null ? false : mIsOnBoard`
- UpdateFlowerPot → mState==FlowerpotInvulnerable(47) 且倒计时归零 → Notready
- UpdateLilypad → 同上，LilypadInvulnerable(48)
- UpdateIceShroom → 非睡眠非 DoingSpecial 时进入 DoingSpecial，倒计时 100
- IsSpiky → mSeedType ∈ {Spikeweed(21), Spikerock(46)}
- EndBlink → mController.DisableBlink()
- GetImage → stub，恒返回 null
- IsAquatic → Lilypad(16)/Tanglekelp(19)/Seashroom(24) + Cattail(43)
- IsUpgrade → mSeedType ∈ [40,47]
- HasHeadAnimation → Peashooter/Snowpea/Repeater/Threepeater/Splitpea/Gatlingpea/Leftpeater
- NotOnGround → Squash 升起/下落/落地态 或 mSquished 或 mOnBungeeState==RisingWithBungee 或 mDead

**早前验证（REA 示例，3 个）**
- IsFlying → `seedtype == InstantCoffee(35)`
- MakesSun → `mSeedType ∈ {Sunflower(1), Twinsunflower(41), Sunshroom(9)}`
- IsNocturnal → 位图 0x8100F700（8,9,10,12,13,14,15,24,31）+ Gloomshroom(42)

**核心玩法（PlantRea.cs，2 个，部分依赖待补）**
- UpdateShooter → 射击循环：mLaunchCounter 递减、随机间隔、Threepeater/Starfruit/Splitpea/Cactus 分支、连发定时
- UpdateProductionPlant → 产阳光：屏蔽模式、Marigold 满状态、产阳光间隔 RandRangeInt(rate-150, rate)、Sunflower/Twinsunflower/Sunshroom/Marigold 产币、雨天判断、ChallengeBigTime 额外产币

### 待还原（91 个）
按难度：FindTargetAndFire / FindTargetZombie / Fire / LaunchThreepeater / FindStarFruitTarget / GetCost / GetRefreshTime / GetNameString / GetToolTip / BurnRow / IceZombies / BlowAwayFliers / DoRowAreaDamage / Animate / Update / Die / PlantInitialize / DoSpecial / UpdateAbilities ...（见 `re\port_src\Plant\_index.md`）

## 关键资源

| 文件 | 内容 |
|---|---|
| `re\ENUMS.md` | 全部枚举值 |
| `re\FIELDS.md` | Plant/Zombie/Board 字段偏移表 |
| `re\rea_extract.py` | 按类+方法抽汇编 |
| `re\rea_workbench.py` | 生成逐方法还原工作区 |
| `re\isil\IsilDump\` | 全部方法汇编 |
| `re\source\DiffableCs\` | 结构源码（方法体空） |

## 方法论

1. `python re\rea_extract.py <类> <方法>` 提取汇编+ISIL
2. 查 FIELDS.md 映射 `[rbx+0xNN]` → 字段名
3. 查 ENUMS.md 映射立即数 → 枚举名
4. 控制流转 if/switch；尾调用、接口分派还原成方法调用
5. 写 `<类>Rea*.cs`；未还原依赖用 `throw new NotImplementedException("批次N")` + 注释标注不确定点
6. 语义交叉验证（如 MakesSun 覆盖全部产阳光植物）

## 并发协调

- 一个文件同一时刻只能一个 writer 写，避免互相覆盖（已发生过 PlantRea_simple.cs 被覆盖）。
- 分工：子代理负责独立方法组，写不同的文件（如 `PlantRea_shoot.cs`、`PlantRea_damage.cs`），不写同一文件。

## 下一步（P2 核心玩法组，按依赖顺序）

1. FindTargetZombie / FindTargetAndFire（射击目标选择，Plant 最核心）
2. Fire（发射子弹，1251 行）
3. GetCost / GetRefreshTime（数值方法，268/166 行）
4. Projectile 类（27 方法，子弹行为）
5. SeedBank / SeedPacket / LawnMower / Coin
