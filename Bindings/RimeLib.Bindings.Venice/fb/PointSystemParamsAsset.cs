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
	[ContainerType(4, 32)]
	public class PointSystemParamsAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MultiKillTimeLimit { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float DnfTimeout { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint KillStreakX { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint NemesisKillX { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float FreefallHeight { get; set; }

		public static void Deserialize(PointSystemParamsAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MultiKillTimeLimit = p_Reader.ReadSingle();
			p_Instance.DnfTimeout = p_Reader.ReadSingle();
			p_Instance.KillStreakX = p_Reader.ReadUInt32();
			p_Instance.NemesisKillX = p_Reader.ReadUInt32();
			p_Instance.FreefallHeight = p_Reader.ReadSingle();
		}

	}
}
