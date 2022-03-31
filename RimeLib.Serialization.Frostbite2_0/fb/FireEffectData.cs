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
	public class FireEffectData :
		EbxSerializable
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec3 Rotation { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 Offset { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 ZoomRotation { get; set; } = new();
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec3 ZoomOffset { get; set; } = new();
		
		[ContainerField(64), JsonProperty(Order = 64)]
		public CtrRef<EffectBlueprint> Effect { get; set; } = new();
		
		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public bool UseZoomOffset { get; set; }
		
		[ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		public bool UseZoomRotation { get; set; }
		
		[ContainerField(70), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
		public bool DisableDuringZoom { get; set; }
		
		[ContainerField(71), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
		public bool UpdateTransform { get; set; }
		
		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public bool StopLoopingEffects { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Rotation.Serialize(p_Writer, p_EbxWriter);
			Offset.Serialize(p_Writer, p_EbxWriter);
			ZoomRotation.Serialize(p_Writer, p_EbxWriter);
			ZoomOffset.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Effect));
			p_Writer.Write(UseZoomOffset);
			p_Writer.Write(UseZoomRotation);
			p_Writer.Write(DisableDuringZoom);
			p_Writer.Write(UpdateTransform);
			p_Writer.Write(StopLoopingEffects);
			p_Writer.WriteNullBytes(7);
		}
	}
}
