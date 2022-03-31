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
	[ContainerType(4, 80)]
	public class ChildRotationBodyData :
		RotationBodyData
	{
		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float ForceModifier { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float ResetForceModifier { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float ResetForceInputThreshold { get; set; }

		[ContainerField(68), JsonProperty(Order = 68)]
		public EntryInputActionEnum RotationInput { get; set; } = new();

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public float WorldSpaceLockEfficiency { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public bool UseLinearInput { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ForceModifier);
			p_Writer.Write(ResetForceModifier);
			p_Writer.Write(ResetForceInputThreshold);
			p_Writer.Write((int) RotationInput);
			p_Writer.Write(WorldSpaceLockEfficiency);
			p_Writer.Write(UseLinearInput);
			p_Writer.WriteNullBytes(3);
		}
	}
}
