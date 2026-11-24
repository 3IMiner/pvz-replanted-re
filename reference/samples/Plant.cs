namespace Reloaded.Gameplay;

public class Plant : ReloadedObject
{
	public SeedType mSeedType; //Field offset: 0x70
	public int mPlantCol; //Field offset: 0x74
	public int mAnimCounter; //Field offset: 0x78
	public int mFrame; //Field offset: 0x7C
	public int mFrameLength; //Field offset: 0x80
	public int mNumFrames; //Field offset: 0x84
	public PlantState mState; //Field offset: 0x88
	public int mPlantHealth; //Field offset: 0x8C
	public int mPlantMaxHealth; //Field offset: 0x90
	public PlantSubClass mSubclass; //Field offset: 0x94
	public int mDisappearCountdown; //Field offset: 0x98
	public int mDoSpecialCountdown; //Field offset: 0x9C
	public int mStateCountdown; //Field offset: 0xA0
	public int mLaunchCounter; //Field offset: 0xA4
	public int mLaunchRate; //Field offset: 0xA8
	public Rect mPlantRect; //Field offset: 0xAC
	public Rect mPlantAttackRect; //Field offset: 0xBC
	public int mTargetX; //Field offset: 0xCC
	public int mTargetY; //Field offset: 0xD0
	public int mStartRow; //Field offset: 0xD4
	public ParticleSystemID mParticleID; //Field offset: 0xD8
	public int mShootingCounter; //Field offset: 0xDC
	public ReanimationID mBodyReanimID; //Field offset: 0xE0
	public ReanimationID mHeadReanimID; //Field offset: 0xE4
	public ReanimationID mHeadReanimID2; //Field offset: 0xE8
	public ReanimationID mHeadReanimID3; //Field offset: 0xEC
	public ReanimationID mBlinkReanimID; //Field offset: 0xF0
	public ReanimationID mLightReanimID; //Field offset: 0xF4
	public ReanimationID mSleepingReanimID; //Field offset: 0xF8
	public int mBlinkCountdown; //Field offset: 0xFC
	public int mRecentlyEatenCountdown; //Field offset: 0x100
	public int mEatenFlashCountdown; //Field offset: 0x104
	public int mBeghouledFlashCountdown; //Field offset: 0x108
	public float mShakeOffsetX; //Field offset: 0x10C
	public float mShakeOffsetY; //Field offset: 0x110
	public MagnetItem[] mMagnetItems; //Field offset: 0x118
	public ZombieID mTargetZombieID; //Field offset: 0x120
	public int mWakeUpCounter; //Field offset: 0x124
	public PlantOnBungeeState mOnBungeeState; //Field offset: 0x128
	public SeedType mImitaterType; //Field offset: 0x12C
	public int mPottedPlantIndex; //Field offset: 0x130
	public bool mAnimPing; //Field offset: 0x134
	public bool mDead; //Field offset: 0x135
	public bool mIsAsleep; //Field offset: 0x136
	public bool mIsOnBoard; //Field offset: 0x137
	public bool mHighlighted; //Field offset: 0x138
	public bool mIsImitation; //Field offset: 0x139
	private ReanimationID m_tangleKelpID; //Field offset: 0x13C
	public PlantController mController; //Field offset: 0x140
	public PottedPlantController PottedPlantController; //Field offset: 0x148
	private MagnetItemController[] m_magnetItemControllers; //Field offset: 0x150
	private IGameplayService m_gameplayService; //Field offset: 0x158

	public Plant() { }

	public TodParticleSystem AddAttachedParticle(int thePosX, int thePosY, int theRenderPostition, ParticleEffect theEffect) { }

	public TodParticleSystem AddAttachedParticle(float thePosX, float thePosY, int theRenderPostition, ParticleEffect theEffect) { }

	public void Animate() { }

	public void AnimateGarlic() { }

	public void AnimateNuts() { }

	public void AnimatePumpkin() { }

	public Reanimation AttachBlinkAnim(Reanimation theReanimBody) { }

	private void AttemptSetMarigoldColour(string colour) { }

	public void BlowAwayFliers(int theX, int theRow) { }

	public void BlowAwayFliers(float theX, int theRow) { }

	public void BurnRow(int theRow) { }

	public int CalcRenderOrder() { }

	public void CobCannonFire(int theTargetX, int theTargetY) { }

	public virtual void Deserialize(ref ReloadedBinaryReader reader, int version) { }

	public void Die() { }

	public int DistanceToClosestZombie() { }

	public void DoBlink() { }

	public void DoRowAreaDamage(int theDamage, DamageFlags theDamageFlags) { }

	public void DoSpecial() { }

	public void DoSquashDamage() { }

	public void Draw() { }

	public void DrawMagnetItems() { }

	public bool DrawMagnetItemsOnTop() { }

	public static void DrawSeedType(SeedType theSeedType, SeedType theImitaterType, DrawVariation theDrawVariation, float thePosX, float thePosY) { }

	public void DrawShadow(float theOffsetX, float theOffsetY) { }

	public void EndBlink() { }

	public Coin FindGoldMagnetTarget() { }

	public Zombie FindSquashTarget() { }

	public bool FindStarFruitTarget() { }

	public bool FindTargetAndFire(int theRow, PlantWeapon thePlantWeapon) { }

	public Zombie FindTargetZombie(int theRow, PlantWeapon thePlantWeapon) { }

	public void Fire(Zombie theTargetZombie, int theRow, PlantWeapon thePlantWeapon) { }

	public static int GetCost(GameplayActivity gLawnApp, SeedType theSeedType, SeedType theImitaterType) { }

	public DamageRangeFlags GetDamageRangeFlags(PlantWeapon thePlantWeapon) { }

	public MagnetItem GetFreeMagnetItem() { }

	public Sprite GetImage(SeedType theSeedtype) { }

	public static string GetNameString(GameplayActivity app, SeedType theSeedtype, SeedType theImitaterType) { }

	public float2 GetPeaHeadOffset() { }

	public Rect GetPlantAttackRect(PlantWeapon thePlantWeapon) { }

	public Rect GetPlantRect() { }

	public static int GetRefreshTime(GameplayActivity app, SeedType theSeedType, SeedType theImitaterType) { }

	public string GetToolTip(SeedType theSeedType) { }

	public void GoldMagnetFindTargets() { }

	private bool HasHeadAnimation() { }

	public void IceZombies() { }

	public void ImitaterMorph() { }

	public bool IsAGoldMagnetAboutToSuck() { }

	public static bool IsAquatic(SeedType theSeedType) { }

	public static bool IsFlying(SeedType theSeedtype) { }

	public bool IsInPlay() { }

	public static bool IsNocturnal(SeedType theSeedtype) { }

	public bool IsOnBoard() { }

	public bool IsOnHighGround() { }

	public bool IsPartOfUpgradableTo(SeedType aUpdatedType) { }

	public bool IsSpiky() { }

	public bool IsUpgradableTo(SeedType aUpdatedType) { }

	public static bool IsUpgrade(SeedType theSeedtype) { }

	public void KillAllPlantsNearDoom() { }

	public void LaunchStarFruit() { }

	public void LaunchThreepeater() { }

	public void MagnetShroomAttactItem(Zombie theZombie) { }

	public bool MakesSun() { }

	public void MouseDown(int x, int y, int theClickCount, int playerIndex) { }

	public bool NotOnGround() { }

	public static float PlantDrawHeightOffset(GameplayActivity app, Board theBoard, Plant thePlant, SeedType theSeedType, int theCol, int theRow) { }

	public static float PlantFlowerPotHeightOffset(SeedType theSeedType, float theFlowerPotScale) { }

	public void PlantInitialize(int theGridX, int theGridY, SeedType theSeedType, SeedType theImitaterType, PlantController controller = null, bool forceDecemberContent = false, bool forceNormalContent = false) { }

	public void PlayBodyReanim(string theTrackName, ReanimLoopType theLoopType, int theBlendTime, float theAnimRate) { }

	public void PlayIdleAnim(float theRate) { }

	public void PostUpdate() { }

	public static void PreloadPlantResources(SeedType theSeedType) { }

	public void RemoveEffects() { }

	public virtual void Reset() { }

	public virtual void Serialize(ref ReloadedBinaryWriter writer, int version) { }

	public void SetSleeping(bool theIsAsleep) { }

	public void SpikeRockTakeDamage() { }

	public void SpikeweedAttack() { }

	public void Squish() { }

	public void StarFruitFire() { }

	public void Update() { }

	public void UpdateAbilities() { }

	public void UpdateBlink() { }

	public void UpdateBlover() { }

	public void UpdateBowling() { }

	public void UpdateCactus() { }

	public void UpdateChomper() { }

	public void UpdateCobCannon() { }

	public void UpdateCoffeeBean() { }

	public void UpdateDoomShroom() { }

	public void UpdateFlowerPot() { }

	public void UpdateGoldMagnetShroom() { }

	public void UpdateGraveBuster() { }

	public void UpdateIceShroom() { }

	public void UpdateImitater() { }

	public void UpdateInternal() { }

	public void UpdateLilypad() { }

	public void UpdateMagnetShroom() { }

	public void UpdateNeedsFood() { }

	public void UpdatePotato() { }

	public void UpdateProductionPlant() { }

	public void UpdateReanim() { }

	public void UpdateReanimColor() { }

	public void UpdateScaredyShroom() { }

	public void UpdateShooter() { }

	public void UpdateShooting() { }

	public void UpdateSpikeweed() { }

	public void UpdateSquash() { }

	public void UpdateSunShroom() { }

	public void UpdateTanglekelp() { }

	public void UpdateTorchwood() { }

	public void UpdateUmbrella() { }

}

