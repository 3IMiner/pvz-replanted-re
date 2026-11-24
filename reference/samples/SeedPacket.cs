namespace Reloaded.Gameplay;

public class SeedPacket : ReloadedObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public SeedPacket <>4__this; //Field offset: 0x10
		public int playerIndex; //Field offset: 0x18

		public <>c__DisplayClass49_0() { }

		internal void <CanPickUp>b__0(ref SeedBank bank, int index) { }

	}

	public int mRefreshCounter; //Field offset: 0x70
	public int mRefreshTime; //Field offset: 0x74
	public int mIndex; //Field offset: 0x78
	public int mOffsetX; //Field offset: 0x7C
	public SeedType mPacketType; //Field offset: 0x80
	public SeedType mImitaterType; //Field offset: 0x84
	public int mSlotMachineCountDown; //Field offset: 0x88
	public SeedType mSlotMachiningNextSeed; //Field offset: 0x8C
	public float mSlotMachiningPosition; //Field offset: 0x90
	public Vector2 mTargetPosition; //Field offset: 0x94
	public bool mActive; //Field offset: 0x9C
	public bool mRefreshing; //Field offset: 0x9D
	public int mTimesUsed; //Field offset: 0xA0
	public bool mInTutorial; //Field offset: 0xA4
	public bool mFlashReady; //Field offset: 0xA5
	public bool mFlying; //Field offset: 0xA6
	public bool mBackgroundVisible; //Field offset: 0xA7
	private int m_lastUpdateCounter; //Field offset: 0xA8
	private float m_lastCooldownScale; //Field offset: 0xAC
	[CompilerGenerated]
	private bool <IsGamepadSelected>k__BackingField; //Field offset: 0xB0
	public MultiplayerType<Boolean> PlayerSelectedFlags; //Field offset: 0xB8

	public int Index
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public private bool IsGamepadSelected
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public SeedType PacketType
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public SeedPacket() { }

	public SeedPacket(GameplayActivity app) { }

	[CompilerGenerated]
	private void <Deselected>b__39_0(ref bool flag) { }

	public void Activate() { }

	public void Activated(int playerIndex, bool byGamepad) { }

	public bool CanPickUp() { }

	public void Deactivate() { }

	public void Deselected(int playerIndex) { }

	public virtual void Deserialize(ref ReloadedBinaryReader reader, int version) { }

	public void Draw() { }

	public void FlashIfReady() { }

	public int get_Index() { }

	[CompilerGenerated]
	public bool get_IsGamepadSelected() { }

	public SeedType get_PacketType() { }

	public int GetCost() { }

	private void InitSeedPacket() { }

	public bool IsPlantFromBankCursorTypeAllowed(int playerIndex) { }

	public void MouseDown(int x, int y, int theClickCount) { }

	public bool MouseHitTest(int theX, int theY, HitResult theHitResult) { }

	public void PickNextSlotMachineSeed() { }

	public void Selected(int playerIndex, bool byGamepad) { }

	public virtual void Serialize(ref ReloadedBinaryWriter writer, int version) { }

	public void set_Index(int value) { }

	[CompilerGenerated]
	private void set_IsGamepadSelected(bool value) { }

	public void set_PacketType(SeedType value) { }

	public void SetPacketType(SeedType theSeedType, SeedType theImitaterType) { }

	public void SetTutorialState() { }

	public void SlotMachineStart() { }

	public void Update() { }

	public void WasPlanted(int playerIndex) { }

}

