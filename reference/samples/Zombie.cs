namespace Reloaded.Gameplay;

public class Zombie : ReloadedObject
{
	private const int k_zombieOffsetMultiplier = 10; //Field offset: 0x0
	private static int s_zombieOffset; //Field offset: 0x0
	public ZombieType mZombieType; //Field offset: 0x70
	public ZombiePhase mZombiePhase; //Field offset: 0x74
	public float mPosX; //Field offset: 0x78
	public float mPosY; //Field offset: 0x7C
	public int mGraveX; //Field offset: 0x80
	public int mGraveY; //Field offset: 0x84
	public float mVelX; //Field offset: 0x88
	public int mAnimCounter; //Field offset: 0x8C
	public int mGroanCounter; //Field offset: 0x90
	public int mAnimTicksPerFrame; //Field offset: 0x94
	public int mAnimFrames; //Field offset: 0x98
	public int mFrame; //Field offset: 0x9C
	public int mPrevFrame; //Field offset: 0xA0
	public bool mVariant; //Field offset: 0xA4
	public bool mIsEating; //Field offset: 0xA5
	public int mJustGotShotCounter; //Field offset: 0xA8
	public int mShieldJustGotShotCounter; //Field offset: 0xAC
	public int mShieldRecoilCounter; //Field offset: 0xB0
	public int mZombieAge; //Field offset: 0xB4
	public ZombieHeight mZombieHeight; //Field offset: 0xB8
	public int mPhaseCounter; //Field offset: 0xBC
	public int mBrainRate; //Field offset: 0xC0
	public int mFromWave; //Field offset: 0xC4
	public bool mDroppedLoot; //Field offset: 0xC8
	public int mZombieFade; //Field offset: 0xCC
	public bool mFlatTires; //Field offset: 0xD0
	public int mUseLadderCol; //Field offset: 0xD4
	public int mTargetCol; //Field offset: 0xD8
	public float mAltitude; //Field offset: 0xDC
	public bool mHitUmbrella; //Field offset: 0xE0
	public Rect mZombieRect; //Field offset: 0xE4
	public Rect mZombieAttackRect; //Field offset: 0xF4
	public int mChilledCounter; //Field offset: 0x104
	public int mButteredCounter; //Field offset: 0x108
	public int mIceTrapCounter; //Field offset: 0x10C
	public bool mMindControlled; //Field offset: 0x110
	public bool mBlowingAway; //Field offset: 0x111
	public bool mHasHead; //Field offset: 0x112
	public bool mHasArm; //Field offset: 0x113
	public bool mHasObject; //Field offset: 0x114
	public bool mInPool; //Field offset: 0x115
	public bool mOnHighGround; //Field offset: 0x116
	public bool mYuckyFace; //Field offset: 0x117
	public int mYuckyFaceCounter; //Field offset: 0x118
	public HelmType mHelmType; //Field offset: 0x11C
	public int mBodyHealth; //Field offset: 0x120
	public int mBodyMaxHealth; //Field offset: 0x124
	public int mHelmHealth; //Field offset: 0x128
	public int mHelmMaxHealth; //Field offset: 0x12C
	public ShieldType mShieldType; //Field offset: 0x130
	public int mShieldHealth; //Field offset: 0x134
	public int mShieldMaxHealth; //Field offset: 0x138
	public int mFlyingHealth; //Field offset: 0x13C
	public int mFlyingMaxHealth; //Field offset: 0x140
	public bool mDead; //Field offset: 0x144
	public ZombieID mRelatedZombieID; //Field offset: 0x148
	public ZombieID[] mFollowerZombieID; //Field offset: 0x150
	public bool mPlayingSong; //Field offset: 0x158
	public int mParticleOffsetX; //Field offset: 0x15C
	public int mParticleOffsetY; //Field offset: 0x160
	public AttachmentID mAttachmentID; //Field offset: 0x164
	public int mSummonCounter; //Field offset: 0x168
	public ReanimationID mBodyReanimID; //Field offset: 0x16C
	public float mScaleZombie; //Field offset: 0x170
	public float mVelZ; //Field offset: 0x174
	public float mOrginalAnimRate; //Field offset: 0x178
	public PlantID mTargetPlantID; //Field offset: 0x17C
	public int mBossMode; //Field offset: 0x180
	public int mTargetRow; //Field offset: 0x184
	public int mBossBungeeCounter; //Field offset: 0x188
	public int mBossStompCounter; //Field offset: 0x18C
	public int mBossHeadCounter; //Field offset: 0x190
	public Reanimation mBossFireball; //Field offset: 0x198
	public Reanimation mButterReanim; //Field offset: 0x1A0
	public ReanimationID mSpecialHeadReanimID; //Field offset: 0x1A8
	public ReanimationID mZombatarHeadReanimID; //Field offset: 0x1AC
	public int mFireballRow; //Field offset: 0x1B0
	public bool mIsFireBall; //Field offset: 0x1B4
	public ReanimationID mMoweredReanimID; //Field offset: 0x1B8
	public int mLastPortalX; //Field offset: 0x1BC
	public bool mIsRetro; //Field offset: 0x1C0
	public IceTrapController mIceTrapController; //Field offset: 0x1C8
	public ZombieController mController; //Field offset: 0x1D0
	public bool mIsBobsledLeader; //Field offset: 0x1D8
	public bool mIsPushingBobsled; //Field offset: 0x1D9
	public int mBobsledAlpha; //Field offset: 0x1DC
	public int mBobsledImageIndex; //Field offset: 0x1E0
	public int4 mBobsledColor; //Field offset: 0x1E4
	public float2 mBobsledInsideOffset; //Field offset: 0x1F4
	public float2 mBobsledOutsideOffset; //Field offset: 0x1FC
	public float4 mBobsledAdditiveColor; //Field offset: 0x204
	public int mBungeeTargetRenderOrder; //Field offset: 0x214
	public MustacheType mMustacheType; //Field offset: 0x218
	public SunglassesType mSunglassesType; //Field offset: 0x21C
	private IGameplayService m_gameplayService; //Field offset: 0x220

	public Zombie() { }

	[CompilerGenerated]
	private void <WalkIntoHouse>b__250_0(float y) { }

	[CompilerGenerated]
	private void <ZombieInitialize>b__96_0(ReloadedCharacterController controller) { }

	public TodParticleSystem AddAttachedParticle(int thePosX, int thePosY, ParticleEffect theEffect) { }

	public ReloadedController AddAttachedReanim(int thePosX, int thePosY, ReanimationType theReanimType) { }

	public void Animate() { }

	public void AnimateChewEffect() { }

	public void AnimateChewSound() { }

	public void ApplyAnimRate(float theAnimRate) { }

	public void ApplyBossSmokeParticles(bool theEnable) { }

	public void ApplyBurn() { }

	public void ApplyButter() { }

	public void ApplyChill(bool theIsIceTrap) { }

	public void AttachShield() { }

	public void BalloonPropellerHatSpin(bool theSpinning) { }

	public void BobsledBurn() { }

	public void BobsledCrash() { }

	public void BobsledDie() { }

	public bool BossAreBungeesDone() { }

	public void BossBungeeAttack() { }

	public void BossBungeeLeave() { }

	public void BossBungeeSpawn() { }

	public bool BossCanStompRow(int theRow) { }

	public void BossDestroyFireball() { }

	public void BossDestroyIceballInRow(int theRow) { }

	public void BossDie() { }

	public void BossHeadAttack() { }

	public void BossHeadSpit() { }

	public void BossHeadSpitContact() { }

	public void BossHeadSpitEffect() { }

	public void BossPlayIdle() { }

	public void BossRVAttack() { }

	public void BossRVLanding() { }

	public void BossSetupReanim() { }

	public void BossSetupReanimAlmanac(Reanimation aDriverReanim) { }

	public void BossSpawnAttack() { }

	public void BossSpawnContact() { }

	public void BossStartDeath() { }

	public void BossStompAttack() { }

	public void BossStompContact() { }

	public void BungeeDie() { }

	public void BungeeDropPlant() { }

	public void BungeeDropZombie(Zombie theDroppedZombie, int theGridX, int theGridY) { }

	public void BungeeLanding() { }

	public void BungeeLiftTarget() { }

	public void BungeeStealTarget() { }

	public bool CanBeChilled() { }

	public bool CanBeFrozen() { }

	public bool CanLoseBodyParts() { }

	public bool CanTargetPlant(Plant thePlant, ZombieAttackType theAttackType) { }

	public void CatapultDeath(DamageFlags theDamageFlags) { }

	public void CheckForBoardEdge() { }

	public void CheckForHighGround() { }

	public void CheckForPool() { }

	public void CheckForZombieStep() { }

	public void CheckIfPreyCaught() { }

	public void CheckSquish(ZombieAttackType theAttackType) { }

	public void ConvertToNormalZombie() { }

	public int CountBungeesTargetingSunFlowers() { }

	public void CountExpectedMowers() { }

	public virtual void Deserialize(ref ReloadedBinaryReader reader, int version) { }

	public void DetachShield() { }

	public void DieDeserialize() { }

	public void DieNoLoot() { }

	public void DieWithLoot() { }

	public void DiggerLoseAxe() { }

	public void DoDaisies() { }

	public void DragUnder() { }

	public void Draw() { }

	public void DrawBobsledReanim(ZombieDrawPosition theDrawPos, bool theBeforeZombie) { }

	public void DrawBossBackArm(ZombieDrawPosition theDrawPos) { }

	public void DrawBossBackArm() { }

	public void DrawBossFireBall(ZombieDrawPosition theDrawPos) { }

	public void DrawBungeeReanim(ZombieDrawPosition theDrawPos) { }

	public void DrawIceTrap(ZombieDrawPosition theDrawPos, bool theFront) { }

	public void DrawReanim(ZombieDrawPosition theDrawPos, int theBaseRenderGroup) { }

	public void DrawShadow() { }

	public void DrawZombie(ZombieDrawPosition theDrawPos) { }

	public void DrawZombieHead(ZombieDrawPosition theDrawPos, int theFrame) { }

	public void DrawZombiePart(int theFrame, int theRow, ZombieDrawPosition theDrawPos) { }

	public void DrawZombieWithParts(ZombieDrawPosition theDrawPos) { }

	public void DropArm(DamageFlags theDamageFlags) { }

	public void DropFlag() { }

	public void DropHead(DamageFlags theDamageFlags) { }

	public void DropHelm(DamageFlags theDamageFlags) { }

	public void DropLoot() { }

	public void DropPole() { }

	public void DropShield(DamageFlags theDamageFlags) { }

	public void EatPlant(Plant thePlant) { }

	public void EatZombie(Zombie theZombie) { }

	public bool EffectedByDamage(DamageRangeFlags theDamageRangeFlags) { }

	public void EnableDanceMode(bool theEnableDance) { }

	public void EnableFuture(bool theEnableFuture) { }

	public void EnableMustache(bool theEnableMustache) { }

	protected virtual void Finalize() { }

	public Plant FindCatapultTarget() { }

	public Plant FindPlantTarget(ZombieAttackType theAttackType) { }

	public Zombie FindZombieTarget() { }

	public int GetBobsledPosition() { }

	public int GetBodyDamageIndex() { }

	public int GetDancerFrame() { }

	public ZombiePhase GetDancerPhase() { }

	public ZombieDrawPosition GetDrawPos() { }

	public int GetHelmDamageIndex() { }

	public float GetPosYBasedOnRow(int theRow) { }

	public int GetShieldDamageIndex() { }

	private int GetTargetShieldDamageIndex() { }

	public float2 GetTrackPosition(string aTrackName) { }

	public Rect GetZombieAttackRect() { }

	public Rect GetZombieRect() { }

	public bool HasShadow() { }

	public bool HasYuckyFaceImage() { }

	public void HitIceTrap() { }

	public bool IsBobsledTeamWithSled() { }

	public bool IsBouncingPogo() { }

	public bool IsDeadOrDying() { }

	public bool IsFireResistant() { }

	public bool IsFlying() { }

	public bool IsImmobilizied() { }

	public bool IsMovingAtChilledSpeed() { }

	public bool IsOnBoard() { }

	public bool IsOnHighGround() { }

	public Plant IsStandingOnSpikeweed() { }

	public bool IsTangleKelpTarget() { }

	public bool IsTanglekelpTarget_Lower() { }

	public bool IsWalkingBackwards() { }

	public void LandFlyer(DamageFlags theDamageFlags) { }

	public void LoadPlainZombieReanim() { }

	public void LoadReanim(ReanimationType theReanimationType) { }

	public void MowDown() { }

	public bool NeedsMoreBackupDancers() { }

	public void OverrideParticleColor(TodParticleSystem aParticle) { }

	public void OverrideParticleScale(TodParticleSystem aParticle) { }

	public void PickBungeeZombieTarget(int theColumn) { }

	public void PickRandomSpeed() { }

	public void PlayDeathAnim(DamageFlags theDamageFlags) { }

	public void PlayZombieAppearSound() { }

	public void PlayZombieReanim(string theTrackName, ReanimLoopType theLoopType, int theBlendTime, float theAnimRate) { }

	public void PogoBreak(DamageFlags theDamageFlags) { }

	public void PoolSplash(bool theInToPoolSound) { }

	public void PostUpdate() { }

	public static void PreloadZombieResources(ZombieType theZombieType) { }

	public void ReanimIgnoreClipRect(string theTrackName, bool theIgnoreClipRect) { }

	public void ReanimReenableClipping() { }

	public void ReanimShowPrefix(string theTrackPrefix, int theRenderGroup) { }

	public void ReanimShowTrack(string theTrackName, int theRenderGroup) { }

	public void RemoveButter() { }

	public void RemoveColdEffects() { }

	public void RemoveIceTrap() { }

	public virtual void Reset() { }

	public static void ResetZombieOffset() { }

	public void RiseFromGrave(int theCol, int theRow) { }

	public virtual void Serialize(ref ReloadedBinaryWriter writer, int version) { }

	public void SetAnimRate(float theAnimRate) { }

	public void SetRow(int theRow) { }

	public void SetupDoorArms(bool theShow) { }

	public bool SetupDrawZombieWon() { }

	public void SetupReanimLayers(ZombieType theZombieType) { }

	public void SetupWaterTrack(string theTrackName) { }

	public void ShowDoorArms(bool theShow) { }

	public void ShowYuckyFace(bool theShow) { }

	public void SquishAllInSquare(int theX, int theY, ZombieAttackType theAttackType) { }

	public void StartEating() { }

	public void StartMindControlled() { }

	public void StartWalkAnim(int theBlendTime) { }

	public void StartZombieSound() { }

	public void StopEating() { }

	public void StopZombieSound() { }

	public ZombieID SummonBackupDancer(int theRow, int thePosX) { }

	public void SummonBackupDancers() { }

	public void TakeBodyDamage(int theDamage, DamageFlags theDamageFlags) { }

	public void TakeDamage(int theDamage, DamageFlags theDamageFlags) { }

	public int TakeFlyingDamage(int theDamage, DamageFlags theDamageFlags) { }

	public int TakeHelmDamage(int theDamage, DamageFlags theDamageFlags) { }

	public int TakeShieldDamage(int theDamage, DamageFlags theDamageFlags) { }

	public bool TrySpawnLevelAward() { }

	public void Update() { }

	public void UpdateActions() { }

	public void UpdateAnimSpeed() { }

	public void UpdateBoss() { }

	public void UpdateBossFireball() { }

	public void UpdateBurn() { }

	public void UpdateClimbingLadder() { }

	public void UpdateDamageStates(DamageFlags theDamageFlags) { }

	public void UpdateDancerWalking() { }

	public void UpdateDeath() { }

	public void UpdateGravestone() { }

	public void UpdateLadder() { }

	public void UpdateMowered() { }

	public void UpdatePlaying() { }

	public void UpdateReanim() { }

	public void UpdateYeti() { }

	public void UpdateYuckyFace() { }

	public void UpdateZamboni() { }

	public void UpdateZombieBackupDancer() { }

	public void UpdateZombieBobsled() { }

	public void UpdateZombieBungee() { }

	public void UpdateZombieCatapult() { }

	public void UpdateZombieChimney() { }

	public void UpdateZombieDancer() { }

	public void UpdateZombieDigger() { }

	public void UpdateZombieDolphinRider() { }

	public void UpdateZombieFalling() { }

	public void UpdateZombieFlyer() { }

	public void UpdateZombieGargantuar() { }

	public void UpdateZombieGatlingHead() { }

	public void UpdateZombieHighGround() { }

	public void UpdateZombieImp() { }

	public void UpdateZombieJackInTheBox() { }

	public void UpdateZombieJalapenoHead() { }

	public void UpdateZombieNewspaper() { }

	public void UpdateZombiePeaHead() { }

	public void UpdateZombiePogo() { }

	public void UpdateZombiePolevaulter() { }

	public void UpdateZombiePool() { }

	public void UpdateZombiePosition() { }

	public void UpdateZombieRiseFromGrave() { }

	public void UpdateZombieSnorkel() { }

	public void UpdateZombieSquashHead() { }

	public void UpdateZombieWalking() { }

	public void UpdateZombiquarium() { }

	public void WalkIntoHouse() { }

	public void ZamboniDeath(DamageFlags theDamageFlags) { }

	public void ZombieCatapultFire(Plant thePlant) { }

	public void ZombieInitialize(int theRow, ZombieType theType, bool theVariant, Zombie theParentZombie, int theFromWave, ZombieController controller = null) { }

	public bool ZombieNotWalking() { }

	public float ZombieTargetLeadX(float theTime) { }

	private bool ZombieTypeCanGoInPool(ZombieType theZombieType) { }

	public bool ZombiquariumFindClosestBrain() { }

}

