///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 212)]
	public class GunSwayModifierData : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<UnlockAssetBase> UnlockAsset { get; set; } = new();

		[ContainerField(16)]
		public GunSwayStanceZoomModifierData StandZoomModifier { get; set; } = new();

		[ContainerField(48)]
		public GunSwayStanceZoomModifierData StandNoZoomModifier { get; set; } = new();

		[ContainerField(80)]
		public GunSwayStanceZoomModifierData CrouchZoomModifier { get; set; } = new();

		[ContainerField(112)]
		public GunSwayStanceZoomModifierData CrouchNoZoomModifier { get; set; } = new();

		[ContainerField(144)]
		public GunSwayStanceZoomModifierData ProneZoomModifier { get; set; } = new();

		[ContainerField(176)]
		public GunSwayStanceZoomModifierData ProneNoZoomModifier { get; set; } = new();

		[ContainerField(208), LayoutImmutable, Blittable]
		public bool OnlyInSupportedShooting { get; set; }

		[ContainerField(209), LayoutImmutable, Blittable]
		public bool OnlyOnWeaponLightEnabled { get; set; }

		public static void Deserialize(GunSwayModifierData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.UnlockAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			fb.GunSwayStanceZoomModifierData.Deserialize(p_Instance.StandZoomModifier, p_Reader, p_Parser);
			fb.GunSwayStanceZoomModifierData.Deserialize(p_Instance.StandNoZoomModifier, p_Reader, p_Parser);
			fb.GunSwayStanceZoomModifierData.Deserialize(p_Instance.CrouchZoomModifier, p_Reader, p_Parser);
			fb.GunSwayStanceZoomModifierData.Deserialize(p_Instance.CrouchNoZoomModifier, p_Reader, p_Parser);
			fb.GunSwayStanceZoomModifierData.Deserialize(p_Instance.ProneZoomModifier, p_Reader, p_Parser);
			fb.GunSwayStanceZoomModifierData.Deserialize(p_Instance.ProneNoZoomModifier, p_Reader, p_Parser);
			p_Instance.OnlyInSupportedShooting = p_Reader.ReadBool();
			p_Instance.OnlyOnWeaponLightEnabled = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
