# Reloaded.Gameplay 枚举表（从 IL2CPP interop 程序集解析）

## SeedType
-1=None, 0=Peashooter, 1=Sunflower, 2=Cherrybomb, 3=Wallnut, 4=Potatomine,
5=Snowpea, 6=Chomper, 7=Repeater, 8=Puffshroom, 9=Sunshroom, 10=Fumeshroom,
11=Gravebuster, 12=Hypnoshroom, 13=Scaredyshroom, 14=Iceshroom, 15=Doomshroom,
16=Lilypad, 17=Squash, 18=Threepeater, 19=Tanglekelp, 20=Jalapeno, 21=Spikeweed,
22=Torchwood, 23=Tallnut, 24=Seashroom, 25=Plantern, 26=Cactus, 27=Blover,
28=Splitpea, 29=Starfruit, 30=Pumpkinshell, 31=Magnetshroom, 32=Cabbagepult,
33=Flowerpot, 34=Kernelpult, 35=InstantCoffee, 36=Garlic, 37=Umbrella, 38=Marigold,
39=Melonpult, 40=Gatlingpea, 41=Twinsunflower, 42=Gloomshroom, 43=Cattail,
44=Wintermelon, 45=GoldMagnet, 46=Spikerock, 47=Cobcannon, 48=Imitater,
49=NumSeedsInChooser, 50=GiantWallnut, 51=Sprout, 52=Leftpeater, 53=NumSeedTypes

## PlantState
0=Notready, 1=Ready, 2=DoingSpecial, 3=SquashLook, 4=SquashPreLaunch,
5=SquashRising, 6=SquashFalling, 7=SquashDoneFalling, 8=GravebusterLanding,
9=GravebusterEating, 10=ChomperBiting, 11=ChomperBitingGotOne, 12=ChomperBitingMissed,
13=ChomperDigesting, 14=ChomperSwallowing, 15=PotatoRising, 16=PotatoArmed,
17=PotatoMashed, 18=SpikeweedAttacking, 19=SpikeweedAttacking2, 20=ScaredyshroomLowering,
21=ScaredyshroomScared, 22=ScaredyshroomRaising, 23=SunshroomSmall, 24=SunshroomGrowing,
25=SunshroomBig, 26=MagnetshroomSucking, 27=MagnetshroomCharging, 28=BowlingUp,
29=BowlingDown, 30=CactusLow, 31=CactusRising, 32=CactusHigh, 33=CactusLowering,
34=TanglekelpGrabbing, 35=CobcannonArming, 36=CobcannonLoading, 37=CobcannonReady,
38=CobcannonFiring, 39=KernelpultButter, 40=UmbrellaTriggered, 41=UmbrellaReflecting,
42=ImitaterMorphing, 43=ZenGardenWatered, 44=ZenGardenNeedy, 45=ZenGardenHappy,
46=MarigoldEnding, 47=FlowerpotInvulnerable, 48=LilypadInvulnerable

## PlantWeapon
0=Primary, 1=Secondary

## PlantSubClass
0=Normal, 1=Shooter
# Reloaded.Gameplay 枚举表（从 IL2CPP interop 程序集解析，第二批：Zombie）

## ZombieType
-1=Invalid, 0=Normal, 1=Flag, 2=TrafficCone, 3=Polevaulter, 4=Pail, 5=Newspaper,
6=Door, 7=Football, 8=Dancer, 9=BackupDancer, 10=DuckyTube, 11=Snorkel, 12=Zamboni,
13=Bobsled, 14=DolphinRider, 15=JackInTheBox, 16=Balloon, 17=Digger, 18=Pogo,
19=Yeti, 20=Bungee, 21=Ladder, 22=Catapult, 23=Gargantuar, 24=Imp, 25=Boss,
26=PeaHead, 27=WallnutHead, 28=JalapenoHead, 29=GatlingHead, 30=SquashHead,
31=TallnutHead, 32=RedeyeGargantuar, 33=Zombatar, 34=Target, 35=TrashCan,
36=Gravestone, 37=NumZombieTypes, 38=ZombieCachedPolevaulterWithPole, 39=NumCachedZombieTypes

## ZombiePhase
0=ZombieNormal, 1=ZombieDying, 2=ZombieBurned, 3=ZombieMowered, 4=BungeeDiving,
5=BungeeDivingScreaming, 6=BungeeAtBottom, 7=BungeeGrabbing, 8=BungeeRising,
9=BungeeHitOuchy, 10=BungeeCutscene, 11=PolevaulterPreVault, 12=PolevaulterInVault,
13=PolevaulterPostVault, 14=RisingFromGrave, 15=JackInTheBoxRunning, 16=JackInTheBoxPopping,
17=BobsledSliding, 18=BobsledBoarding, 19=BobsledCrashing, 20=PogoBouncing,
21-28=PogoHighBounce1-6/PogoForwardBounce2/PogoForwardBounce7, 29=NewspaperReading,
30=NewspaperMaddening, 31=NewspaperMad, 32=DiggerTunneling, 33=DiggerRising,
34=DiggerTunnelingPauseWithoutAxe, 35=DiggerRiseWithoutAxe, 36=DiggerStunned,
37=DiggerWalking, 38=DiggerWalkingWithoutAxe, 39=DiggerCutscene, 40=DancerDancingIn,
41-50=DancerSnappingFingers*/Dancing/Raise*/Rising, 51-56=Dolphin*, 57-62=Snorkel*,
63-66=Zombiquarium*, 67-68=Catapult*, 69-70=Gargantuar*, 71-72=Imp*, 73-75=Balloon*,
76-77=Ladder*, 78-90=Boss*, 91=YetiRunning, 92-95=Squash*

## ZombieHeight
0=ZombieNormal, 1=InToPool, 2=OutOfPool, 3=DraggedUnder, 4=UpToHighGround,
5=DownOffHighGround, 6=UpLadder, 7=Falling, 8=InToChimney, 9=GettingBungeeDropped,
10=Zombiquarium

## HelmType
0=None, 1=TrafficCone, 2=Pail, 3=Football, 4=Digger, 5=Redeyes, 6=Headband,
7=Bobsled, 8=Wallnut, 9=Tallnut

## ShieldType
0=None, 1=Door, 2=Newspaper, 3=Ladder, 4=Target, 5=Garbage
