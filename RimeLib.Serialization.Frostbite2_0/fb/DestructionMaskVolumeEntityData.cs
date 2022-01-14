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
	[ContainerType(16, 160)]
	public class DestructionMaskVolumeEntityData :
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec4 DustAccumulationCurve { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public Vec4 ShaderUserMasks { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float DustAccumulationLifeTime { get; set; }

		[ContainerField(132), JsonProperty(Order = 132)]
		public SurfaceShaderInstanceDataStruct Shader { get; set; } = new();

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float Radius { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			DustAccumulationCurve.Serialize(p_Writer, p_EbxWriter);
			ShaderUserMasks.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(DustAccumulationLifeTime);
			Shader.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Radius);
			p_Writer.WriteNullBytes(4);
		}
	}
}
