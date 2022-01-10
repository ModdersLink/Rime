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
	[ContainerType(4, 28)]
	public class BigWorldSetting : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<SoundAsset> Sound { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public int MinDistance { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public int MaxDistance { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float MinDelayTimeInMinutes { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxDelayTimeInMinutes { get; set; }

		public static void Deserialize(BigWorldSetting p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Sound.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MinDistance = p_Reader.ReadInt32();
			p_Instance.MaxDistance = p_Reader.ReadInt32();
			p_Instance.MinDelayTimeInMinutes = p_Reader.ReadSingle();
			p_Instance.MaxDelayTimeInMinutes = p_Reader.ReadSingle();
		}

	}
}
