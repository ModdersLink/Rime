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
	[ContainerType(16, 224)]
	public class FPSCameraData :
		TargetCameraData
	{
		[ContainerField(160), JsonProperty(Order = 160)]
		public TurnEffectData TurnEffectSettings { get; set; } = new();

		[ContainerField(192), JsonProperty(Order = 192)]
		public BlurEffectData BlurEffectSettings { get; set; } = new();

		[ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		public float FOV { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			TurnEffectSettings.Serialize(p_Writer, p_EbxWriter);
			BlurEffectSettings.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FOV);
			p_Writer.WriteNullBytes(4);
		}
	}
}
