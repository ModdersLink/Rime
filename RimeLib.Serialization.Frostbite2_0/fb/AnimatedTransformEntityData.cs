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
	[ContainerType(4, 28)]
	public class AnimatedTransformEntityData :
		EntityData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public AntRef Animatable { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float ExternalTime { get; set; }

		[ContainerField(20), JsonProperty(Order = 20)]
		public AntRef Controller { get; set; } = new();

		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string BoneName { get; set; } = string.Empty;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Animatable.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ExternalTime);
			Controller.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(BoneName));
		}
	}
}
