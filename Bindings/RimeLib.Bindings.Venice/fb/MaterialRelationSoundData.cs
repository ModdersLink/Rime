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
	[ContainerType(4, 20)]
	public class MaterialRelationSoundData : 
		PhysicsMaterialRelationPropertyData
	{
		[ContainerField(8)]
		public CtrRef<SoundAsset> ImpactSound { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<SoundAsset> ScrapeSound { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float ScrapeLength { get; set; }

		public static void Deserialize(MaterialRelationSoundData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ImpactSound.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ScrapeSound.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ScrapeLength = p_Reader.ReadSingle();
		}

	}
}
