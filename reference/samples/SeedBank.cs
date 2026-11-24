namespace Reloaded.Gameplay;

public class SeedBank : ReloadedObject
{
	public int mNumPackets; //Field offset: 0x70
	public SeedPacket[] mSeedPackets; //Field offset: 0x78
	public int mCutSceneDarken; //Field offset: 0x80
	public int mConveyorBeltCounter; //Field offset: 0x84
	public bool mIsChoosing; //Field offset: 0x88
	public bool mIsVisible; //Field offset: 0x89
	public bool mIsDirty; //Field offset: 0x8A
	[CompilerGenerated]
	private readonly int <PlayerIndex>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	private Action<Int32> SeedRemoved; //Field offset: 0x90

	public event Action<Int32> SeedRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	public int NumPackets
	{
		 get { } //Length: 4
		 set { } //Length: 229
	}

	public int PlayerIndex
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	public SeedPacket[] SeedPackets
	{
		 get { } //Length: 5
	}

	public SeedBank(int playerIndex) { }

	[CompilerGenerated]
	public void add_SeedRemoved(Action<Int32> value) { }

	public void AddSeed(SeedType theSeedType, bool thePlaceOnLeft) { }

	public bool ContainsPoint(int theX, int theY) { }

	public int CountOfTypeOnConveyorBelt(SeedType aSeedType) { }

	public virtual void Deserialize(ref ReloadedBinaryReader reader, int version) { }

	public void Draw() { }

	public int get_NumPackets() { }

	[CompilerGenerated]
	public int get_PlayerIndex() { }

	public SeedPacket[] get_SeedPackets() { }

	public int GetNumSeedsOnConveyorBelt() { }

	public int GetNumVisibleSeedsOnConveyorBelt() { }

	public int GetPacketCount() { }

	public bool IsSeedPacketVisibleOnConveyor(SeedPacket packet) { }

	private bool IsSeedPacketVisibleOnConveyor(SeedPacket packet, int index) { }

	public bool MouseHitTest(int x, int y, HitResult theHitResult) { }

	public void Move(int x, int y) { }

	public void RefreshAllPackets() { }

	[CompilerGenerated]
	public void remove_SeedRemoved(Action<Int32> value) { }

	public void RemoveSeed(int theIndex) { }

	public virtual void Serialize(ref ReloadedBinaryWriter writer, int version) { }

	public void set_NumPackets(int value) { }

	public void UpdateConveyorBelt() { }

	public void UpdateWidth() { }

}

