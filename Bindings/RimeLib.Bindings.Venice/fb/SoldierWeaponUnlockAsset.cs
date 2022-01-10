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
	[ContainerType(4, 52)]
	public class SoldierWeaponUnlockAsset : 
		UnlockAssetBase
	{
		[ContainerField(40)]
		public CtrRef<SoldierWeaponBlueprint> Weapon { get; set; } = new();

		[ContainerField(44)]
		public CtrRef<UnlockAssetBase> Extra { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable]
		public uint WeaponIdentifier { get; set; }

		public static void Deserialize(SoldierWeaponUnlockAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Weapon.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Extra.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.WeaponIdentifier = p_Reader.ReadUInt32();
		}

	}
}
