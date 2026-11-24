using UnityEngine;
using Reloaded.Gameplay;

namespace ReplantedSource
{
    /// <summary>
    /// Plant 简单方法还原（REA 批次1：汇编行数 ≤ 25）。
    /// 每个方法：先注释原始汇编关键点，再给 C# 实现。
    ///
    /// 字段偏移（对照 Plant.cs + 基类 ReloadedObject.cs dump）：
    ///   mApp=0x10(基)  mBoard=0x18(基)  mSquished=0x3C(基)
    ///   mSeedType=0x70  mState=0x88  mDoSpecialCountdown=0x9C  mStateCountdown=0xA0
    ///   mOnBungeeState=0x128  mDead=0x135  mIsAsleep=0x136  mIsOnBoard=0x137  mController=0x140
    ///
    /// 说明：本文件采用「static 类 + 显式 Plant 实参」的移植约定（同 PlantRea.cs）。
    /// 原为实例方法者，第一参数为实例（Plant）；原为 static 者保持原签名。
    /// 本批次跳过已还原方法：IsFlying(#5)、MakesSun(#12)、IsNocturnal(#14)。
    /// </summary>
    public static partial class PlantRea
    {
        // =================================================================
        // #1 DrawSeedType(SeedType, SeedType, DrawVariation, float, float)  [static]
        // 汇编：`ret 0`，无任何有效指令 → 空实现（stub）。
        // =================================================================
        public static void DrawSeedType(SeedType theSeedType, SeedType theImitaterType, DrawVariation theDrawVariation, float thePosX, float thePosY)
        {
            // 汇编仅 ret 0：空方法体
        }

        // =================================================================
        // #2 PreloadPlantResources(SeedType)  [static]
        // 汇编：`ret 0` → 空实现（stub）。
        // =================================================================
        public static void PreloadPlantResources(SeedType theSeedType)
        {
            // 汇编仅 ret 0：空方法体
        }

        // =================================================================
        // #3 UpdateNeedsFood()  [instance]
        // 汇编：`ret 0` → 空实现（stub）。
        // =================================================================
        public static void UpdateNeedsFood(Plant plant)
        {
            // 汇编仅 ret 0：空方法体
        }

        // =================================================================
        // #4 AttachBlinkAnim(Reanimation)  [instance]
        // 汇编：`xor eax,eax ; ret` → 恒返回 null。
        // =================================================================
        public static Reanimation AttachBlinkAnim(Plant plant, Reanimation theReanimBody)
        {
            // xor eax,eax; ret -> 返回 null
            return null;
        }

        // =================================================================
        // #6 IsOnBoard()  [instance]
        // 汇编：
        //   cmp  qword [rcx+0x18],0  ; mBoard == null ?
        //   je   -> false
        //   movzx eax, byte [rcx+0x137]  ; return mIsOnBoard
        // =================================================================
        public static bool IsOnBoard(Plant plant)
        {
            if (plant.mBoard == null) return false;
            return plant.mIsOnBoard;
        }

        // =================================================================
        // #7 UpdateFlowerPot()  [instance]
        // 汇编：
        //   cmp [rcx+0x88],0x2F  ; mState == 47 (FlowerpotInvulnerable)
        //   jne -> return
        //   cmp [rcx+0xA0],0     ; mStateCountdown == 0
        //   jne -> return
        //   mov [rcx+0x88],0     ; mState = 0 (Notready)
        // =================================================================
        public static void UpdateFlowerPot(Plant plant)
        {
            if (plant.mState == PlantState.FlowerpotInvulnerable && plant.mStateCountdown == 0)
                plant.mState = PlantState.Notready;
        }

        // =================================================================
        // #8 UpdateLilypad()  [instance]
        // 汇编：同 #7，但判定 mState == 48 (LilypadInvulnerable)。
        // =================================================================
        public static void UpdateLilypad(Plant plant)
        {
            if (plant.mState == PlantState.LilypadInvulnerable && plant.mStateCountdown == 0)
                plant.mState = PlantState.Notready;
        }

        // =================================================================
        // #9 UpdateIceShroom()  [instance]
        // 汇编：
        //   cmp byte [rcx+0x136],0  ; mIsAsleep != 0 -> return
        //   cmp [rcx+0x88],2        ; mState == 2 (DoingSpecial) -> return
        //   mov [rcx+0x88],2        ; mState = DoingSpecial
        //   mov [rcx+0x9C],0x64     ; mDoSpecialCountdown = 100
        // =================================================================
        public static void UpdateIceShroom(Plant plant)
        {
            if (plant.mIsAsleep) return;
            if (plant.mState == PlantState.DoingSpecial) return;
            plant.mState = PlantState.DoingSpecial;
            plant.mDoSpecialCountdown = 100;
        }

        // =================================================================
        // #10 IsSpiky()  [instance]
        // 汇编：
        //   cmp [rcx+0x70],0x15  ; mSeedType == 21 (Spikeweed) -> true
        //   cmp [rcx+0x70],0x2E  ; mSeedType == 46 (Spikerock) ? sete al
        // =================================================================
        public static bool IsSpiky(Plant plant)
        {
            return plant.mSeedType == SeedType.Spikeweed || plant.mSeedType == SeedType.Spikerock;
        }

        // =================================================================
        // #11 EndBlink()  [instance]
        // 汇编：
        //   mov rcx,[rcx+0x140]  ; rcx = mController
        //   test rcx,rcx ; je -> 抛空引用（call 0x1804FEE20）
        //   xor edx,edx
        //   jmp DisableBlink     ; 尾调用 mController.DisableBlink()
        // =================================================================
        public static void EndBlink(Plant plant)
        {
            // 不确定点：汇编里 `xor edx,edx` 后尾调用 DisableBlink。
            // dump 中 DisableBlink() 无参，edx=0 视为寄存器清零（尾调用前清理），
            // 还原为无参调用。若实际签名带 bool 参数，需改为 DisableBlink(false)。
            plant.mController.DisableBlink();
        }

        // =================================================================
        // #13 GetImage(SeedType)  [instance]
        // 汇编：
        //   mov rcx,[rcx+0x10]   ; rcx = mApp
        //   test rcx,rcx ; je -> 抛空引用
        //   xor r8d,r8d
        //   call GetPlantDefinition(rcx=mApp, rdx=theSeedtype)   ; 结果被丢弃
        //   xor eax,eax ; ret      ; 恒返回 null
        // =================================================================
        public static Sprite GetImage(Plant plant, SeedType theSeedtype)
        {
            // 汇编调用 mApp.GetPlantDefinition(theSeedtype) 但随后 xor eax,eax 丢弃返回值，
            // 恒返回 null —— 该 dump 中此方法为 stub（真实取图逻辑未还原）。
            // 不确定点：xor r8d,r8d 暗示可能传第三参；且真实实现应返回
            // GetPlantDefinition(...).PlantImage 对应的 Sprite，但 asm 明确丢弃结果。
            plant.mApp.GetPlantDefinition(theSeedtype);
            return null;
        }

        // =================================================================
        // #15 IsAquatic(SeedType)  [static]
        // 汇编：
        //   cmp ecx,0x18 ; ja -> 尾段
        //   mov eax,0x01090000 ; bt eax,ecx   ; 位图测试 bit16/19/24
        //   jae -> 尾段
        //   mov al,1 ; ret                      ; true
        //   尾段: cmp ecx,0x2B ; sete al         ; == 43 (Cattail)
        // 位图 0x01090000 = bit16|bit19|bit24 → Lilypad(16)/Tanglekelp(19)/Seashroom(24)
        // =================================================================
        public static bool IsAquatic(SeedType theSeedType)
        {
            // 全部水生植物：荷叶(16)、缠绕海草(19)、海蘑菇(24)，外加猫尾草(43，生长在水上)
            return theSeedType == SeedType.Lilypad ||
                   theSeedType == SeedType.Tanglekelp ||
                   theSeedType == SeedType.Seashroom ||
                   theSeedType == SeedType.Cattail;
        }

        // =================================================================
        // #16 IsUpgrade(SeedType)  [static]
        // 汇编：
        //   lea  eax,[ecx-0x28]    ; eax = theSeedtype - 40
        //   test eax,0xFFFFFFF8    ; (eax & ~7)==0  <=>  theSeedtype ∈ [40,47]
        //   jne -> 尾段
        //   cmp ecx,0x2B ; je -> 尾段(sete)   ; 43(Cattail) 已在 [40,47] 内，属冗余比较
        //   mov al,1 ; ret          ; true
        //   尾段: cmp ecx,0x2B ; sete al
        // =================================================================
        public static bool IsUpgrade(SeedType theSeedtype)
        {
            // 升级植物区间 [40,47]：Gatlingpea(40)..Cobcannon(47)
            return theSeedtype >= SeedType.Gatlingpea && theSeedtype <= SeedType.Cobcannon;
        }

        // =================================================================
        // #17 HasHeadAnimation()  [private instance]
        // 汇编：对 mSeedType 依次 cmp 0/7/40/52/5/28，命中任一 -> true；
        //       否则 `cmp [rcx+0x70],0x12 ; sete al` -> == 18 (Threepeater)。
        // =================================================================
        private static bool HasHeadAnimation(Plant plant)
        {
            // 豌豆系射击植物都有独立头部动画：
            // Peashooter(0)/Snowpea(5)/Repeater(7)/Threepeater(18)/Splitpea(28)/Gatlingpea(40)/Leftpeater(52)
            return plant.mSeedType == SeedType.Peashooter ||
                   plant.mSeedType == SeedType.Repeater ||
                   plant.mSeedType == SeedType.Gatlingpea ||
                   plant.mSeedType == SeedType.Leftpeater ||
                   plant.mSeedType == SeedType.Snowpea ||
                   plant.mSeedType == SeedType.Splitpea ||
                   plant.mSeedType == SeedType.Threepeater;
        }

        // =================================================================
        // #18 NotOnGround()  [instance]
        // 汇编：
        //   cmp [rcx+0x70],0x11      ; mSeedType == 17 (Squash)?
        //   jne -> 跳过 mState 段
        //   cmp [rcx+0x88],5/6/7     ; mState==SquashRising/Falling/DoneFalling -> true
        //   cmp byte [rcx+0x3C],0    ; mSquished != 0 -> true
        //   cmp [rcx+0x128],2        ; mOnBungeeState == 2 (RisingWithBungee) -> true
        //   cmp byte [rcx+0x135],0   ; mDead != 0 -> true
        //   否则 false
        // =================================================================
        public static bool NotOnGround(Plant plant)
        {
            if (plant.mSeedType == SeedType.Squash &&
                (plant.mState == PlantState.SquashRising ||
                 plant.mState == PlantState.SquashFalling ||
                 plant.mState == PlantState.SquashDoneFalling))
                return true;
            if (plant.mSquished) return true;
            if (plant.mOnBungeeState == PlantOnBungeeState.RisingWithBungee) return true;
            if (plant.mDead) return true;
            return false;
        }
    }
}
