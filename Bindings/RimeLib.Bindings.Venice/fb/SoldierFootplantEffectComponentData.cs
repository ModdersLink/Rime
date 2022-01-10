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
	[ContainerType(16, 128)]
	public class SoldierFootplantEffectComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<MaterialContainerPair> FootMaterialPair { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float HeightOverGroundThreshold { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float FootVelocityThreshold { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float LodDistance { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public bool FullFootplantingEnabled { get; set; }

		public static void Deserialize(SoldierFootplantEffectComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.FootMaterialPair.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.HeightOverGroundThreshold = p_Reader.ReadSingle();
			p_Instance.FootVelocityThreshold = p_Reader.ReadSingle();
			p_Instance.LodDistance = p_Reader.ReadSingle();
			p_Instance.FullFootplantingEnabled = p_Reader.ReadBool();
			p_Reader.Seek(15, SeekOrigin.Current);
		}

	}
}
