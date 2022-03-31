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
	[ContainerType(4, 40)]
	public class AnimationSignalEntityData :
		EntityData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public AntRef Signal { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public AntRef IntGameState { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public AntRef FloatGameState { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public int ValueInt { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float ValueFloat { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public bool Reset { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		public bool Continuous { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Realm);
			Signal.Serialize(p_Writer, p_EbxWriter);
			IntGameState.Serialize(p_Writer, p_EbxWriter);
			FloatGameState.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ValueInt);
			p_Writer.Write(ValueFloat);
			p_Writer.Write(Reset);
			p_Writer.Write(Continuous);
			p_Writer.WriteNullBytes(2);
		}
	}
}
