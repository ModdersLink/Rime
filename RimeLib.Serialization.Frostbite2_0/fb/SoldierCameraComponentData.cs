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
	[ContainerType(16, 128)]
	public class SoldierCameraComponentData :
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float ExplosionImpulseMultiplier { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float StrafeTiltStrength { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float PitchTiltStrength { get; set; }

		[ContainerField(108), JsonProperty(Order = 108)]
		public RefArray<TargetCameraData> Cameras { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public CameraBinding CameraBinding { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float ForceFieldOfView { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public bool AuthoritativeEyePosition { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
		public bool DisableAiming { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ExplosionImpulseMultiplier);
			p_Writer.Write(StrafeTiltStrength);
			p_Writer.Write(PitchTiltStrength);
			(RimeWriter Writer, uint ArrayIndex) s_Cameras = p_EbxWriter.GetArrayWriter(Cameras.GetType(), Cameras.Count);
			p_Writer.Write(s_Cameras.ArrayIndex);
			foreach (var s_Entry in Cameras)
			{
				s_Cameras.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			CameraBinding.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ForceFieldOfView);
			p_Writer.Write(AuthoritativeEyePosition);
			p_Writer.Write(DisableAiming);
			p_Writer.WriteNullBytes(2);
		}
	}
}
