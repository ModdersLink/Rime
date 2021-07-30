///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 212)]
	public class GunSwayModifierData : 
		Asset
	{
		protected CtrRef<UnlockAssetBase> m_UnlockAsset = new CtrRef<UnlockAssetBase>();
		[ContainerField(Name: "UnlockAsset", Offset: 12, NameHash: 4135652293, Flags: 53)]
		public CtrRef<UnlockAssetBase> UnlockAsset { get { return m_UnlockAsset; } set { if (OnPropertyChanging("GunSwayModifierData." + nameof(UnlockAsset), this, m_UnlockAsset, value)) m_UnlockAsset = value; } } // 0xC (12)
		
		protected GunSwayStanceZoomModifierData m_StandZoomModifier = new GunSwayStanceZoomModifierData();
		[ContainerField(Name: "StandZoomModifier", Offset: 16, NameHash: 3254411401, Flags: 41)]
		public GunSwayStanceZoomModifierData StandZoomModifier { get { return m_StandZoomModifier; } set { if (OnPropertyChanging("GunSwayModifierData." + nameof(StandZoomModifier), this, m_StandZoomModifier, value)) m_StandZoomModifier = value; } } // 0x10 (16)
		
		protected GunSwayStanceZoomModifierData m_StandNoZoomModifier = new GunSwayStanceZoomModifierData();
		[ContainerField(Name: "StandNoZoomModifier", Offset: 48, NameHash: 96558760, Flags: 41)]
		public GunSwayStanceZoomModifierData StandNoZoomModifier { get { return m_StandNoZoomModifier; } set { if (OnPropertyChanging("GunSwayModifierData." + nameof(StandNoZoomModifier), this, m_StandNoZoomModifier, value)) m_StandNoZoomModifier = value; } } // 0x30 (48)
		
		protected GunSwayStanceZoomModifierData m_CrouchZoomModifier = new GunSwayStanceZoomModifierData();
		[ContainerField(Name: "CrouchZoomModifier", Offset: 80, NameHash: 3977198949, Flags: 41)]
		public GunSwayStanceZoomModifierData CrouchZoomModifier { get { return m_CrouchZoomModifier; } set { if (OnPropertyChanging("GunSwayModifierData." + nameof(CrouchZoomModifier), this, m_CrouchZoomModifier, value)) m_CrouchZoomModifier = value; } } // 0x50 (80)
		
		protected GunSwayStanceZoomModifierData m_CrouchNoZoomModifier = new GunSwayStanceZoomModifierData();
		[ContainerField(Name: "CrouchNoZoomModifier", Offset: 112, NameHash: 953586756, Flags: 41)]
		public GunSwayStanceZoomModifierData CrouchNoZoomModifier { get { return m_CrouchNoZoomModifier; } set { if (OnPropertyChanging("GunSwayModifierData." + nameof(CrouchNoZoomModifier), this, m_CrouchNoZoomModifier, value)) m_CrouchNoZoomModifier = value; } } // 0x70 (112)
		
		protected GunSwayStanceZoomModifierData m_ProneZoomModifier = new GunSwayStanceZoomModifierData();
		[ContainerField(Name: "ProneZoomModifier", Offset: 144, NameHash: 1838497731, Flags: 41)]
		public GunSwayStanceZoomModifierData ProneZoomModifier { get { return m_ProneZoomModifier; } set { if (OnPropertyChanging("GunSwayModifierData." + nameof(ProneZoomModifier), this, m_ProneZoomModifier, value)) m_ProneZoomModifier = value; } } // 0x90 (144)
		
		protected GunSwayStanceZoomModifierData m_ProneNoZoomModifier = new GunSwayStanceZoomModifierData();
		[ContainerField(Name: "ProneNoZoomModifier", Offset: 176, NameHash: 745395298, Flags: 41)]
		public GunSwayStanceZoomModifierData ProneNoZoomModifier { get { return m_ProneNoZoomModifier; } set { if (OnPropertyChanging("GunSwayModifierData." + nameof(ProneNoZoomModifier), this, m_ProneNoZoomModifier, value)) m_ProneNoZoomModifier = value; } } // 0xB0 (176)
		
		protected bool m_OnlyInSupportedShooting = new bool();
		[ContainerField(Name: "OnlyInSupportedShooting", Offset: 208, NameHash: 809776183, Flags: 49325), LayoutImmutable, Blittable]
		public bool OnlyInSupportedShooting { get { return m_OnlyInSupportedShooting; } set { if (OnPropertyChanging("GunSwayModifierData." + nameof(OnlyInSupportedShooting), this, m_OnlyInSupportedShooting, value)) m_OnlyInSupportedShooting = value; } } // 0xD0 (208)
		
		protected bool m_OnlyOnWeaponLightEnabled = new bool();
		[ContainerField(Name: "OnlyOnWeaponLightEnabled", Offset: 209, NameHash: 3985551625, Flags: 49325), LayoutImmutable, Blittable]
		public bool OnlyOnWeaponLightEnabled { get { return m_OnlyOnWeaponLightEnabled; } set { if (OnPropertyChanging("GunSwayModifierData." + nameof(OnlyOnWeaponLightEnabled), this, m_OnlyOnWeaponLightEnabled, value)) m_OnlyOnWeaponLightEnabled = value; } } // 0xD1 (209)
		
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
