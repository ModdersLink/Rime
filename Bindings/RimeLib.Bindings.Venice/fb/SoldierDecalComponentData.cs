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
	public class SoldierDecalComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<DecalTemplateData> SplashDecal { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float SplashRayLength { get; set; }

		[ContainerField(104)]
		public CtrRef<DecalTemplateData> PoolDecal { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public float PoolRayYOffset { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float PoolRayLength { get; set; }

		public static void Deserialize(SoldierDecalComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SplashDecal.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SplashRayLength = p_Reader.ReadSingle();
			p_Instance.PoolDecal.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.PoolRayYOffset = p_Reader.ReadSingle();
			p_Instance.PoolRayLength = p_Reader.ReadSingle();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
