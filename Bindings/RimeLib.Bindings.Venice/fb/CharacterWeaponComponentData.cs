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
	[ContainerType(16, 112)]
	public class CharacterWeaponComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<SoldierWeaponBlueprint> DefaultWeaponBlueprint { get; set; } = new();

		[ContainerField(100), LayoutImmutable]
		public string AimBoneName { get; set; } = string.Empty;

		[ContainerField(104)]
		public CtrRef<SkeletonAsset> WeaponSkeleton { get; set; } = new();

		public static void Deserialize(CharacterWeaponComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DefaultWeaponBlueprint.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.AimBoneName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.WeaponSkeleton.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
