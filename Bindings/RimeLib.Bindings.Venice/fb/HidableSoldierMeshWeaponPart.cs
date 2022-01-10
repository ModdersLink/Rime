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
	[ContainerType(4, 16)]
	public class HidableSoldierMeshWeaponPart
	{
		[ContainerField(0)]
		public CtrRef<SkinnedMeshAsset> WeaponMesh { get; set; } = new();
		
		[ContainerField(4)]
		public CtrRef<ObjectBlueprint> WeaponMeshBlueprint { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable]
		public string BoneName { get; set; } = string.Empty;
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool HideAlways { get; set; }
		
		[ContainerField(13), LayoutImmutable, Blittable]
		public bool HideInVehicleEntries { get; set; }
		
		public static void Deserialize(HidableSoldierMeshWeaponPart p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.WeaponMesh.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.WeaponMeshBlueprint.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.BoneName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.HideAlways = p_Reader.ReadBool();
			p_Instance.HideInVehicleEntries = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}
	}
}
