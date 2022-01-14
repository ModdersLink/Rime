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
	[ContainerType(16, 112)]
	public class TransformModifierEntityData :
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public LinearTransform In { get; set; } = new();

		[ContainerField(80), JsonProperty(Order = 80)]
		public Realm Realm { get; set; } = new();

		[ContainerField(84), JsonProperty(Order = 84)]
		public ModifierAxis Left { get; set; } = new();

		[ContainerField(88), JsonProperty(Order = 88)]
		public ModifierAxis Up { get; set; } = new();

		[ContainerField(92), JsonProperty(Order = 92)]
		public ModifierAxis Forward { get; set; } = new();

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public bool InvertLeft { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
		public bool InvertUp { get; set; }

		[ContainerField(98), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
		public bool InvertForward { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			In.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Realm);
			p_Writer.Write((int) Left);
			p_Writer.Write((int) Up);
			p_Writer.Write((int) Forward);
			p_Writer.Write(InvertLeft);
			p_Writer.Write(InvertUp);
			p_Writer.Write(InvertForward);
			p_Writer.WriteNullBytes(13);
		}
	}
}
