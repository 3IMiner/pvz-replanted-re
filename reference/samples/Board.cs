namespace Reloaded.Gameplay;

public class Board : Widget, IReloadedSerializable, IReloadedPostDeserializable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ActionReference<Int32> <>9__174_0; //Field offset: 0x8
		public static ActionReference<Int32> <>9__174_1; //Field offset: 0x10
		public static Action<GamepadCursor> <>9__175_0; //Field offset: 0x18
		public static ActionReference<SeedBankGamepadControl> <>9__175_1; //Field offset: 0x20
		public static Action<GamepadCursor> <>9__218_0; //Field offset: 0x28
		public static ActionReference<SeedBankGamepadControl> <>9__218_1; //Field offset: 0x30
		public static ActionReference<CursorPreview> <>9__251_0; //Field offset: 0x38
		public static ActionReference<CursorObject> <>9__251_1; //Field offset: 0x40
		public static ActionReference<SeedBank> <>9__251_2; //Field offset: 0x48
		public static Func<Reanimation, Boolean> <>9__457_0; //Field offset: 0x50
		public static Func<Zombie, Boolean> <>9__457_1; //Field offset: 0x58
		public static Func<Plant, Boolean> <>9__457_2; //Field offset: 0x60
		public static Func<GridItem, Boolean> <>9__457_3; //Field offset: 0x68
		public static Func<Coin, Boolean> <>9__457_4; //Field offset: 0x70
		public static Func<Projectile, Boolean> <>9__457_5; //Field offset: 0x78
		public static Func<LawnMower, Boolean> <>9__457_6; //Field offset: 0x80
		public static Action<Reanimation> <>9__459_0; //Field offset: 0x88
		public static Action<Zombie> <>9__459_2; //Field offset: 0x90
		public static Action<Plant> <>9__459_4; //Field offset: 0x98
		public static Action<GridItem> <>9__459_6; //Field offset: 0xA0
		public static Action<Coin> <>9__459_8; //Field offset: 0xA8
		public static Action<Projectile> <>9__459_10; //Field offset: 0xB0
		public static Action<LawnMower> <>9__459_12; //Field offset: 0xB8

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__174_0(ref int val) { }

		internal void <.ctor>b__174_1(ref int val) { }

		internal void <Deserialize>b__459_0(Reanimation i) { }

		internal void <Deserialize>b__459_10(Projectile i) { }

		internal void <Deserialize>b__459_12(LawnMower i) { }

		internal void <Deserialize>b__459_2(Zombie i) { }

		internal void <Deserialize>b__459_4(Plant i) { }

		internal void <Deserialize>b__459_6(GridItem i) { }

		internal void <Deserialize>b__459_8(Coin i) { }

		internal void <DisposeBoard>b__175_0(GamepadCursor cursor) { }

		internal void <DisposeBoard>b__175_1(ref SeedBankGamepadControl control) { }

		internal bool <Serialize>b__457_0(Reanimation r) { }

		internal bool <Serialize>b__457_1(Zombie z) { }

		internal bool <Serialize>b__457_2(Plant p) { }

		internal bool <Serialize>b__457_3(GridItem g) { }

		internal bool <Serialize>b__457_4(Coin c) { }

		internal bool <Serialize>b__457_5(Projectile p) { }

		internal bool <Serialize>b__457_6(LawnMower l) { }

		internal void <Update>b__218_0(GamepadCursor cursor) { }

		internal void <Update>b__218_1(ref SeedBankGamepadControl control) { }

		internal void <UpdateGameObjects>b__251_0(ref CursorPreview preview) { }

		internal void <UpdateGameObjects>b__251_1(ref CursorObject cursor) { }

		internal void <UpdateGameObjects>b__251_2(ref SeedBank bank) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass329_0
	{
		public int totalSun; //Field offset: 0x10

		public <>c__DisplayClass329_0() { }

		internal void <DropLootPiece>b__0(ref Sun sun) { }

	}

	private class BungeeDropGrid
	{
		public TodWeightedGridArray[] GridArray; //Field offset: 0x10
		public int GridArrayCount; //Field offset: 0x18

		public BungeeDropGrid() { }

	}

	private class ZombiePicker
	{
		public int ZombieCount; //Field offset: 0x10
		public int ZombiePoints; //Field offset: 0x14
		public Int32[] ZombieTypeCount; //Field offset: 0x18
		public Int32[] AllWavesZombieTypeCount; //Field offset: 0x20

		public ZombiePicker() { }

	}

	[CompilerGenerated]
	private Action<Int32> ZombieSpawnedInRow; //Field offset: 0x60
	public bool gShownMoreSunTutorial; //Field offset: 0x68
	public DataArray<Zombie> m_zombies; //Field offset: 0x70
	public DataArray<Plant> m_plants; //Field offset: 0x78
	public DataArray<Projectile> m_projectiles; //Field offset: 0x80
	public DataArray<Coin> m_coins; //Field offset: 0x88
	public DataArray<LawnMower> m_lawnMowers; //Field offset: 0x90
	public DataArray<GridItem> m_gridItems; //Field offset: 0x98
	public DataArray<Reanimation> m_reanimationSystem; //Field offset: 0xA0
	public CursorObject mCursorObject; //Field offset: 0xA8
	public List<Zombie> m_vsGravestones; //Field offset: 0xB0
	[CompilerGenerated]
	private readonly MultiplayerType<CursorObject> <CursorObjects>k__BackingField; //Field offset: 0xB8
	public CursorPreview mCursorPreview; //Field offset: 0xC0
	[CompilerGenerated]
	private readonly MultiplayerType<CursorPreview> <CursorPreviews>k__BackingField; //Field offset: 0xC8
	public MessageWidget mAdvice; //Field offset: 0xD0
	[CompilerGenerated]
	private readonly MultiplayerType<SeedBank> <SeedBanks>k__BackingField; //Field offset: 0xD8
	public SeedBank mSeedBank; //Field offset: 0xE0
	public ReloadedObject mShovel; //Field offset: 0xE8
	public GameButton mMenuButton; //Field offset: 0xF0
	public GameButton mStoreButton; //Field offset: 0xF8
	private bool mIgnoreMouseUp; //Field offset: 0x100
	public CutScene mCutScene; //Field offset: 0x108
	public Challenge mChallenge; //Field offset: 0x110
	public bool mPaused; //Field offset: 0x118
	public GridSquareType[2] mGridSquareType; //Field offset: 0x120
	public Int32[2] m_gridCelLook; //Field offset: 0x128
	public Int32[3] m_gridCelOffset; //Field offset: 0x130
	public Int32[2] mGridCelFog; //Field offset: 0x138
	public bool mEnableGraveStones; //Field offset: 0x140
	private int m_specialGraveStoneX; //Field offset: 0x144
	private int m_specialGraveStoneY; //Field offset: 0x148
	public float mFogOffset; //Field offset: 0x14C
	public int mFogBlownCountDown; //Field offset: 0x150
	public PlantRowType[] mPlantRow; //Field offset: 0x158
	public Int32[] m_waveRowGotLawnMowered; //Field offset: 0x160
	public int m_bonusLawnMowersRemaining; //Field offset: 0x168
	public Int32[] mIceMinX; //Field offset: 0x170
	public Int32[] mIceTimer; //Field offset: 0x178
	private ParticleSystemID[] mIceParticleID; //Field offset: 0x180
	private TodSmoothArray[] m_rowPickingArray; //Field offset: 0x188
	public ZombieType[2] mZombiesInWave; //Field offset: 0x190
	public Boolean[] mZombieAllowed; //Field offset: 0x198
	public int mSunCountDown; //Field offset: 0x1A0
	public int mNumSunsFallen; //Field offset: 0x1A4
	public int mShakeCounter; //Field offset: 0x1A8
	public int mShakeAmountX; //Field offset: 0x1AC
	public int mShakeAmountY; //Field offset: 0x1B0
	public BackgroundType mBackground; //Field offset: 0x1B4
	public int mLevel; //Field offset: 0x1B8
	public LevelEntryData mLevelEntryData; //Field offset: 0x1C0
	public int m_sodPosition; //Field offset: 0x1C8
	public MultiplayerType<Int32> mPrevMouseX; //Field offset: 0x1D0
	public MultiplayerType<Int32> mPrevMouseY; //Field offset: 0x1D8
	public MultiplayerType<Sun> mSunMoney; //Field offset: 0x1E0
	public int mNumWaves; //Field offset: 0x1E8
	public int mMainCounter; //Field offset: 0x1EC
	public int mEffectCounter; //Field offset: 0x1F0
	public int mDrawCount; //Field offset: 0x1F4
	public int mRiseFromGraveCounter; //Field offset: 0x1F8
	public int mOutOfMoneyCounter; //Field offset: 0x1FC
	public int mCurrentWave; //Field offset: 0x200
	public int mTotalSpawnedWaves; //Field offset: 0x204
	public TutorialState mTutorialState; //Field offset: 0x208
	public int mTutorialTimer; //Field offset: 0x20C
	public int mLastBungeeWave; //Field offset: 0x210
	public int mZombieHealthToNextWave; //Field offset: 0x214
	public int mZombieHealthWaveStart; //Field offset: 0x218
	public int mZombieCountDown; //Field offset: 0x21C
	public int mZombieCountDownStart; //Field offset: 0x220
	public int mHugeWaveCountDown; //Field offset: 0x224
	public Boolean[] mHelpDisplayed; //Field offset: 0x228
	public AdviceType mHelpIndex; //Field offset: 0x230
	public bool m_finalBossKilled; //Field offset: 0x234
	public bool mShowShovel; //Field offset: 0x235
	public bool mShowCoinBank; //Field offset: 0x236
	public bool mShowProgress; //Field offset: 0x237
	public bool mShowMenuButton; //Field offset: 0x238
	public bool mOnlyBurnedZombies; //Field offset: 0x239
	public bool mUsedWallNotAttackPlants; //Field offset: 0x23A
	public bool mUsedPogoPartyPlants; //Field offset: 0x23B
	public bool mHasSpawnedFlagZombie; //Field offset: 0x23C
	public bool mLastZombieMowered; //Field offset: 0x23D
	public bool mScreenWhiteout; //Field offset: 0x23E
	private bool mBackDropInitialized; //Field offset: 0x23F
	public int mCoinBankFadeCount; //Field offset: 0x240
	private int mBoardFadeOutCounter; //Field offset: 0x244
	public bool mLevelComplete; //Field offset: 0x248
	public int mNextSurvivalStageCounter; //Field offset: 0x24C
	public int mScoreNextMowerCounter; //Field offset: 0x250
	public bool mLevelAwardSpawned; //Field offset: 0x254
	public int mProgressMeterWidth; //Field offset: 0x258
	public int mFlagRaiseCounter; //Field offset: 0x25C
	public int mIceTrapCounter; //Field offset: 0x260
	public uint mBoardRandSeed; //Field offset: 0x264
	public ParticleSystemID mPoolSparklyParticleID; //Field offset: 0x268
	public List<Single> mFlagXPositions; //Field offset: 0x270
	public List<Single> mFlagYPositions; //Field offset: 0x278
	public ReanimationID[2] mFwooshID; //Field offset: 0x280
	public int mFwooshCountDown; //Field offset: 0x288
	public int mTimeStopCounter; //Field offset: 0x28C
	public ControllerPool<ReanimationController> mButterPool; //Field offset: 0x290
	public bool mDroppedFirstCoin; //Field offset: 0x298
	public int mFinalWaveSoundCounter; //Field offset: 0x29C
	public int mCobCannonCursorDelayCounter; //Field offset: 0x2A0
	public int mCobCannonMouseX; //Field offset: 0x2A4
	public int mCobCannonMouseY; //Field offset: 0x2A8
	public bool mKilledYeti; //Field offset: 0x2AC
	public bool mMustacheMode; //Field offset: 0x2AD
	public bool m_superMowerMode; //Field offset: 0x2AE
	public bool mFutureMode; //Field offset: 0x2AF
	public bool mPinataMode; //Field offset: 0x2B0
	public bool mDanceMode; //Field offset: 0x2B1
	public bool mDaisyMode; //Field offset: 0x2B2
	[CompilerGenerated]
	private bool <mChinaMode>k__BackingField; //Field offset: 0x2B3
	public bool m_sukhbirMode; //Field offset: 0x2B4
	private bool m_preorderContentMode; //Field offset: 0x2B5
	private bool m_retroContentMode; //Field offset: 0x2B6
	private bool m_platformContentMode; //Field offset: 0x2B7
	public BoardResult m_prevBoardResult; //Field offset: 0x2B8
	public bool mPeaShooterUsed; //Field offset: 0x2BC
	public bool mCatapultPlantsUsed; //Field offset: 0x2BD
	public int mCollectedCoinStreak; //Field offset: 0x2C0
	public int mGargantuarsKillsByCornCob; //Field offset: 0x2C4
	public bool mMushroomAndCoffeeBeansOnly; //Field offset: 0x2C8
	public bool mMushroomsUsed; //Field offset: 0x2C9
	public int m_triggeredLawnMowers; //Field offset: 0x2CC
	public int m_playTimeActiveLevel; //Field offset: 0x2D0
	public int m_playTimeInactiveLevel; //Field offset: 0x2D4
	public int m_maxSunPlants; //Field offset: 0x2D8
	public int m_startDrawTime; //Field offset: 0x2DC
	public int mIntervalDrawTime; //Field offset: 0x2E0
	public int mIntervalDrawCountStart; //Field offset: 0x2E4
	public float mMinFPS; //Field offset: 0x2E8
	public int m_preloadTime; //Field offset: 0x2EC
	public int m_gameID; //Field offset: 0x2F0
	public int mGravesCleared; //Field offset: 0x2F4
	public int mPlantsEaten; //Field offset: 0x2F8
	public int mPlantsShoveled; //Field offset: 0x2FC
	public int mCoinsCollected; //Field offset: 0x300
	public int mDiamondsCollected; //Field offset: 0x304
	public int mPottedPlantsCollected; //Field offset: 0x308
	public int mChocolateCollected; //Field offset: 0x30C
	public GameplayActivity mApp; //Field offset: 0x310
	private TutorialArrowController m_tutorialArrow; //Field offset: 0x318
	private GamepadCursor[] m_gamepadCursors; //Field offset: 0x320
	private MultiplayerType<SeedBankGamepadControl> m_seedBankControls; //Field offset: 0x328
	private bool m_isStateFromDeserialization; //Field offset: 0x330
	[CompilerGenerated]
	private bool <DisableChallengeActions>k__BackingField; //Field offset: 0x331

	public event Action<Int32> ZombieSpawnedInRow
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public MultiplayerType<CursorObject> CursorObjects
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public MultiplayerType<CursorPreview> CursorPreviews
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool DisableChallengeActions
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public GamepadCursor[] GamepadCursors
	{
		 get { } //Length: 8
	}

	public bool IsStateFromDeserialization
	{
		 get { } //Length: 8
	}

	public private bool mChinaMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 164
	}

	public MultiplayerType<SeedBank> SeedBanks
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool ShowShovel
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	private void _processGamepadCursors(Action<GamepadCursor> action) { }

	public Board(GameplayActivity theApp) { }

	[CompilerGenerated]
	private void <Deserialize>b__459_1(Reanimation i) { }

	[CompilerGenerated]
	private void <Deserialize>b__459_11(Projectile i) { }

	[CompilerGenerated]
	private void <Deserialize>b__459_13(LawnMower i) { }

	[CompilerGenerated]
	private void <Deserialize>b__459_3(Zombie i) { }

	[CompilerGenerated]
	private void <Deserialize>b__459_5(Plant i) { }

	[CompilerGenerated]
	private void <Deserialize>b__459_7(GridItem i) { }

	[CompilerGenerated]
	private void <Deserialize>b__459_9(Coin i) { }

	[CompilerGenerated]
	private void <FadeOutLevel>b__279_0(ref CursorObject cursor) { }

	[CompilerGenerated]
	private void <FadeOutLevel>b__279_1(ref CursorObject cursor) { }

	[CompilerGenerated]
	private void <InitLevel>b__186_0(ref Sun sun) { }

	[CompilerGenerated]
	private void <InitLevel>b__186_1(ref SeedBank bank) { }

	[CompilerGenerated]
	private void <InitLevel>b__186_2(ref SeedBank bank) { }

	[CompilerGenerated]
	public void add_ZombieSpawnedInRow(Action<Int32> value) { }

	public GridItem AddACrater(int theGridX, int theGridY) { }

	public GridItem AddAGraveStone(int theGridX, int theGridY) { }

	public GridItem AddALadder(int theGridX, int theGridY) { }

	public Coin AddCoin(float theX, float theY, CoinType theCoinType, CoinMotion theCoinMotion) { }

	private void AddGraveStones(int theGridX, int theCount, MTRand theLevelRNG) { }

	public Plant AddPlant(int theGridX, int theGridY, SeedType theSeedType, SeedType theImitaterType, bool forceDecemberContent = false, bool forceNormalContent = false) { }

	public Projectile AddProjectile(int theX, int theY, int aRenderOrder, int theRow, ProjectileType projectileType) { }

	public Projectile AddProjectile(float theX, float theY, int aRenderOrder, int theRow, ProjectileType projectileType) { }

	public void AddSunMoney(int theAmount, int playerIndex) { }

	public Zombie AddZombie(ZombieType theZombieType, int theFromWave, bool shakeBrush = true) { }

	public Zombie AddZombieAtCell(ZombieType theZombieType, int x, int y) { }

	public Zombie AddZombieInRow(ZombieType theZombieType, int theRow, int theFromWave, bool shakeBrush = true) { }

	public bool AllowNonCursorSeedPlant(int playerIndex) { }

	public bool AreEnemyZombiesOnScreen() { }

	private void BungeeDropZombie(BungeeDropGrid theBungeeDropGrid, ZombieType theZombieType) { }

	public bool BungeeIsTargetingCell(int theCol, int theRow) { }

	private void ButtonMouseEnter(int theId) { }

	private void ButtonMouseLeave(int theId) { }

	private void ButtonPress(int theId) { }

	private bool CanAddBobSled() { }

	public bool CanAddGraveStoneAt(int theGridX, int theGridY) { }

	public bool CanDropLoot() { }

	private bool CanInteractWithBoardButtons(int playerIndex) { }

	public PlantingReason CanPlantAt(int theGridX, int theGridY, SeedType theType) { }

	public bool CanTakeSunMoney(int theAmount, int playerIndex) { }

	public bool CanUseGameObject(ReloadedObjectType theGameObject) { }

	private bool CanZombieSpawnOnLevel(ZombieType theZombieType, int theLevel) { }

	public bool CheckForPostGameAchievements() { }

	public bool ChooseSeedsOnCurrentLevel() { }

	public void ClearAdvice(AdviceType theHelpIndex) { }

	public void ClearAdviceImmediately() { }

	public void ClearCursor(bool ignoreControlType = false, int playerIndex = 0) { }

	private void ClearFogAroundPlant(Plant thePlant, int theSize) { }

	private void CompleteEndLevelSequenceForSaving() { }

	public int CountCoinByType(CoinType theCoinType) { }

	private int CountCoinsBeingCollected() { }

	public int CountEmptyPotsOrLilies(SeedType theSeedType) { }

	public int CountPlantByType(SeedType theSeedType) { }

	public int CountSunBeingCollected(int playerIndex) { }

	public int CountSunFlowers() { }

	private int CountUntriggerLawnMowers() { }

	public int CountZombiesOnScreen() { }

	public override void Deserialize(ref ReloadedBinaryReader reader, int version) { }

	public void DeserializeBoardData(ref ReloadedBinaryReader reader, int version) { }

	private void DeserializeDataArray(DataArray<T> dataArray, ref ReloadedBinaryReader reader, int version, Action<T> clearItemAction, Action<T> initItemAction, string dataName) { }

	public void DisplayAdvice(string theAdvice, MessageStyle theMessageStyle, AdviceType theHelpIndex) { }

	public void DisplayAdviceAgain(string theAdvice, MessageStyle theMessageStyle, AdviceType theHelpIndex) { }

	public void DisposeBoard() { }

	public void DoFwoosh(int theRow) { }

	public void DoPlantingEffects(int theGridX, int theGridY, Plant thePlant) { }

	private void DoTypingCheck(char theKey) { }

	public virtual void Draw() { }

	private void DrawBackdrop() { }

	private void DrawDebugObjectRects() { }

	private void DrawFadeOut() { }

	private void DrawFog() { }

	private void DrawGameObjects() { }

	private void DrawIce(int y) { }

	private void DrawLevel() { }

	private void DrawProgressMeter() { }

	private void DrawShovel() { }

	private void DrawTopRightUI() { }

	private void DrawUICoinBank() { }

	private void DrawZenButtons() { }

	private void DrawZenWheelBarrowButton(int theOffsetY) { }

	public void DropLootPiece(float thePosX, float thePosY, int theDropFactor) { }

	public void DropLootPiece(int thePosX, int thePosY, int theDropFactor) { }

	public void FadeOutLevel() { }

	public LawnMower FindLawnMowerInRow(int theRow) { }

	public Plant FindUmbrellaPlant(int theGridX, int theGridY) { }

	private void FreezeEffectsForCutscene(bool theFreeze) { }

	[CompilerGenerated]
	public MultiplayerType<CursorObject> get_CursorObjects() { }

	[CompilerGenerated]
	public MultiplayerType<CursorPreview> get_CursorPreviews() { }

	[CompilerGenerated]
	public bool get_DisableChallengeActions() { }

	public GamepadCursor[] get_GamepadCursors() { }

	public bool get_IsStateFromDeserialization() { }

	[CompilerGenerated]
	public bool get_mChinaMode() { }

	[CompilerGenerated]
	public MultiplayerType<SeedBank> get_SeedBanks() { }

	public bool get_ShowShovel() { }

	public Zombie GetBossZombie() { }

	private LawnMower GetBottomLawnMower() { }

	public Reanimation GetButterReanimation() { }

	private GridItem GetCraterAt(int theGridX, int theGridY) { }

	public int GetCurrentPlantCost(SeedType theSeedType, SeedType theImitaterType) { }

	public Plant GetFlowerPotAt(int theGridX, int theGridY) { }

	public GridItem GetGraveStoneAt(int theGridX, int theGridY) { }

	public int GetGraveStoneCount() { }

	public GridItem GetGridItemAt(GridItemType theGridItemType, int theGridX, int theGridY) { }

	private int GetIceZPos(int theRow) { }

	private ZombieType GetIntroducedZombieType() { }

	public GridItem GetLadderAt(int theGridX, int theGridY) { }

	public uint GetLevelRandSeed() { }

	public int GetLiveGargantuarCount() { }

	public int GetNumRows() { }

	public int GetNumSeedsInBank() { }

	public int GetNumWavesPerFlag() { }

	public int GetNumWavesPerSurvivalStage() { }

	public PlantsOnLawn GetPlantsOnLawn(int theGridX, int theGridY) { }

	public float GetPosYBasedOnRow(float thePosX, int theRow) { }

	public Plant GetPumpkinAt(int theGridX, int theGridY) { }

	private GridItem GetRake() { }

	private int GetRandomNonGrassLaneIdx() { }

	public GridItem GetScaryPotAt(int theGridX, int theGridY) { }

	public int GetSeedBankExtraWidth() { }

	public int GetSeedPacketPositionX(int theIndex, int numPackets) { }

	public SeedType GetSeedTypeInCursor(int playerIndex) { }

	private Rect GetShovelButtonRect() { }

	public GridItem GetSquirrelAt(int theGridX, int theGridY) { }

	public int GetSurvivalFlagsCompleted() { }

	public Plant GetTopPlantAt(int theGridX, int theGridY, PlantPriority thePriority) { }

	public TutorialArrowController GetTutorialArrow() { }

	public Zombie GetVSGravestoneAt(int theGridX, int theGridY) { }

	private Zombie GetWinningZombie() { }

	public Rect GetZenButtonRect(ReloadedObjectType theObjectType) { }

	public GridItem GetZenToolAt(int theGridX, int theGridY) { }

	public bool GrantAchievement(AchievementType theAchievement, bool show) { }

	public int GridToPixelX(int theGridX, int theGridY) { }

	public int GridToPixelY(int theGridX, int theGridY) { }

	public bool HasConveyorBeltSeedBank() { }

	public bool HasLevelAwardDropped() { }

	private bool HasProgressMeter() { }

	private bool HasValidCobCannonSpot() { }

	public void HighlightPlantsForMouse(int theMouseX, int theMouseY, int playerIndex) { }

	public void InitLawnMowers() { }

	public void InitLevel() { }

	public void InitSurvivalStage() { }

	public void InitZombieWaves() { }

	private void InitZombieWavesForLevel(int aForLevel) { }

	public bool IsFinalScaryPotterStage() { }

	public bool IsFinalSurvivalStage() { }

	public bool IsFlagWave(int theWaveNumber) { }

	public bool IsGamepadEnabled(int playerIndex = 0) { }

	private bool IsIceAt(int theGridX, int theGridY) { }

	private bool IsLastStandFinalStage() { }

	public bool IsLastStandStageWithRepick() { }

	public bool IsPlantInCursor(int playerIndex) { }

	public bool IsPlantInGoldWateringCanRange(int theMouseX, int theMouseY, Plant thePlant) { }

	public bool IsPoolSquare(int theGridX, int theGridY) { }

	public bool IsScaryPotterDaveTalking() { }

	public bool IsSurvivalStageWithRepick() { }

	public bool IsValidCobCannonSpot(int theGridX, int theGridY) { }

	private bool IsValidCobCannonSpotHelper(int theGridX, int theGridY) { }

	public static bool IsZombieTypePoolOnly(ZombieType theZombieType) { }

	private bool IsZombieWaveDistributionOk() { }

	[Obsolete("Callers should create their own loop")]
	private bool IterateCoins(Coin theCoin) { }

	private bool IterateGridItems(GridItem theGridItem) { }

	private bool IterateLawnMowers(LawnMower theLawnMower) { }

	private bool IterateParticles(TodParticleSystem theParticle) { }

	[Obsolete("Callers should create their own loop")]
	private bool IteratePlants(Plant thePlant) { }

	private bool IterateProjectiles(Projectile theProjectile) { }

	private bool IterateReanimations(Reanimation theReanimation) { }

	private bool IterateZombies(Zombie theZombie) { }

	private void KeyChar(char theChar) { }

	private void KeyDown(KeyCode theKeyCode) { }

	private void KeyUp(KeyCode theKeyCode) { }

	public void KillAllPlantsInRadius(int theX, int theY, int theRadius) { }

	public void KillAllPlantsInRadius(float theX, float theY, int theRadius) { }

	public int KillAllZombiesInRadius(int theRow, float theX, float theY, int theRadius, int theRowRange, bool theBurn, DamageRangeFlags theDamageRangeFlags) { }

	public int KillAllZombiesInRadius(int theRow, int theX, int theY, int theRadius, int theRowRange, bool theBurn, DamageRangeFlags theDamageRangeFlags) { }

	public int LeftFogColumn() { }

	private void LoadBackgroundImages() { }

	private bool LoadGame(string theFilePath) { }

	private void MakeEasyZombieType() { }

	public static int MakeRenderOrder(RenderLayer theRenderLayer, int theRow, int theLayerOffset) { }

	public static int MakeRenderOrder(RenderLayer theRenderLayer, float theRow, float theLayerOffset) { }

	public virtual void MouseDown(int x, int y, int theClickCount, int playerIndex) { }

	public Zombie MouseDownButterUpZombie(int x, int y) { }

	private void MouseDownCobcannonFire(int x, int y, int theClickCount, int playerIndex) { }

	private void MouseDownNormal(int x, int y, int theClickCount) { }

	private void MouseDownWithPlant(int x, int y, int theClickCount, int playerIndex) { }

	public void MouseDownWithTool(int x, int y, int theClickCount, CursorType theCursorType, int playerIndex) { }

	public virtual void MouseDrag(int x, int y, int playerIndex) { }

	public bool MouseHitTest(int x, int y, ref HitResult theHitResult, int playerIndex) { }

	private bool MouseHitTestPlant(int x, int y, ref HitResult theHitResult, int playerIndex) { }

	public virtual void MouseMove(int x, int y, int playerIndex) { }

	public virtual void MouseUp(int x, int y, int theClickCount, int playerIndex) { }

	public virtual void Move(int x, int y, float duration) { }

	private bool NeedSaveGame() { }

	public Plant NewPlant(int theGridX, int theGridY, SeedType theSeedType, SeedType theImitaterType, bool forceDecemberContent = false, bool forceNormalContent = false) { }

	public void NextWaveComing() { }

	private int NumberZombiesInWave(int theWaveIndex) { }

	private void OffsetYForPlanting(ref int theY, SeedType theSeedType) { }

	private void Pause(bool thePause) { }

	public void PickBackground() { }

	private ZombieType PickGraveRisingZombieType(int theZombiePoints) { }

	public int PickRowForNewZombie(ZombieType theZombieType) { }

	private void PickSpecialGraveStone() { }

	public bool PickUpTool(ReloadedObjectType theObjectType) { }

	private ZombieType PickZombieType(int theZombiePoints, int theWaveIndex, ZombiePicker theZombiePicker) { }

	private void PickZombieWaves() { }

	public int PixelToGridX(float theX, float theY) { }

	public int PixelToGridX(int theX, int theY) { }

	public int PixelToGridXKeepOnBoard(float theX, float theY) { }

	public int PixelToGridXKeepOnBoard(int theX, int theY) { }

	public int PixelToGridY(int theX, int theY) { }

	public int PixelToGridYKeepOnBoard(float theX, float theY) { }

	public int PixelToGridYKeepOnBoard(int theX, int theY) { }

	public void PlaceRake() { }

	public int PlantingPixelToGridX(int theX, int theY, SeedType theSeedType) { }

	public int PlantingPixelToGridY(int theX, int theY, SeedType theSeedType) { }

	public bool PlantingRequirementsMet(SeedType theSeedType) { }

	private bool PlantUsesAcceleratedPricing(SeedType theSeedType) { }

	public override void PostDeserialize() { }

	private void PostDeserializeDataArray(DataArray<T> dataArray) { }

	public void PostUpdate() { }

	public void ProcessDeleteQueue() { }

	public bool ProgressMeterHasFlags() { }

	private void PutInMissingZombies(int theWaveNumber, ZombiePicker theZombiePicker) { }

	private void PutZombieInWave(ZombieType theZombieType, int theWaveNumber, ZombiePicker theZombiePicker) { }

	private void PuzzleSaveStreak() { }

	private int Rand(int range) { }

	public uint Rand() { }

	public void RefreshSeedPacketFromCursor(int playerIndex, bool forceRefresh = false) { }

	[CompilerGenerated]
	public void remove_ZombieSpawnedInRow(Action<Int32> value) { }

	public void RemoveAllGridItems() { }

	public void RemoveAllPlants() { }

	public void RemoveAllProjectiles() { }

	public void RemoveAllZombies() { }

	public void RemoveCutsceneZombies() { }

	public void RemoveParticleByType(ParticleEffect theEffectType) { }

	private void RemoveZombiesForRepick() { }

	public void ResetCursorIfGamepad(int playerIndex) { }

	public void ResetFPSStats() { }

	public bool RowCanHaveZombies(int theRow) { }

	public bool RowCanHaveZombieType(int theRow, ZombieType theZombieType) { }

	private void SaveGame(string theFilePath) { }

	public RecommentedFlags SeedNotRecommendedForLevel(SeedType theSeedType) { }

	public override void Serialize(ref ReloadedBinaryWriter writer, int version) { }

	public void SerializeBoardData(ref ReloadedBinaryWriter writer, int version) { }

	private void SerializeDataArray(DataArray<T> dataArray, ref ReloadedBinaryWriter writer, int version, Func<T, Boolean> shouldSerializeAction) { }

	[CompilerGenerated]
	public void set_DisableChallengeActions(bool value) { }

	[CompilerGenerated]
	private void set_mChinaMode(bool value) { }

	public void set_ShowShovel(bool value) { }

	public void SetDaisyMode(bool theEnableDaisy) { }

	public void SetDanceMode(bool theEnableDance) { }

	public void SetFutureMode(bool theEnableFuture) { }

	public void SetMustacheMode(bool theEnableMustache) { }

	public void SetPinataMode(bool theEnablePinata) { }

	public void SetPlatformContentMode(bool theEnablePlatformContent) { }

	public void SetPreorderContentMode(bool theEnablePreorderContent) { }

	public void SetRetroContentMode(bool theEnableRetroContent) { }

	private void SetSeedPackets(SeedType[] seedTypes) { }

	public void SetSukhbirMode(bool theEnableSukhbir) { }

	public void SetSuperMowerMode(bool theEnableSuperMower) { }

	public void SetTutorialState(TutorialState theTutorialState) { }

	private void SetupBungeeDrop(BungeeDropGrid theBungeeDropGrid) { }

	public void ShakeBoard(int theShakeAmountX, int theShakeAmountY, float shakeTimeMult = 1) { }

	public void ShowCoinBank() { }

	public void ShowHugeWaveAdvice() { }

	public void SpawnZombiesFromGraves() { }

	public void SpawnZombiesFromPool() { }

	private void SpawnZombiesFromSky() { }

	private void SpawnZombieWave() { }

	private Plant SpecialPlantHitTest(int x, int y) { }

	public bool StageHas6Rows() { }

	public bool StageHasFog() { }

	public bool StageHasGraveStones() { }

	public bool StageHasNoGrass() { }

	public bool StageHasPool() { }

	public bool StageHasRoof() { }

	private bool StageHasZombieWalkInFromRight() { }

	public bool StageIsNight() { }

	public void StartLevel() { }

	public void StopAllZombieSounds() { }

	public void SurvivalSaveScore() { }

	private bool SyncState() { }

	public bool TakeSunMoney(int theAmount, int playerIndex) { }

	public Plant ToolHitTest(int x, int y, int playerIndex) { }

	private int TotalZombiesHealthInWave(int theWaveIndex) { }

	private void TryToSaveGame() { }

	public void TutorialAdvanceFromPickupWater() { }

	public void TutorialArrowRemove() { }

	private void TutorialArrowShow(ReloadedObject obj, int x, int y) { }

	public void TutorialArrowShow(float x, float y) { }

	public void TutorialArrowShow(int x, int y) { }

	public void TutorialArrowShow(ReloadedObject obj) { }

	public virtual void Update() { }

	private void UpdateCursor(int playerIndex) { }

	private void UpdateFog() { }

	private void UpdateFwoosh() { }

	public void UpdateGame() { }

	private void UpdateGameObjects() { }

	private void UpdateGridItems() { }

	private void UpdateIce() { }

	private void UpdateLayers() { }

	private void UpdateLevelEndSequence() { }

	public void UpdateMousePosition(int playerIndex) { }

	private void UpdateProgressMeter() { }

	private void UpdateSunSpawning() { }

	public void UpdateToolTip(int playerIndex) { }

	private void UpdateTutorial() { }

	private void UpdateZombieSpawning() { }

	public void VacuumCoins(int x, int y, int extraClickSize, int playerIndex, CoinVacuumStyle vacuumStyle) { }

	public Zombie ZombieGet(ZombieID theZombieID) { }

	public ZombieID ZombieGetID(Zombie theZombie) { }

	private Zombie ZombieHitTest(int theMouseX, int theMouseY) { }

	private void ZombiePickerInit(ZombiePicker theZombiePicker) { }

	private void ZombiePickerInitForWave(ZombiePicker theZombiePicker) { }

	public void ZombiesWon(Zombie aZombie) { }

	public Zombie ZombieTryToGet(ZombieID theZombieID) { }

	private bool ZombieTypeCanGoInPool(ZombieType theZombieType) { }

	private bool ZombieTypeCanGoOnHighGround(ZombieType theZombieType) { }

}

