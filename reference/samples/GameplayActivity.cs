namespace Reloaded.TreeStateActivities;

public class GameplayActivity : InjectableActivity, IInjectionProvider
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ActionReference<SeedBank> <>9__211_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <ShowSeedChooserScreen>b__211_0(ref SeedBank bank) { }

	}

	[CompilerGenerated]
	private struct <ExitIntroCutScene>d__376 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public GameplayActivity <>4__this; //Field offset: 0x28
		private Awaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string k_fadeOutPanelKey = "introFadePanel"; //Field offset: 0x0
	[Inject]
	private IAudioService m_audioService; //Field offset: 0x58
	[Inject]
	private IEffectService m_effectService; //Field offset: 0x60
	[Inject]
	private IDataService m_dataService; //Field offset: 0x68
	[Inject]
	private IUserService m_userService; //Field offset: 0x70
	[Inject]
	private IInputService m_inputService; //Field offset: 0x78
	[Inject]
	private ISerializationService m_serializationService; //Field offset: 0x80
	[Inject]
	private IGameplayService m_gameplayService; //Field offset: 0x88
	[Inject]
	private ISettingsService m_settingsService; //Field offset: 0x90
	[Inject]
	private IRunHistoryService m_runHistoryService; //Field offset: 0x98
	[Inject]
	private IAchievementService m_achievementService; //Field offset: 0xA0
	[Inject]
	private GameplayChooserActivity m_gameplayChooserActivity; //Field offset: 0xA8
	[Inject]
	private ICrazyDaveService m_crazyDaveService; //Field offset: 0xB0
	[Inject]
	private RootModel m_rootModel; //Field offset: 0xB8
	[SerializeField]
	private string m_awardScreenPanelId; //Field offset: 0xC0
	private CloudyDayMode m_cloudyDayMode; //Field offset: 0xC8
	private VersusMode m_versusMode; //Field offset: 0xD0
	[CompilerGenerated]
	private float <CostScale>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private float <CooldownScale>k__BackingField; //Field offset: 0xDC
	[CompilerGenerated]
	private GameScenes <GameScene>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private bool <KilledYetiAndRestarted>k__BackingField; //Field offset: 0xE4
	[CompilerGenerated]
	private BoardResult <BoardResult>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private bool <EasyPlantingCheat>k__BackingField; //Field offset: 0xEC
	private uint m_appRandSeed; //Field offset: 0xF0
	private Random m_random; //Field offset: 0xF4
	[CompilerGenerated]
	private bool <MuteSoundsForCutscene>k__BackingField; //Field offset: 0xF8
	private Board m_board; //Field offset: 0x100
	private ZenGarden m_zenGarden; //Field offset: 0x108
	private LevelEntryData m_levelData; //Field offset: 0x110
	private GameObject m_levelBackground; //Field offset: 0x118
	private LevelStats m_lastLevelStats; //Field offset: 0x120
	private SeedChooserScreen m_seedChooserScreen; //Field offset: 0x128
	private PoolEffect m_poolEffect; //Field offset: 0x130
	private WidgetManager m_widgetManager; //Field offset: 0x138
	private List<Dialog> m_dialogs; //Field offset: 0x140
	private EffectSystem m_effectSystem; //Field offset: 0x148
	private bool mFirstTimeGameSelector; //Field offset: 0x150
	private double m_updateTimer; //Field offset: 0x158
	private Camera m_inputCamera; //Field offset: 0x160
	private Transform m_boardOffset; //Field offset: 0x168
	private int m_width; //Field offset: 0x170
	private BeghouledController m_beghouledController; //Field offset: 0x178
	private List<AsyncOperationHandle> m_loadedHandles; //Field offset: 0x180
	private GameplayPooler m_gameplayPooler; //Field offset: 0x188
	public bool m_isWatchingAdventureIntro; //Field offset: 0x190
	[SerializeField]
	private AssetReferenceGameObject m_pottedPlantReference; //Field offset: 0x198
	[SerializeField]
	private AssetReferenceGameObject m_tutorialArrowReference; //Field offset: 0x1A0
	[SerializeField]
	private AssetReferenceGameObject m_coinReference; //Field offset: 0x1A8
	[SerializeField]
	private AssetReferenceGameObject m_previewCursorReference; //Field offset: 0x1B0
	[SerializeField]
	private AssetReferenceGameObject m_crazyDaveReference; //Field offset: 0x1B8
	[SerializeField]
	private DialogController m_dialogController; //Field offset: 0x1C0
	[SerializeField]
	private MessageWidgetController m_messageWidgetController; //Field offset: 0x1C8
	[SerializeField]
	private BoardViewController m_boardViewController; //Field offset: 0x1D0
	[SerializeField]
	private InputActionReference m_pointAction; //Field offset: 0x1D8
	[SerializeField]
	private InputActionReference m_clickAction; //Field offset: 0x1E0
	[SerializeField]
	private int m_sunSpawnYOffset; //Field offset: 0x1E8
	[SerializeField]
	private GameObject m_beghouledControllerPrefab; //Field offset: 0x1F0
	[SerializeField]
	private FadePanel m_fadePanel; //Field offset: 0x1F8
	private TutorialArrowController m_tutorialArrowController; //Field offset: 0x200
	private BackgroundController m_backgroundController; //Field offset: 0x208
	private ButtonModel m_nextGardenButtonModel; //Field offset: 0x210
	private IDisposable m_menuButtonActionDisposable; //Field offset: 0x218
	private IDisposable m_nextGardenButtonDisposable; //Field offset: 0x220
	private float m_serializationTimer; //Field offset: 0x228
	public DataArray<TodParticleSystem> m_particleSystems; //Field offset: 0x230

	public uint AppRandSeed
	{
		 get { } //Length: 7
	}

	public BackgroundController BackgroundController
	{
		 get { } //Length: 8
	}

	public Board Board
	{
		 get { } //Length: 8
	}

	public BoardResult BoardResult
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool ChinaMode
	{
		 get { } //Length: 76
	}

	public CloudyDayMode CloudyDayMode
	{
		 get { } //Length: 8
	}

	public float CooldownScale
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public float CostScale
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public int CrazyDaveMessageIndex
	{
		 get { } //Length: 76
		 set { } //Length: 90
	}

	public CrazyDaveState CrazyDaveState
	{
		 get { } //Length: 76
	}

	public bool CtrlDown
	{
		 get { } //Length: 3
	}

	public bool DaisyMode
	{
		 get { } //Length: 76
	}

	public bool DanceMode
	{
		 get { } //Length: 76
	}

	public bool DebugKeysEnabled
	{
		 get { } //Length: 3
	}

	public List<Dialog> DialogList
	{
		 get { } //Length: 8
	}

	public bool DisableDebugKeys
	{
		 get { } //Length: 3
	}

	public bool EasyPlantingCheat
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public EffectSystem EffectSystem
	{
		 get { } //Length: 8
	}

	public FadePanel FadePanel
	{
		 get { } //Length: 8
	}

	public bool FutureMode
	{
		 get { } //Length: 76
	}

	public GameMode GameMode
	{
		 get { } //Length: 48
	}

	public IGameplayService GameplayService
	{
		 get { } //Length: 8
	}

	public GameScenes GameScene
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public IInputService InputService
	{
		 get { } //Length: 5
	}

	public bool IsWindowed
	{
		 get { } //Length: 3
	}

	public bool KilledYetiAndRestarted
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public LevelStats LastLevelStats
	{
		 get { } //Length: 8
	}

	public GameObject LevelBackground
	{
		 get { } //Length: 8
	}

	public LevelEntryData LevelData
	{
		 get { } //Length: 8
	}

	public IAudioService Music
	{
		 get { } //Length: 5
	}

	public bool MustacheMode
	{
		 get { } //Length: 76
	}

	public bool MuteSoundsForCutscene
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool PinataMode
	{
		 get { } //Length: 76
	}

	public VersusWinData Player1VersusWinData
	{
		 get { } //Length: 207
		 set { } //Length: 206
	}

	public VersusWinData Player2VersusWinData
	{
		 get { } //Length: 207
		 set { } //Length: 206
	}

	public PoolEffect PoolEffect
	{
		 get { } //Length: 8
	}

	public ReloadedGameMode ReloadedGameMode
	{
		 get { } //Length: 29
	}

	public RootModel RootModel
	{
		 get { } //Length: 8
	}

	public IRunHistoryService RunHistoryService
	{
		 get { } //Length: 8
	}

	public SeedChooserScreen SeedChooserScreen
	{
		 get { } //Length: 8
	}

	public ISerializationService SerializationService
	{
		 get { } //Length: 8
	}

	public ISettingsService SettingsService
	{
		 get { } //Length: 8
	}

	public IAudioService SoundSystem
	{
		 get { } //Length: 5
	}

	public int StoreIntroDialogIndex
	{
		 get { } //Length: 76
		 set { } //Length: 90
	}

	public bool SukhbirMode
	{
		 get { } //Length: 76
	}

	public bool SuperMowerMode
	{
		 get { } //Length: 76
	}

	public bool TodCheatKeys
	{
		 get { } //Length: 3
	}

	public IUserService UserService
	{
		 get { } //Length: 5
	}

	public VersusMode VersusMode
	{
		 get { } //Length: 8
	}

	public WidgetManager WidgetManager
	{
		 get { } //Length: 8
	}

	public int Width
	{
		 get { } //Length: 7
	}

	public ZenGarden ZenGarden
	{
		 get { } //Length: 8
	}

	public ZombieType[] ZombieTypes
	{
		 get { } //Length: 30
	}

	private void _onMenuButtonActivated(ButtonModel buttonModel) { }

	private void _onNextGardenButtonActivated(ButtonModel model) { }

	public GameplayActivity() { }

	protected virtual void ActiveStarted() { }

	protected virtual void ActiveUpdate() { }

	public Reanimation AddReanimation(float x, float y, int renderOrder, ReanimationType animationType) { }

	public TodParticleSystem AddTodParticle(float theX, float theY, int aRenderOrder, ParticleEffect theEffect) { }

	public TodParticleSystem AddTodParticle(float theX, float theY, int aRenderOrder, ParticleEffect theEffect, ZombieType zombieType) { }

	public TodParticleSystem AddTodParticle(float theX, float theY, int aRenderOrder, ParticleEffect theEffect, SunglassesType sunglassesType) { }

	public TodParticleSystem AddTodParticle(float theX, float theY, int aRenderOrder, ParticleEffect theEffect, MustacheType mustacheType) { }

	public TodParticleSystem AddTodParticle(float theX, float theY, int aRenderOrder, ParticleEffect theEffect, SeedType seedType) { }

	public bool AdvanceCrazyDaveText() { }

	protected virtual void Awake() { }

	private void BetaRecordLevelStats() { }

	public void BuyFullVersion() { }

	public bool CanPauseNow() { }

	public bool CanShowAlmanac() { }

	public bool CanShowStore() { }

	public bool CanShowZenGarden() { }

	public bool CanSpawnYetis() { }

	public void ChangeLevelBackground(LevelEntryData levelData, bool setActive) { }

	private void CheckForGameEnd() { }

	public void CrazyDaveDie() { }

	public void CrazyDaveEnter() { }

	public bool CrazyDaveHasController() { }

	public void CrazyDaveLeave() { }

	public void CrazyDavePlayAnimation(string animName, float fps) { }

	public void CrazyDaveSetPosition(float x, float y) { }

	public void CrazyDaveStopSound() { }

	public void CrazyDaveStopTalking() { }

	public void CrazyDaveTalkIndex(int index) { }

	public void CrazyDaveTalkMessage(string message) { }

	public CoinController CreateCoinController(Coin coin) { }

	public CursorController CreateCursorController(CursorType cursorType, ReloadedObject cursor) { }

	public FocusCircleController CreateFocusCircleController() { }

	public GamepadCursorController CreateGamepadCursorController(GamepadCursor gamepadCursor, int playerIndex) { }

	public GridItemController CreateGridItemController(GridItemType gridItemType, GridItem gridItem) { }

	public GridPlacementPreviewController CreateGridPlacementPreviewController(ReloadedObject previewObject, bool forRow) { }

	public IceTrapController CreateIceTrapController(ZombieController zombieController) { }

	public LawnMowerController CreateLawnMowerController(LawnMower lawnMower) { }

	public MagnetItemController CreateMagnetItemController(MagnetItemType magnetItemType, Transform parent) { }

	public PlantController CreatePlantController(SeedType type, Plant plant, bool easterEggAllowed = false, bool forceDecemberContent = false, bool forceNormalContent = false, bool forceRetroContent = false) { }

	public PottedPlantController CreatePottedPlantController(PlantController parent) { }

	public PreviewController CreatePreviewController(SeedType seedType, Transform parent) { }

	public PreviewController CreatePreviewController(SeedType seedType, Transform parent, PottedPlant pottedPlant) { }

	public PreviewController CreatePreviewController(SeedType seedType, ReloadedObject cursorPreview, PottedPlant pottedPlant) { }

	public PreviewController CreatePreviewController(SeedType seedType, ReloadedObject cursorPreview) { }

	private PreviewController CreatePreviewController(ZombieType zombieType) { }

	public PreviewController CreatePreviewController(SeedType seedType) { }

	private PreviewController CreatePreviewController(ZombieType zombieType, ReloadedObject cursorPreview) { }

	public ProjectileController CreateProjectileController(ProjectileType projectileType, Projectile projectile, float2 scale) { }

	public ProjectileController CreateProjectileController(ProjectileType projectileType, Projectile projectile) { }

	public RainController CreateRainController() { }

	public ReanimationController CreateReanimationController(ReanimationType type, ReloadedObject obj) { }

	public TutorialArrowController CreateTutorialArrowController() { }

	public ZombieController CreateZombieController(ZombieType type, Zombie zombie, bool enableEasterEgg = false, bool forceDecember = false, bool forceNormal = false) { }

	public void DoBackToMain() { }

	public void DoCheatDialog() { }

	public Dialog DoDialog(Dialogs theDialogId, bool isModal, string theDialogHeader, string theDialogLines, string theDialogFooter, ButtonType theButtonMode) { }

	public void DoNewOptions(bool theFromGameSelector) { }

	public void DoPauseDialog() { }

	public void DrawCrazyDave() { }

	public void EndLevel() { }

	public void EraseFile(string aFileName) { }

	[AsyncStateMachine(typeof(<ExitIntroCutScene>d__376))]
	public void ExitIntroCutScene() { }

	public void FadeOutCutScene() { }

	public void FlySeedPacketToTarget(SeedPacket packet, ModelKey targetKey) { }

	public void FlySeedPacketToTarget(ChosenSeed chosenSeed, ModelKey targetKey, ModelKey initialKey) { }

	public void GamePause(bool paused) { }

	public uint get_AppRandSeed() { }

	public BackgroundController get_BackgroundController() { }

	public Board get_Board() { }

	[CompilerGenerated]
	public BoardResult get_BoardResult() { }

	public bool get_ChinaMode() { }

	public CloudyDayMode get_CloudyDayMode() { }

	[CompilerGenerated]
	public float get_CooldownScale() { }

	[CompilerGenerated]
	public float get_CostScale() { }

	public int get_CrazyDaveMessageIndex() { }

	public CrazyDaveState get_CrazyDaveState() { }

	public bool get_CtrlDown() { }

	public bool get_DaisyMode() { }

	public bool get_DanceMode() { }

	public bool get_DebugKeysEnabled() { }

	public List<Dialog> get_DialogList() { }

	public bool get_DisableDebugKeys() { }

	[CompilerGenerated]
	public bool get_EasyPlantingCheat() { }

	public EffectSystem get_EffectSystem() { }

	public FadePanel get_FadePanel() { }

	public bool get_FutureMode() { }

	public GameMode get_GameMode() { }

	public IGameplayService get_GameplayService() { }

	[CompilerGenerated]
	public GameScenes get_GameScene() { }

	public IInputService get_InputService() { }

	public bool get_IsWindowed() { }

	[CompilerGenerated]
	public bool get_KilledYetiAndRestarted() { }

	public LevelStats get_LastLevelStats() { }

	public GameObject get_LevelBackground() { }

	public LevelEntryData get_LevelData() { }

	public IAudioService get_Music() { }

	public bool get_MustacheMode() { }

	[CompilerGenerated]
	public bool get_MuteSoundsForCutscene() { }

	public bool get_PinataMode() { }

	public VersusWinData get_Player1VersusWinData() { }

	public VersusWinData get_Player2VersusWinData() { }

	public PoolEffect get_PoolEffect() { }

	public ReloadedGameMode get_ReloadedGameMode() { }

	public RootModel get_RootModel() { }

	public IRunHistoryService get_RunHistoryService() { }

	public SeedChooserScreen get_SeedChooserScreen() { }

	public ISerializationService get_SerializationService() { }

	public ISettingsService get_SettingsService() { }

	public IAudioService get_SoundSystem() { }

	public int get_StoreIntroDialogIndex() { }

	public bool get_SukhbirMode() { }

	public bool get_SuperMowerMode() { }

	public bool get_TodCheatKeys() { }

	public IUserService get_UserService() { }

	public VersusMode get_VersusMode() { }

	public WidgetManager get_WidgetManager() { }

	public int get_Width() { }

	public ZenGarden get_ZenGarden() { }

	public ZombieType[] get_ZombieTypes() { }

	public static SeedType GetAwardSeedForLevel(int theLevel) { }

	public BoardViewController GetBoardViewController() { }

	public static int GetChallengeIndex(GameMode challenge) { }

	public int GetCloudyDayIndex() { }

	public Vector2 GetCoinDestination() { }

	public int GetCoopChallengeIndex() { }

	public ChallengeDefinition GetCurrentChallengeDef() { }

	public int GetCurrentChallengeIndex() { }

	public int GetCurrentMiniGameCompletionIndex() { }

	public static int GetCurrentMiniGameCompletionIndex(GameMode gameMode) { }

	public static int GetCurrentSurvivalCompletionIndex(GameMode gameMode) { }

	public Dialog GetDialog(Dialogs theDialogId) { }

	public DialogController GetDialogController() { }

	public int GetDialogCount() { }

	public GamepadCursorDefinition GetGamepadCursorDefinition(int playerIndex) { }

	public Vector3 GetInversePreviewControllerScale(SeedType seedType, ReloadedObject cursorPreview, PottedPlant pottedPlant) { }

	public int GetLevel() { }

	public LevelEntryData GetLevelEntryData(int levelNumber) { }

	public MessageWidgetController GetMessageWidgetController() { }

	public float2 GetMousePosition() { }

	public uint GetNextGlobalRand() { }

	public int GetNextGlobalRand(int range) { }

	private int GetNumTrophies(ChallengePage thePage) { }

	public PlantDefinition GetPlantDefinition(SeedType seedType) { }

	public float2 GetPreviewControllerScale(SeedType seedType, ReloadedObject cursorPreview, PottedPlant pottedPlant) { }

	public ProjectileDefinition GetProjectileDefinition(ProjectileType projectileType) { }

	public Reanimation GetReanimation() { }

	public ReanimationDefinition GetReanimationDefinition(ReanimationType animationType) { }

	public float2 GetScreenPosition(float2 referencePosition) { }

	public int GetSeedsAvailable() { }

	public Vector2 GetShovelBankPosition() { }

	public SpecialGridPlacement[] GetSpecialGridPlacements(BackgroundType backgroundType, out int count) { }

	public Vector2 GetSunDestination(int playerIndex) { }

	public int GetSunSpawnYOffset() { }

	public Vector3 GetTutorialArrowPosition() { }

	public Vector3 GetWorldPosition(float2 screenPosition) { }

	public ZenGardenCursorPreviewData GetZenGardenCursorPreviewData(SeedType seedType) { }

	public ZombieDefinition GetZombieDefinition(ZombieType zombieType) { }

	public bool HasBeatenChallenge(GameMode theGameMode) { }

	public bool HasCollectedAllZenGardenSeedTypes() { }

	public bool HasCompletedAdventureLevel() { }

	public bool HasCompletedAdventureLevelThisRun() { }

	public bool HasFinishedAdventure() { }

	public bool HasNotCompletedFirstTimeAdventureLevel() { }

	public bool HasSeedType(SeedType seedType) { }

	public void HideSeedChooserScreen() { }

	protected virtual void InactiveStarted() { }

	private void InitInput() { }

	private GameObject InstantiateOffscreen(GameObject prefab, Transform parent) { }

	public bool Is3DAccelerated() { }

	public bool IsAdventureMode() { }

	public bool IsAdventureModeCoopEnabled() { }

	public bool IsArtChallenge() { }

	public bool IsBungeeBlitzLevel() { }

	public bool IsChallengeMode() { }

	public bool IsChallengeWithoutSeedBank() { }

	public bool IsCloudyDayMode() { }

	public bool IsContinuousChallenge() { }

	public bool IsCoopMode() { }

	public bool IsEndlessIZombie(GameMode theGameMode) { }

	public bool IsEndlessScaryPotter(GameMode theGameMode) { }

	public bool IsFinalBossLevel() { }

	public bool IsFirstTimeAdventureMode() { }

	public bool IsIceDemo() { }

	public bool IsIZombieLevel() { }

	public bool IsIZombieMode(GameMode theGameMode) { }

	public bool IsLittleTroubleLevel() { }

	public bool IsMiniBossLevel() { }

	public bool IsPuzzleMode() { }

	public bool IsRipAdventureMode() { }

	public bool IsScaryPotterLevel() { }

	public bool IsShovelLevel() { }

	public bool IsSlotMachineLevel() { }

	public bool IsSquirrelLevel() { }

	public bool IsStormyNightLevel() { }

	public bool IsSurvivalEndless(GameMode theGameMode) { }

	public bool IsSurvivalHard(GameMode theGameMode) { }

	public bool IsSurvivalMode() { }

	public bool IsSurvivalNormal(GameMode theGameMode) { }

	public bool IsTrialStageLocked() { }

	public bool IsVersusMode() { }

	public bool IsWallnutBowlingLevel() { }

	public bool IsWhackAZombieLevel() { }

	public bool IsZombiquariumLevel() { }

	public void KillBoard() { }

	public void KillCreditScreen() { }

	private bool KillNewOptionsDialog() { }

	public void KillReloadedMode() { }

	public void KillSeedChooserScreen() { }

	public bool LevelHasZombieType(LevelEntryData levelEntryData, ZombieType zombieType) { }

	protected virtual void LoadingStarted() { }

	private GameObject LoadReferencedPrefab(AssetReferenceGameObject reference) { }

	public void MakeNewBoard() { }

	public void NewGame() { }

	private void OnApplicationQuit() { }

	private void OnMouseDownBG(int mouseButton, int playerIndex) { }

	private void OnMouseMove(CallbackContext context) { }

	private void OnMouseUpBG(int mouseButton, int playerIndex) { }

	private void OnUserModeChanged() { }

	private void OnZombieSpawnedInRow(int rowIndex) { }

	public ParticleSystemID ParticleGetID(TodParticleSystem theParticle) { }

	public TodParticleSystem ParticleTryToGet(ParticleSystemID particleID) { }

	public void PauseRumbleAll(bool paused) { }

	public void PlaySample(Sound soundId) { }

	public string Pluralize(int theCount, string theSingular, string thePlural) { }

	public void PreNewGame(GameMode theGameMode, bool theLookForSavedGame = false) { }

	public override void Provide(InjectorContainer container) { }

	public ReanimationID ReanimationGetID(Reanimation reanim) { }

	public Reanimation ReanimationTryToGet(ReanimationID reanimationID) { }

	public void RemoveParticle(ParticleSystemID particleSystemID) { }

	public void RemoveReanimation(Reanimation reanimation) { }

	public void RemoveReanimation(ReanimationID reanimationID) { }

	public void RumbleAll(RumbleType rumbleType) { }

	public void RumblePlayer(RumbleType rumbleType, int playerIndex) { }

	public bool SaveFileExists() { }

	public void SaveGame() { }

	[CompilerGenerated]
	public void set_BoardResult(BoardResult value) { }

	[CompilerGenerated]
	public void set_CooldownScale(float value) { }

	[CompilerGenerated]
	public void set_CostScale(float value) { }

	public void set_CrazyDaveMessageIndex(int value) { }

	[CompilerGenerated]
	public void set_EasyPlantingCheat(bool value) { }

	[CompilerGenerated]
	public void set_GameScene(GameScenes value) { }

	[CompilerGenerated]
	public void set_KilledYetiAndRestarted(bool value) { }

	[CompilerGenerated]
	public void set_MuteSoundsForCutscene(bool value) { }

	public void set_Player1VersusWinData(VersusWinData value) { }

	public void set_Player2VersusWinData(VersusWinData value) { }

	public void set_StoreIntroDialogIndex(int value) { }

	public bool SetAchievement(AchievementType achievementType, bool show) { }

	public void SetCursor(Cursor cursor) { }

	private void ShowAwardScreen() { }

	public void ShowBackScreen() { }

	private void ShowChallengeScreen(ChallengePage thePage) { }

	private void ShowGameSelector() { }

	public void ShowReadySetPlantScreen() { }

	public void ShowSeedChooserScreen() { }

	public StoreScreen ShowStoreScreen() { }

	public void ShowZombiesWonScreen() { }

	public void ShutdownInput() { }

	public void StartPlaying() { }

	public void StopAllRumble() { }

	public void SwitchScreenMode(bool wantWindowed, bool is3d, bool force) { }

	public void ToggleFastMo() { }

	public void ToggleSlowMo() { }

	public int TrophiesNeedForGoldSunflower() { }

	protected virtual void UnloadingStarted() { }

	public void UpdateCrazyDave() { }

	public void UpdateGame() { }

	private void UpdateParticleEffects() { }

	private bool UpdatePlayerProfileForFinishingLevel() { }

	private void UpdatePlayTimeStats() { }

	public bool WriteCurrentUserConfig() { }

}

