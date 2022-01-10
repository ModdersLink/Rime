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
	public class EngineComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<EngineConfigData> Config { get; set; } = new();

		[ContainerField(100)]
		public CtrRef<SoundAsset> SoundEffect { get; set; } = new();

		[ContainerField(104)]
		public CtrRef<SoundAsset> SurfaceSoundEffect { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public bool UseFirstPersonSounds { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable]
		public bool OutputIsEngineInWater { get; set; }

		public static void Deserialize(EngineComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Config.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SoundEffect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SurfaceSoundEffect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.UseFirstPersonSounds = p_Reader.ReadBool();
			p_Instance.OutputIsEngineInWater = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
