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
	[ContainerType(16, 80)]
	public class CameraData :
		GameObjectData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 OcclusionRayOffset { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float ShakeFactor { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float PreFadeTime { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float FadeTime { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float FadeWaitTime { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float SoundListenerRadius { get; set; }

		[ContainerField(52), JsonProperty(Order = 52)]
		public CtrRef<ViewFxData> ViewFx { get; set; } = new();

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float NearPlane { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float ShadowViewDistanceScale { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float SoundOcclusion { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public bool StayFadedWhileStreaming { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			OcclusionRayOffset.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ShakeFactor);
			p_Writer.Write(PreFadeTime);
			p_Writer.Write(FadeTime);
			p_Writer.Write(FadeWaitTime);
			p_Writer.Write(SoundListenerRadius);
			p_Writer.Write(p_EbxWriter.WriteImport(ViewFx));
			p_Writer.Write(NearPlane);
			p_Writer.Write(ShadowViewDistanceScale);
			p_Writer.Write(SoundOcclusion);
			p_Writer.Write(StayFadedWhileStreaming);
			p_Writer.WriteNullBytes(11);
		}
	}
}
