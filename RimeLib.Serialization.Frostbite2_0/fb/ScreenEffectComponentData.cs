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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 144)]
	public class ScreenEffectComponentData :
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec4 ScreenEffectParams { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public ScreenEffectFrameType FrameType { get; set; } = new();

		[ContainerField(116), JsonProperty(Order = 116)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float FrameWidth { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float OuterFrameOpacity { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float InnerFrameOpacity { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float Angle { get; set; }

		[ContainerField(136), JsonProperty(Order = 136)]
		public Realm Realm { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			ScreenEffectParams.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) FrameType);
			p_Writer.Write(p_EbxWriter.WriteImport(Shader));
			p_Writer.Write(FrameWidth);
			p_Writer.Write(OuterFrameOpacity);
			p_Writer.Write(InnerFrameOpacity);
			p_Writer.Write(Angle);
			p_Writer.Write((int) Realm);
			p_Writer.WriteNullBytes(4);
		}
	}
}
