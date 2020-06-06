///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class GunSwayModifierData : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<UnlockAssetBase> UnlockAsset { get; set; } = new CtrRef<UnlockAssetBase>(); // 0xC (12)
		
		[ContainerField(16)]
		public GunSwayStanceZoomModifierData StandZoomModifier { get; set; } = new GunSwayStanceZoomModifierData(); // 0x10 (16)
		
		[ContainerField(48)]
		public GunSwayStanceZoomModifierData StandNoZoomModifier { get; set; } = new GunSwayStanceZoomModifierData(); // 0x30 (48)
		
		[ContainerField(80)]
		public GunSwayStanceZoomModifierData CrouchZoomModifier { get; set; } = new GunSwayStanceZoomModifierData(); // 0x50 (80)
		
		[ContainerField(112)]
		public GunSwayStanceZoomModifierData CrouchNoZoomModifier { get; set; } = new GunSwayStanceZoomModifierData(); // 0x70 (112)
		
		[ContainerField(144)]
		public GunSwayStanceZoomModifierData ProneZoomModifier { get; set; } = new GunSwayStanceZoomModifierData(); // 0x90 (144)
		
		[ContainerField(176)]
		public GunSwayStanceZoomModifierData ProneNoZoomModifier { get; set; } = new GunSwayStanceZoomModifierData(); // 0xB0 (176)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public bool OnlyInSupportedShooting { get; set; } // 0xD0 (208)
		
		[ContainerField(209), LayoutImmutable, Blittable]
		public bool OnlyOnWeaponLightEnabled { get; set; } // 0xD1 (209)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4135652293:
					UnlockAsset = (CtrRef<UnlockAssetBase>) p_Value;
					break;

				case 3254411401:
					StandZoomModifier = (GunSwayStanceZoomModifierData) p_Value;
					break;

				case 96558760:
					StandNoZoomModifier = (GunSwayStanceZoomModifierData) p_Value;
					break;

				case 3977198949:
					CrouchZoomModifier = (GunSwayStanceZoomModifierData) p_Value;
					break;

				case 953586756:
					CrouchNoZoomModifier = (GunSwayStanceZoomModifierData) p_Value;
					break;

				case 1838497731:
					ProneZoomModifier = (GunSwayStanceZoomModifierData) p_Value;
					break;

				case 745395298:
					ProneNoZoomModifier = (GunSwayStanceZoomModifierData) p_Value;
					break;

				case 809776183:
					OnlyInSupportedShooting = (bool) p_Value;
					break;

				case 3985551625:
					OnlyOnWeaponLightEnabled = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4135652293:
					return UnlockAsset;

				case 3254411401:
					return StandZoomModifier;

				case 96558760:
					return StandNoZoomModifier;

				case 3977198949:
					return CrouchZoomModifier;

				case 953586756:
					return CrouchNoZoomModifier;

				case 1838497731:
					return ProneZoomModifier;

				case 745395298:
					return ProneNoZoomModifier;

				case 809776183:
					return OnlyInSupportedShooting;

				case 3985551625:
					return OnlyOnWeaponLightEnabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4135652293:
					return typeof(GunSwayModifierData).GetProperty(nameof(UnlockAsset));

				case 3254411401:
					return typeof(GunSwayModifierData).GetProperty(nameof(StandZoomModifier));

				case 96558760:
					return typeof(GunSwayModifierData).GetProperty(nameof(StandNoZoomModifier));

				case 3977198949:
					return typeof(GunSwayModifierData).GetProperty(nameof(CrouchZoomModifier));

				case 953586756:
					return typeof(GunSwayModifierData).GetProperty(nameof(CrouchNoZoomModifier));

				case 1838497731:
					return typeof(GunSwayModifierData).GetProperty(nameof(ProneZoomModifier));

				case 745395298:
					return typeof(GunSwayModifierData).GetProperty(nameof(ProneNoZoomModifier));

				case 809776183:
					return typeof(GunSwayModifierData).GetProperty(nameof(OnlyInSupportedShooting));

				case 3985551625:
					return typeof(GunSwayModifierData).GetProperty(nameof(OnlyOnWeaponLightEnabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
