# Plant 还原清单

| # | 方法 | 汇编行数 | 文件 |
|---|---|---|---|
| 1 | `System.Void DrawSeedType(Reloaded.Gameplay.SeedType theSeedType, Reloaded.Gameplay.SeedType theImitaterType, Reloaded.Gameplay.DrawVariation theDrawVariation, System.Single thePosX, System.Single thePosY)` | 7 | [0001_DrawSeedType.md](0001_DrawSeedType.md) |
| 2 | `System.Void PreloadPlantResources(Reloaded.Gameplay.SeedType theSeedType)` | 7 | [0002_PreloadPlantResources.md](0002_PreloadPlantResources.md) |
| 3 | `System.Void UpdateNeedsFood()` | 7 | [0003_UpdateNeedsFood.md](0003_UpdateNeedsFood.md) |
| 4 | `Reloaded.Gameplay.Reanimation AttachBlinkAnim(Reloaded.Gameplay.Reanimation theReanimBody)` | 9 | [0004_AttachBlinkAnim.md](0004_AttachBlinkAnim.md) |
| 5 | `System.Boolean IsFlying(Reloaded.Gameplay.SeedType theSeedtype)` | 11 | [0005_IsFlying.md](0005_IsFlying.md) |
| 6 | `System.Boolean IsOnBoard()` | 17 | [0006_IsOnBoard.md](0006_IsOnBoard.md) |
| 7 | `System.Void UpdateFlowerPot()` | 17 | [0007_UpdateFlowerPot.md](0007_UpdateFlowerPot.md) |
| 8 | `System.Void UpdateLilypad()` | 17 | [0008_UpdateLilypad.md](0008_UpdateLilypad.md) |
| 9 | `System.Void UpdateIceShroom()` | 19 | [0009_UpdateIceShroom.md](0009_UpdateIceShroom.md) |
| 10 | `System.Boolean IsSpiky()` | 19 | [0010_IsSpiky.md](0010_IsSpiky.md) |
| 11 | `System.Void EndBlink()` | 22 | [0011_EndBlink.md](0011_EndBlink.md) |
| 12 | `System.Boolean MakesSun()` | 23 | [0012_MakesSun.md](0012_MakesSun.md) |
| 13 | `UnityEngine.Sprite GetImage(Reloaded.Gameplay.SeedType theSeedtype)` | 25 | [0013_GetImage.md](0013_GetImage.md) |
| 14 | `System.Boolean IsNocturnal(Reloaded.Gameplay.SeedType theSeedtype)` | 25 | [0014_IsNocturnal.md](0014_IsNocturnal.md) |
| 15 | `System.Boolean IsAquatic(Reloaded.Gameplay.SeedType theSeedType)` | 25 | [0015_IsAquatic.md](0015_IsAquatic.md) |
| 16 | `System.Boolean IsUpgrade(Reloaded.Gameplay.SeedType theSeedtype)` | 25 | [0016_IsUpgrade.md](0016_IsUpgrade.md) |
| 17 | `System.Boolean HasHeadAnimation()` | 39 | [0017_HasHeadAnimation.md](0017_HasHeadAnimation.md) |
| 18 | `System.Boolean NotOnGround()` | 41 | [0018_NotOnGround.md](0018_NotOnGround.md) |
| 19 | `System.Void UpdateCoffeeBean()` | 53 | [0019_UpdateCoffeeBean.md](0019_UpdateCoffeeBean.md) |
| 20 | `System.Boolean IsOnHighGround()` | 61 | [0020_IsOnHighGround.md](0020_IsOnHighGround.md) |
| 21 | `System.Void UpdateInternal()` | 62 | [0021_UpdateInternal.md](0021_UpdateInternal.md) |
| 22 | `System.Void ImitaterMorph()` | 65 | [0022_ImitaterMorph.md](0022_ImitaterMorph.md) |
| 23 | `System.Boolean IsInPlay()` | 68 | [0023_IsInPlay.md](0023_IsInPlay.md) |
| 24 | `Unity.Mathematics.float2 GetPeaHeadOffset()` | 70 | [0024_GetPeaHeadOffset.md](0024_GetPeaHeadOffset.md) |
| 25 | `System.Void PostUpdate()` | 71 | [0025_PostUpdate.md](0025_PostUpdate.md) |
| 26 | `System.Void AttemptSetMarigoldColour(System.String colour)` | 81 | [0026_AttemptSetMarigoldColour.md](0026_AttemptSetMarigoldColour.md) |
| 27 | `System.String GetToolTip(Reloaded.Gameplay.SeedType theSeedType)` | 86 | [0027_GetToolTip.md](0027_GetToolTip.md) |
| 28 | `UnityEngine.Rect GetPlantRect()` | 87 | [0028_GetPlantRect.md](0028_GetPlantRect.md) |
| 29 | `Reloaded.Gameplay.MagnetItem GetFreeMagnetItem()` | 87 | [0029_GetFreeMagnetItem.md](0029_GetFreeMagnetItem.md) |
| 30 | `System.Void UpdateUmbrella()` | 90 | [0030_UpdateUmbrella.md](0030_UpdateUmbrella.md) |
| 31 | `System.Void UpdateBlover()` | 97 | [0031_UpdateBlover.md](0031_UpdateBlover.md) |
| 32 | `System.Void PlayBodyReanim(System.String theTrackName, Reloaded.Gameplay.ReanimLoopType theLoopType, System.Int32 theBlendTime, System.Single theAnimRate)` | 106 | [0032_PlayBodyReanim.md](0032_PlayBodyReanim.md) |
| 33 | `System.Void KillAllPlantsNearDoom()` | 111 | [0033_KillAllPlantsNearDoom.md](0033_KillAllPlantsNearDoom.md) |
| 34 | `System.Void LaunchStarFruit()` | 111 | [0034_LaunchStarFruit.md](0034_LaunchStarFruit.md) |
| 35 | `System.Single PlantFlowerPotHeightOffset(Reloaded.Gameplay.SeedType theSeedType, System.Single theFlowerPotScale)` | 123 | [0035_PlantFlowerPotHeightOffset.md](0035_PlantFlowerPotHeightOffset.md) |
| 36 | `Reloaded.Gameplay.DamageRangeFlags GetDamageRangeFlags(Reloaded.Gameplay.PlantWeapon thePlantWeapon)` | 123 | [0036_GetDamageRangeFlags.md](0036_GetDamageRangeFlags.md) |
| 37 | `System.Void SpikeRockTakeDamage()` | 123 | [0037_SpikeRockTakeDamage.md](0037_SpikeRockTakeDamage.md) |
| 38 | `System.Void SpikeweedAttack()` | 131 | [0038_SpikeweedAttack.md](0038_SpikeweedAttack.md) |
| 39 | `System.Boolean IsUpgradableTo(Reloaded.Gameplay.SeedType aUpdatedType)` | 135 | [0039_IsUpgradableTo.md](0039_IsUpgradableTo.md) |
| 40 | `System.Void CobCannonFire(System.Int32 theTargetX, System.Int32 theTargetY)` | 139 | [0040_CobCannonFire.md](0040_CobCannonFire.md) |
| 41 | `System.Void RemoveEffects()` | 141 | [0041_RemoveEffects.md](0041_RemoveEffects.md) |
| 42 | `System.Void UpdateSpikeweed()` | 145 | [0042_UpdateSpikeweed.md](0042_UpdateSpikeweed.md) |
| 43 | `System.Void IceZombies()` | 147 | [0043_IceZombies.md](0043_IceZombies.md) |
| 44 | `Reloaded.Gameplay.TodParticleSystem AddAttachedParticle(System.Int32 thePosX, System.Int32 thePosY, System.Int32 theRenderPostition, Reloaded.Gameplay.ParticleEffect theEffect)` | 147 | [0044_AddAttachedParticle.md](0044_AddAttachedParticle.md) |
| 45 | `System.Void UpdateDoomShroom()` | 151 | [0045_UpdateDoomShroom.md](0045_UpdateDoomShroom.md) |
| 46 | `Reloaded.Gameplay.TodParticleSystem AddAttachedParticle(System.Single thePosX, System.Single thePosY, System.Int32 theRenderPostition, Reloaded.Gameplay.ParticleEffect theEffect)` | 153 | [0046_AddAttachedParticle.md](0046_AddAttachedParticle.md) |
| 47 | `System.Boolean DrawMagnetItemsOnTop()` | 153 | [0047_DrawMagnetItemsOnTop.md](0047_DrawMagnetItemsOnTop.md) |
| 48 | `System.Void Reset()` | 160 | [0048_Reset.md](0048_Reset.md) |
| 49 | `System.Void PlayIdleAnim(System.Single theRate)` | 161 | [0049_PlayIdleAnim.md](0049_PlayIdleAnim.md) |
| 50 | `System.Void Update()` | 163 | [0050_Update.md](0050_Update.md) |
| 51 | `System.Int32 GetRefreshTime(Reloaded.TreeStateActivities.GameplayActivity app, Reloaded.Gameplay.SeedType theSeedType, Reloaded.Gameplay.SeedType theImitaterType)` | 166 | [0051_GetRefreshTime.md](0051_GetRefreshTime.md) |
| 52 | `System.Void BlowAwayFliers(System.Single theX, System.Int32 theRow)` | 167 | [0052_BlowAwayFliers.md](0052_BlowAwayFliers.md) |
| 53 | `System.Void BlowAwayFliers(System.Int32 theX, System.Int32 theRow)` | 167 | [0053_BlowAwayFliers.md](0053_BlowAwayFliers.md) |
| 54 | `System.String GetNameString(Reloaded.TreeStateActivities.GameplayActivity app, Reloaded.Gameplay.SeedType theSeedtype, Reloaded.Gameplay.SeedType theImitaterType)` | 169 | [0054_GetNameString.md](0054_GetNameString.md) |
| 55 | `System.Boolean IsAGoldMagnetAboutToSuck()` | 190 | [0055_IsAGoldMagnetAboutToSuck.md](0055_IsAGoldMagnetAboutToSuck.md) |
| 56 | `System.Void AnimateGarlic()` | 191 | [0056_AnimateGarlic.md](0056_AnimateGarlic.md) |
| 57 | `System.Void UpdateSunShroom()` | 208 | [0057_UpdateSunShroom.md](0057_UpdateSunShroom.md) |
| 58 | `System.Void UpdateImitater()` | 208 | [0058_UpdateImitater.md](0058_UpdateImitater.md) |
| 59 | `System.Void UpdateTorchwood()` | 209 | [0059_UpdateTorchwood.md](0059_UpdateTorchwood.md) |
| 60 | `System.Void Squish()` | 211 | [0060_Squish.md](0060_Squish.md) |
| 61 | `System.Void MouseDown(System.Int32 x, System.Int32 y, System.Int32 theClickCount, System.Int32 playerIndex)` | 217 | [0061_MouseDown.md](0061_MouseDown.md) |
| 62 | `System.Void UpdateBlink()` | 219 | [0062_UpdateBlink.md](0062_UpdateBlink.md) |
| 63 | `System.Boolean IsPartOfUpgradableTo(Reloaded.Gameplay.SeedType aUpdatedType)` | 219 | [0063_IsPartOfUpgradableTo.md](0063_IsPartOfUpgradableTo.md) |
| 64 | `System.Int32 DistanceToClosestZombie()` | 223 | [0064_DistanceToClosestZombie.md](0064_DistanceToClosestZombie.md) |
| 65 | `System.Void AnimatePumpkin()` | 240 | [0065_AnimatePumpkin.md](0065_AnimatePumpkin.md) |
| 66 | `System.Int32 CalcRenderOrder()` | 243 | [0066_CalcRenderOrder.md](0066_CalcRenderOrder.md) |
| 67 | `System.Void DoSquashDamage()` | 249 | [0067_DoSquashDamage.md](0067_DoSquashDamage.md) |
| 68 | `Reloaded.Gameplay.Coin FindGoldMagnetTarget()` | 253 | [0068_FindGoldMagnetTarget.md](0068_FindGoldMagnetTarget.md) |
| 69 | `System.Void LaunchThreepeater()` | 261 | [0069_LaunchThreepeater.md](0069_LaunchThreepeater.md) |
| 70 | `System.Void GoldMagnetFindTargets()` | 261 | [0070_GoldMagnetFindTargets.md](0070_GoldMagnetFindTargets.md) |
| 71 | `System.Int32 GetCost(Reloaded.TreeStateActivities.GameplayActivity gLawnApp, Reloaded.Gameplay.SeedType theSeedType, Reloaded.Gameplay.SeedType theImitaterType)` | 268 | [0071_GetCost.md](0071_GetCost.md) |
| 72 | `System.Void BurnRow(System.Int32 theRow)` | 271 | [0072_BurnRow.md](0072_BurnRow.md) |
| 73 | `System.Void UpdateGraveBuster()` | 278 | [0073_UpdateGraveBuster.md](0073_UpdateGraveBuster.md) |
| 74 | `System.Void DoBlink()` | 300 | [0074_DoBlink.md](0074_DoBlink.md) |
| 75 | `System.Void UpdateCobCannon()` | 303 | [0075_UpdateCobCannon.md](0075_UpdateCobCannon.md) |
| 76 | `System.Void UpdateCactus()` | 315 | [0076_UpdateCactus.md](0076_UpdateCactus.md) |
| 77 | `System.Void DoRowAreaDamage(System.Int32 theDamage, Reloaded.Gameplay.DamageFlags theDamageFlags)` | 317 | [0077_DoRowAreaDamage.md](0077_DoRowAreaDamage.md) |
| 78 | `System.Void StarFruitFire()` | 329 | [0078_StarFruitFire.md](0078_StarFruitFire.md) |
| 79 | `System.Void UpdateTanglekelp()` | 342 | [0079_UpdateTanglekelp.md](0079_UpdateTanglekelp.md) |
| 80 | `System.Void UpdateShooter()` | 345 | [0080_UpdateShooter.md](0080_UpdateShooter.md) |
| 81 | `System.Void AnimateNuts()` | 367 | [0081_AnimateNuts.md](0081_AnimateNuts.md) |
| 82 | `System.Void DrawMagnetItems()` | 383 | [0082_DrawMagnetItems.md](0082_DrawMagnetItems.md) |
| 83 | `System.Void SetSleeping(System.Boolean theIsAsleep)` | 401 | [0083_SetSleeping.md](0083_SetSleeping.md) |
| 84 | `System.Void Draw()` | 421 | [0084_Draw.md](0084_Draw.md) |
| 85 | `System.Boolean FindStarFruitTarget()` | 421 | [0085_FindStarFruitTarget.md](0085_FindStarFruitTarget.md) |
| 86 | `System.Void Die()` | 433 | [0086_Die.md](0086_Die.md) |
| 87 | `UnityEngine.Rect GetPlantAttackRect(Reloaded.Gameplay.PlantWeapon thePlantWeapon)` | 464 | [0087_GetPlantAttackRect.md](0087_GetPlantAttackRect.md) |
| 88 | `Reloaded.Gameplay.Zombie FindSquashTarget()` | 471 | [0088_FindSquashTarget.md](0088_FindSquashTarget.md) |
| 89 | `System.Void UpdateProductionPlant()` | 483 | [0089_UpdateProductionPlant.md](0089_UpdateProductionPlant.md) |
| 90 | `System.Void UpdateChomper()` | 486 | [0090_UpdateChomper.md](0090_UpdateChomper.md) |
| 91 | `System.Boolean FindTargetAndFire(System.Int32 theRow, Reloaded.Gameplay.PlantWeapon thePlantWeapon)` | 517 | [0091_FindTargetAndFire.md](0091_FindTargetAndFire.md) |
| 92 | `System.Void UpdateScaredyShroom()` | 531 | [0092_UpdateScaredyShroom.md](0092_UpdateScaredyShroom.md) |
| 93 | `System.Single PlantDrawHeightOffset(Reloaded.TreeStateActivities.GameplayActivity app, Reloaded.Gameplay.Board theBoard, Reloaded.Gameplay.Plant thePlant, Reloaded.Gameplay.SeedType theSeedType, System.Int32 theCol, System.Int32 theRow)` | 537 | [0093_PlantDrawHeightOffset.md](0093_PlantDrawHeightOffset.md) |
| 94 | `System.Void DrawShadow(System.Single theOffsetX, System.Single theOffsetY)` | 601 | [0094_DrawShadow.md](0094_DrawShadow.md) |
| 95 | `Reloaded.Gameplay.Zombie FindTargetZombie(System.Int32 theRow, Reloaded.Gameplay.PlantWeapon thePlantWeapon)` | 623 | [0095_FindTargetZombie.md](0095_FindTargetZombie.md) |
| 96 | `System.Void .ctor()` | 671 | [0096_ctor.md](0096_ctor.md) |
| 97 | `System.Void Animate()` | 672 | [0097_Animate.md](0097_Animate.md) |
| 98 | `System.Void UpdatePotato()` | 673 | [0098_UpdatePotato.md](0098_UpdatePotato.md) |
| 99 | `System.Void UpdateGoldMagnetShroom()` | 731 | [0099_UpdateGoldMagnetShroom.md](0099_UpdateGoldMagnetShroom.md) |
| 100 | `System.Void UpdateReanim()` | 737 | [0100_UpdateReanim.md](0100_UpdateReanim.md) |
| 101 | `System.Void Serialize(ref Source.Serialization.ReloadedBinaryWriter writer, System.Int32 version)` | 753 | [0101_Serialize.md](0101_Serialize.md) |
| 102 | `System.Void UpdateSquash()` | 809 | [0102_UpdateSquash.md](0102_UpdateSquash.md) |
| 103 | `System.Void UpdateBowling()` | 817 | [0103_UpdateBowling.md](0103_UpdateBowling.md) |
| 104 | `System.Void MagnetShroomAttactItem(Reloaded.Gameplay.Zombie theZombie)` | 879 | [0104_MagnetShroomAttactItem.md](0104_MagnetShroomAttactItem.md) |
| 105 | `System.Void UpdateReanimColor()` | 883 | [0105_UpdateReanimColor.md](0105_UpdateReanimColor.md) |
| 106 | `System.Void Deserialize(ref Source.Serialization.ReloadedBinaryReader reader, System.Int32 version)` | 953 | [0106_Deserialize.md](0106_Deserialize.md) |
| 107 | `System.Void DoSpecial()` | 1193 | [0107_DoSpecial.md](0107_DoSpecial.md) |
| 108 | `System.Void UpdateShooting()` | 1233 | [0108_UpdateShooting.md](0108_UpdateShooting.md) |
| 109 | `System.Void Fire(Reloaded.Gameplay.Zombie theTargetZombie, System.Int32 theRow, Reloaded.Gameplay.PlantWeapon thePlantWeapon)` | 1251 | [0109_Fire.md](0109_Fire.md) |
| 110 | `System.Void UpdateMagnetShroom()` | 1251 | [0110_UpdateMagnetShroom.md](0110_UpdateMagnetShroom.md) |
| 111 | `System.Void PlantInitialize(System.Int32 theGridX, System.Int32 theGridY, Reloaded.Gameplay.SeedType theSeedType, Reloaded.Gameplay.SeedType theImitaterType, Source.Controllers.PlantController controller = null, System.Boolean forceDecemberContent = False, System.Boolean forceNormalContent = False)` | 2069 | [0111_PlantInitialize.md](0111_PlantInitialize.md) |
| 112 | `System.Void UpdateAbilities()` | 2717 | [0112_UpdateAbilities.md](0112_UpdateAbilities.md) |
