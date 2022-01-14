///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 32)]
	public class MeshSettings :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string OverrideShadersShaderName { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string OverrideShadersMeshName { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public int ForceLod { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float GlobalLodScale { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float ShadowDistanceScale { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public bool LoadingEnabled { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(OverrideShadersShaderName));
			p_Writer.Write(p_EbxWriter.WriteString(OverrideShadersMeshName));
			p_Writer.Write(ForceLod);
			p_Writer.Write(GlobalLodScale);
			p_Writer.Write(ShadowDistanceScale);
			p_Writer.Write(LoadingEnabled);
			p_Writer.WriteNullBytes(3);
		}
	}
}
