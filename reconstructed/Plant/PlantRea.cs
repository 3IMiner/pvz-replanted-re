using System;
using UnityEngine;
using Reloaded.Gameplay;
using Reloaded.TreeStateActivities;

namespace ReplantedSource
{
    /// <summary>
    /// Plant 核心玩法还原（REA：从 x64 汇编逐条还原）。
    /// 字段偏移来自 Plant.cs 结构 dump：
    ///   mSeedType=0x70, mPlantCol=0x74, mState=0x88, mStateCountdown=0xA0,
    ///   mLaunchCounter=0xA4, mLaunchRate=0xA8, mTargetX=0xCC, mTargetY=0xD0,
    ///   mShootingCounter=0xDC, mController=0x140, mIsOnBoard=0x137
    /// </summary>
    public static partial class PlantRea
    {
        // ---------------- 射击循环 UpdateShooter() ----------------
        // 汇编关键结构：
        //   mLaunchCounter = [rbx+0xA4];  mLaunchRate = [rbx+0xA8]
        //   mLaunchCounter--;  if (mLaunchCounter > 0) return;
        //   mLaunchCounter = mLaunchRate - Common.Rand(0, 15);   // 加随机抖动
        //   然后按 mSeedType 分支：
        //     Threepeater(18) -> LaunchThreepeater()
        //     Starfruit(29)   -> 星果逻辑（播 anim_shoot + 发射）
        //     Splitpea(28)    -> FindTargetAndFire(row, 1) 双弹道
        //     Cactus(26)      -> 仅当 mState==32/30 才开火
        //     默认            -> FindTargetAndFire(row, 0)
        //   附加定时：
        //     mLaunchCounter==50 且 mSeedType==43(Cattail) -> 再射
        //     mLaunchCounter==25 且 (Repeater=7 / Leftpeater=52 / Splitpea=28) -> 射第二发
        // ---------------- 产阳光 UpdateProductionPlant() ----------------
        //   先屏蔽：GameMode in {43,50,71,72}、IsIZombieLevel、HasLevelAwardDropped、Marigold(38)满状态
        //   mLaunchCounter--; 若 <=0:
        //     间隔 = mLaunchRate - Common.Rand(0,15)
        //     Sunflower(1)/SunShroom(9)/TwinSunflower(41) -> AddCoin(位置, coinType)
        //     Marigold(38) -> 特殊硬币逻辑
        //     GameMode==39 且 (Sunflower/双子) -> 额外硬币
        // ---------------- 目标搜索 FindTargetZombie/FindTargetAndFire ----------------
        //   遍历 board 的僵尸列表，按行、攻击矩形、PlantWeapon 判定最近目标

        /// <summary>还原 UpdateShooter 的骨架（伪代码级，标注了每个分支的来源指令）。</summary>
        public static void UpdateShooter(Plant plant)
        {
            // 012-015: mLaunchCounter--
            plant.mLaunchCounter--;

            // 016-017: if (mLaunchCounter > 0) return
            if (plant.mLaunchCounter > 0) return;

            // 023-026: mLaunchRate -= Common.Rand(0, 15)
            int rand = Common.Rand(0, 15);
            plant.mLaunchCounter = plant.mLaunchRate - rand;

            // 027-028: if (mSeedType == Threepeater(18))
            if (plant.mSeedType == SeedType.Threepeater)
            {
                // 134-136: LaunchThreepeater()
                LaunchThreepeater(plant);
                return; // 实际汇编里这里 goto 137(结尾)
            }

            // 030-031: if (mSeedType == Starfruit(29))
            if (plant.mSeedType == SeedType.Starfruit)
            {
                // 星果：FindStarFruitTarget + 播 anim_shoot + mShootingCounter=40
                if (FindStarFruitTarget(plant))
                {
                    var controller = plant.mController;
                    if (controller != null)
                    {
                        string anim = "anim_shoot".Replace("anim_", "");
                        controller.PlayAnimationOnTrack(anim, 3);
                    }
                    plant.mShootingCounter = 40; // [rbx+0xDC] = 40
                }
                return;
            }

            // 032-033: if (mSeedType == Splitpea(28))
            if (plant.mSeedType == SeedType.Splitpea)
            {
                // 052-056: FindTargetAndFire(row, 1) —— 第二弹道（weapon=1）
                FindTargetAndFire(plant, plant.mStartRow, 1);
                return;
            }

            // 034-035: if (mSeedType == Cactus(26))
            if (plant.mSeedType == SeedType.Cactus)
            {
                // 042-045: 仅当 mState==32/30 才开火
                if (plant.mState == (PlantState)32 || plant.mState == (PlantState)30)
                {
                    FindTargetAndFire(plant, plant.mStartRow, 0);
                }
                return;
            }

            // 036-040: 默认 —— FindTargetAndFire(row, 0)
            FindTargetAndFire(plant, plant.mStartRow, 0);

            // 137-145: if (mLaunchCounter==50 && mSeedType==Cattail(43)) 再射
            if (plant.mLaunchCounter == 50 && plant.mSeedType == SeedType.Cattail)
            {
                FindTargetAndFire(plant, plant.mStartRow, 0);
            }

            // 146-165: if (mLaunchCounter==25 && (Repeater/Leftpeater/Splitpea)) 第二发
            if (plant.mLaunchCounter == 25 &&
                (plant.mSeedType == SeedType.Repeater ||
                 plant.mSeedType == SeedType.Leftpeater ||
                 plant.mSeedType == SeedType.Splitpea))
            {
                FindTargetAndFire(plant, plant.mStartRow, 0);
            }
        }

        /// <summary>
        /// 还原 UpdateProductionPlant()（产阳光核心逻辑）。
        /// 汇编关键结构：
        ///   屏蔽条件（直接 return）：
        ///     GameMode in {43 ChallengeZenGarden, 50 TreeOfWisdom, 71 Upsell, 72 Intro}
        ///     IsIZombieLevel()、Board.HasLevelAwardDropped()
        ///     Marigold(38) 且 mCurrentWave==mNumWaves 且 mState==MarigoldEnding 且 mStateCountdown==0
        ///   主循环：
        ///     mLaunchCounter--;
        ///     若 mLaunchCounter<=100 且(不下雨 或 Marigold)：刷新 mEatenFlashCountdown（TodAnimateCurve 线性）
        ///     若 mLaunchCounter>0 return
        ///     mLaunchCounter = RandRangeInt(mLaunchRate-150, mLaunchRate)   // 产阳光间隔带随机
        ///     播 Foley(SpawnSun)
        ///     按 mSeedType 产币：Sunflower/Twinsunflower->Sun、Sunshroom->(SmallSun|Sun)、Marigold->(10%Gold|Silver)
        ///   GameMode==39(ChallengeBigTime) 且 (Sunflower->Sun | Marigold->Silver) 额外产币
        /// </summary>
        public static void UpdateProductionPlant(Plant plant)
        {
            // 012-015: if (mBoard == null || !mIsOnBoard) return
            if (plant.mBoard == null || !plant.mIsOnBoard) return;

            GameplayActivity app = plant.mApp;

            // 019-053: 屏蔽模式
            if (app.GameMode == GameMode.ChallengeZenGarden ||   // 43
                app.GameMode == GameMode.TreeOfWisdom ||          // 50
                app.IsIZombieLevel() ||
                app.GameMode == GameMode.Upsell ||                // 71
                app.GameMode == GameMode.Intro)                   // 72
            {
                return;
            }

            // 054-060: if (Board.HasLevelAwardDropped()) return
            if (plant.mBoard.HasLevelAwardDropped()) return;

            // 061-075: Marigold(38) 满状态处理（当前波==总波数）
            if (plant.mSeedType == SeedType.Marigold &&
                plant.mBoard.mCurrentWave == plant.mBoard.mNumWaves)
            {
                if (plant.mState == PlantState.MarigoldEnding)
                {
                    // 069-072: 已处于 MarigoldEnding 且倒计时归零 -> 直接 return
                    if (plant.mStateCountdown == 0) return;
                    // 072: 倒计时未归零 -> 继续往下走（不重置状态/倒计时）
                }
                else
                {
                    // 074-075: 未进入结束态 -> 进入 MarigoldEnding，倒计时 6000 (0x1770)
                    plant.mState = PlantState.MarigoldEnding;
                    plant.mStateCountdown = 0x1770;
                }
            }

            // 076-090: LastStand(31) 且挑战状态 != LastStandOnslaught(10) -> return
            if (app.GameMode == GameMode.ChallengeLastStand &&
                plant.mBoard.mChallenge.ChallengeState != ChallengeState.LastStandOnslaught)
            {
                return;
            }

            // 091-094: mLaunchCounter--
            plant.mLaunchCounter--;

            // 097-103: 是否下雨（mApp.m_cloudyDayMode.IsRaining，私有字段，见辅助方法）
            bool isRaining = IsRaining(plant);

            // 104-127: 阳光闪烁曲线（mLaunchCounter<=100 且 (不下雨 或 Marigold)）
            if (plant.mLaunchCounter <= 100 &&
                (!isRaining || plant.mSeedType == SeedType.Marigold))
            {
                // TodAnimateCurve(100, 0, mLaunchCounter, 0, 100, Linear)
                int flash = Common.TodAnimateCurve(100, 0, plant.mLaunchCounter, 0, 100, TodCurves.Linear);
                if (plant.mEatenFlashCountdown < flash)
                    plant.mEatenFlashCountdown = flash;
            }

            // 128-129: if (mLaunchCounter > 0) return
            if (plant.mLaunchCounter > 0) return;

            // 130-142: 产阳光间隔 = 随机 [mLaunchRate-150, mLaunchRate)
            //   汇编字面量: RandRangeInt(mLaunchRate-150, mLaunchRate)，等价于 mLaunchRate - RandRangeInt(0,150)
            plant.mLaunchCounter = Common.RandRangeInt(plant.mLaunchRate - 150, plant.mLaunchRate);

            // 143-151: 播产阳光音效（IAudioService.PlayFoley(SpawnSun)，接口分派见辅助方法）
            PlaySpawnSunFoley(plant);

            // 152-185: 主产币逻辑（不下雨时）
            if (!isRaining)
            {
                // 156-173: Sunflower(1) / Twinsunflower(41) -> Sun, FromPlant
                if (plant.mSeedType == SeedType.Sunflower ||
                    plant.mSeedType == SeedType.Twinsunflower)
                {
                    plant.mBoard.AddCoin(plant.mX, plant.mY, CoinType.Sun, CoinMotion.FromPlant);
                }
                // 154-185: Sunshroom(9) -> 小菇 SmallSun，否则 Sun, FromPlant
                else if (plant.mSeedType == SeedType.Sunshroom)
                {
                    CoinType coinType = (plant.mState == PlantState.SunshroomSmall)
                        ? CoinType.SmallSun : CoinType.Sun;
                    plant.mBoard.AddCoin(plant.mX, plant.mY, coinType, CoinMotion.FromPlant);
                }
            }

            // 186-206: Marigold(38) 特殊：10% 金 / 90% 银，Coin 运动
            if (plant.mSeedType == SeedType.Marigold)
            {
                CoinType coinType = (Common.Rand(100) < 10) ? CoinType.Gold : CoinType.Silver;
                plant.mBoard.AddCoin(plant.mX, plant.mY, coinType, CoinMotion.Coin);
            }

            // 207-240: ChallengeBigTime(39) 额外产币
            if (app.GameMode == GameMode.ChallengeBigTime)
            {
                // 214-215, 234-240: Sunflower(1) -> Sun, FromPlant
                if (plant.mSeedType == SeedType.Sunflower)
                {
                    plant.mBoard.AddCoin(plant.mX, plant.mY, CoinType.Sun, CoinMotion.FromPlant);
                }
                // 216-226: Marigold(38) -> Silver, Coin
                else if (plant.mSeedType == SeedType.Marigold)
                {
                    plant.mBoard.AddCoin(plant.mX, plant.mY, CoinType.Silver, CoinMotion.Coin);
                }
            }
        }

        // 占位：这些方法体在后续批次还原。签名来自结构 dump，保证可编译。
        static void LaunchThreepeater(Plant p) { throw new NotImplementedException("批次2"); }
        static bool FindStarFruitTarget(Plant p) { throw new NotImplementedException("批次2"); }
        static void FindTargetAndFire(Plant p, int row, int weapon) { throw new NotImplementedException("批次2"); }

        // 依赖未还原（私有字段 / 接口分派），后续批次补全。
        static bool IsRaining(Plant plant)
        {
            // 097-103: movzx edi, byte ptr [mApp+0xC8(->m_cloudyDayMode)+0x82(<IsRaining>k__BackingField)]
            // GameplayActivity.m_cloudyDayMode 与 CloudyDayMode.<IsRaining> 均为私有字段，
            // 且需处理 m_cloudyDayMode == null 时为 false。
            throw new NotImplementedException("批次N: 读取 plant.mApp.m_cloudyDayMode.IsRaining（私有字段）");
        }

        static void PlaySpawnSunFoley(Plant plant)
        {
            // 143-151: IAudioService 接口分派，r9=4 => FoleyType.SpawnSun。
            // 语义: plant.mApp.SoundSystem.PlayFoley(FoleyType.SpawnSun)，经 mApp+0x58(m_audioService)。
            throw new NotImplementedException("批次N: plant.mApp.SoundSystem.PlayFoley(FoleyType.SpawnSun)");
        }
    }
}
