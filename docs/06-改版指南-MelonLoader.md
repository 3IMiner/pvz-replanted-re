# 《植物大战僵尸：重植版》改版指南（已实测跑通）

> 对象：`./PVZ Replanted`（Unity 6000.0.52 / IL2CPP / x86-64 / 1.65 GB）
> 产物：`./modded\PVZ Replanted`（带 MelonLoader + 改版插件，可直接玩）

---

## 0. 一句话结论

**改版能做，而且已经做出来了。** 这游戏是数据驱动 + IL2CPP：

- **代码改版**：MelonLoader 0.7.3 已经挂进游戏，interop 程序集已生成，Harmony 补丁能拿到 `Board` 实例，热键实时生效。✅ 本仓库已实现并实机验证。
- **资源改版**：`plantdefinitiondata` / `zombiedefinitiondata` / `leveldata` 等 Addressables 里就是带字段名的 ScriptableObject，用 UABEA 可以直接改数值、关卡、贴图。

而“转 APK”依旧不可能（原生 x64 代码 + 无源码工程），改版只能以 **Windows 版 + 加载器** 的形态存在；要放手机上仍然走 Winlator 那条路（改版 DLL 是 Windows 的，在 Winlator 里同样能被 MelonLoader 加载，但性能开销更大，建议手机端只做资源改版）。

---

## 1. 实机验证记录（2026-11-24）

| 步骤 | 结果 |
|---|---|
| MelonLoader 0.7.3 注入 Unity 6 | ✅ 生成 144 个 interop 程序集 |
| 插件加载 | ✅ 日志 `1 Mod loaded.` |
| Harmony 补丁 `Board.Update` | ✅ 日志 `[改版核心] 已捕获到 Board 实例，热键生效` |
| `Insert` +9999 阳光 | ✅ 阳光 150 → **9990** |
| `Delete` 零冷却 | ✅ 日志 `零冷却：开` |
| `End` 召唤巨人 | ✅ 日志 `已召唤 Gargantuar 于第 2 行`，画面出现巨人 |
| `PageUp` 满屏豌豆 | ✅ 3 行 × 9 列全部种下 |
| `Home` 清场 | ✅ 巨人消失 |

截图见 `docs\`：`改版-阳光9990.png`、`改版-满屏豌豆.png`、`改版-清场后.png`。

> 日志里中文显示为乱码是控制台代码页问题，功能不受影响；实际游戏内文字正常。

---

## 2. 目录说明

```
./
├─ PVZ Replanted\            # 原版，未改动（保持干净）
├─ modded\PVZ Replanted\     # ★ 改版成品：原版 + MelonLoader + Mods\PvZRGaiBan.dll
│   ├─ MelonLoader\          # 加载器（含 Il2CppAssemblies 144 个 interop 程序集）
│   ├─ Mods\PvZRGaiBan.dll   # 改版插件
│   ├─ version.dll           # 注入器
│   └─ Replanted.exe
├─ modsrc\PvZRGaiBan\        # 插件源码（Core.cs + csproj）
├─ tools\                    # dotnet SDK 8（便携）、MelonLoader.x64.zip
├─ ref\                      # 官方模板 PvZRModTemplate、示例 mod pvz-chat-invasion
├─ docs\                     # 验证截图
├─ 构建改版.ps1              # 编译插件并自动部署到 Mods
└─ 打包改版.ps1              # 打成分发用 zip
```

---

## 3. 怎么玩

直接双击 `modded\PVZ Replanted\Replanted.exe`。启动约 20–40 秒（interop 已缓存，不用再等首次的 2–3 分钟）。

热键（特意避开 F1–F12，防止被截图工具抢走）：

| 键 | 效果 |
|---|---|
| `Insert` | +9999 阳光 |
| `Delete` | 零冷却开关（种子卡瞬间恢复） |
| `Home` | 清场（移除所有僵尸） |
| `End` | 召唤一只巨人僵尸 |
| `PageUp` | 满屏豌豆射手（所有行 × 9 列） |
| `PageDown` | 游戏速度 1x / 2x |
| `NumPad0` | 刷 5 只普通僵尸 |

日志：`modded\PVZ Replanted\MelonLoader\Latest.log`

---

## 4. 怎么改代码（开发流程）

### 4.1 编译部署

```powershell
cd <REPO_ROOT>
.\构建改版.ps1
```

脚本做的事：用便携 SDK 编译 `modsrc\PvZRGaiBan\PvZRGaiBan.csproj`（net6.0，引用游戏自带的 MelonLoader 与 interop 程序集），成功后自动把 DLL 复制到 `modded\PVZ Replanted\Mods\`。

改完游戏必须重启才生效（MelonLoader 只在启动时加载 Mods）。

### 4.2 关键 API（从 interop 里挖出来的，可直接用）

命名空间 `Il2CppReloaded.Gameplay`：

| 类型 | 有用成员 |
|---|---|
| `Board` | `AddPlant(x, y, SeedType, SeedType imitater, bool, bool)`、`AddZombie(type, fromWave, shake)`、`AddZombieAtCell(type, x, y)`、`AddSunMoney(int, player)`、`TakeSunMoney`、`RemoveAllZombies()`、`RemoveAllPlants()`、`PickRowForNewZombie(type)`、`RowCanHaveZombies(row)`、`GetNumRows()`、`mSeedBank`、`SeedBanks`、`m_zombies`、`m_plants`、`mLevelComplete` |
| `SeedBank` | `SeedPackets`、`AddSeed(type, placeOnLeft)`、`RemoveSeed(i)`、`RefreshAllPackets()` |
| `SeedPacket` | `mRefreshCounter`、`mRefreshTime`、`mRefreshing`、`mPacketType`、`GetCost()`、`mTimesUsed` |
| `Plant` | `mPlantHealth`、`mPlantMaxHealth`、`mPlantCol`、`mSeedType`、`mState`、`mDead` |
| `Zombie` | `mBodyHealth`、`mBodyMaxHealth`、`mHelmHealth`、`mPosX`、`mPosY`、`mZombieType`、`mDead` |
| `GameplayActivity`（`Il2CppReloaded.TreeStateActivities`） | `Board`、`CostScale`、`CooldownScale`、`EasyPlantingCheat`、`GameScene`、`PreNewGame`、`StartPlaying` |
| 枚举 | `SeedType`（Peashooter/Marigold/Gatlingpea…）、`ZombieType`（Normal/Gargantuar/…） |

### 4.3 拿 Board 实例的标准写法（已验证）

```csharp
[HarmonyPatch(typeof(Board), nameof(Board.Update))]
internal static class BoardUpdatePatch
{
    private static void Postfix(Board __instance) => Core.Current = __instance;
}
```

然后在 `OnUpdate` 里用 `Core.Current` 操作，**必须先判空**（主菜单/选卡界面没有 Board）。

### 4.4 再做一些改版的思路

- **植物无敌**：Harmony 前缀补丁 `Plant.TakeDamage` 或每帧把 `mPlantHealth = mPlantMaxHealth`。
- **秒杀僵尸**：遍历 `m_zombies` 设 `mBodyHealth = 0`。
- **自定义数值**：`GameplayActivity.CostScale / CooldownScale`（需要活动实例，可再用一个 `Board` 补丁顺带抓 `Bootstrap.Instance` 链路）。
- **新植物**：数据层在 `plantdefinitiondata` bundle，代码层要注册 `SeedType`，工作量较大，先从改数值开始。
- **界面菜单**：用 `UnityEngine.GUI` 画一个 IMGUI 面板，或 MelonLoader 的 `MelonPreferences`。

---

## 5. 资源改版（UABEA 路线，不动代码）

`Replanted_Data\StreamingAssets\aa\StandaloneWindows64\` 下的 bundle：

| bundle | 内容 |
|---|---|
| `defaultlocalgroup_assets_plantdefinitiondata_*.bundle` | 植物定义（`m_plantImage`、`m_versus...` 等字段） |
| `defaultlocalgroup_assets_zombiedefinitiondata_*.bundle` | 僵尸定义（`zombieName`、`versusBodyHealth`…） |
| `defaultlocalgroup_assets_leveldata_*.bundle` | 关卡（`initialSun`、`m_zombieTypes`、`m_unlock`…） |
| `defaultlocalgroup_assets_seedbankdata_*`、`boardtooldefinitions_*`、`almanacdata_*` | 种子槽、工具、图鉴 |
| `uiatlasfrontend/gameplay/almanac_*.bundle` | UI 贴图（可换皮） |
| `localization_pc_*.bundle` | 文本 |

流程：

1. 下载 [UABEA](https://github.com/nesrak1/UABEA)（Unity Asset Bundle Extractor）。
2. `File → Open` 选中 bundle → 找到 MonoBehaviour/Texture2D → `View Data` / `Edit`。
3. 改完 `File → Save`（保存回 bundle）。
4. **坑**：Addressables 的 `catalog.bin` 里带 bundle 的 CRC，直接改会导致校验失败或加载不到内容。两个规避办法：
   - 同时改 `catalog.bin` 里的 hash（UABEA 不擅长，需 AssetsTools.NET 手写）；
   - 或者把 bundle 里改好的对象导出，用代码在运行时替换（更麻烦但稳）。
5. 纯数值改动建议优先走代码路线（第 4 节），不碰 CRC。

---

## 6. 打包分发

```powershell
cd <REPO_ROOT>
.\打包改版.ps1
```

产出 `dist\PVZ_Replanted_改版_v1.0.zip`（约 1.7 GB，含加载器 + 插件，Store 模式秒级完成）。

给别人的注意事项：

- 只分发 `modded\PVZ Replanted\` 的内容，**别带** `%USERPROFILE%\AppData\LocalLow\PopCap Games\` 里的存档。
- 对方机器第一次启动仍然要生成 interop（本包已包含 `MelonLoader\Il2CppAssemblies`，可跳过这步）。
- 路径**不能含中文**（见第 7 节）。

---

## 7. 踩坑记录（都是实测踩出来的）

| 坑 | 现象 | 解法 |
|---|---|---|
| 游戏路径含中文 | MelonLoader `plthook_open error`，游戏起来但没有 mod | 整个游戏目录放纯 ASCII 路径 |
| 热键用 F1–F12 | 被 Snipaste 截图键抢走，游戏收不到 | 换 `Insert/Delete/Home/End/PageUp/PageDown/NumPad0` |
| BepInEx 模板 | NuGet 上 `Replanted.PluginTemplate` 已被作者弃用 | 官方推荐 **MelonLoader**，本文即按此实现 |
| winget 装 .NET SDK | UAC 弹窗被会话拦截（1602） | 用 `tools\dotnet` 便携 SDK（已下好） |
| 首次启动 | 2–3 分钟无响应，像卡死 | 在生成 144 个 interop 程序集，等它 |
| Harmony 方法名 | `AddZombieInRow` 是 ReplantAPI 的封装，原生只有 `AddZombie`/`AddZombieAtCell` | 直接对 interop 类型写代码，别照抄示例 |

---

## 8. 下一步

- 想把改版推到手机：资源和 DLL 都能被 Winlator 里的 MelonLoader 加载，但 x64 模拟开销叠加，建议只在手机上做资源改版（第 5 节）。
- 想做“新植物/新僵尸/新关卡”级别的大改版：先做 `plantdefinitiondata` + `SeedType` 的注册实验，再考虑 Harmony 注入新 prefab。
- 想联网/直播互动：参考 `ref\pvz-chat-invasion`（Twitch 弹幕刷僵尸，结构清晰）。
