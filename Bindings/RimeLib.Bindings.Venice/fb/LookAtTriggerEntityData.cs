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
	[ContainerType(16, 144)]
	public class LookAtTriggerEntityData : 
		TriggerEventEntityData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public float FOV { get; set; }

		[ContainerField(116)]
		public CtrRef<SoldierWeaponBlueprint> Weapon { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public uint ZoomLevel { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float MinDistanceToObject { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float MaxDistanceToObject { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public bool StartTriggerLookingAt { get; set; }

		[ContainerField(133), LayoutImmutable, Blittable]
		public bool CheckOcclusion { get; set; }

		public static void Deserialize(LookAtTriggerEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.FOV = p_Reader.ReadSingle();
			p_Instance.Weapon.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ZoomLevel = p_Reader.ReadUInt32();
			p_Instance.MinDistanceToObject = p_Reader.ReadSingle();
			p_Instance.MaxDistanceToObject = p_Reader.ReadSingle();
			p_Instance.StartTriggerLookingAt = p_Reader.ReadBool();
			p_Instance.CheckOcclusion = p_Reader.ReadBool();
			p_Reader.Seek(10, SeekOrigin.Current);
		}

	}
}
