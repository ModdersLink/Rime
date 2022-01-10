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
	public class MeshSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string OverrideShadersShaderName { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable]
		public string OverrideShadersMeshName { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable, Blittable]
		public int ForceLod { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float GlobalLodScale { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float ShadowDistanceScale { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public bool LoadingEnabled { get; set; }

		public static void Deserialize(MeshSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.OverrideShadersShaderName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.OverrideShadersMeshName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ForceLod = p_Reader.ReadInt32();
			p_Instance.GlobalLodScale = p_Reader.ReadSingle();
			p_Instance.ShadowDistanceScale = p_Reader.ReadSingle();
			p_Instance.LoadingEnabled = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
