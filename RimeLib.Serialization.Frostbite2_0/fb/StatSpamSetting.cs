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
	[ContainerType(4, 16)]
	public class StatSpamSetting :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public StatEvent Event { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public uint AmountLimit { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float TimeLimit { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public bool PlayerToPlayer { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Event);
			p_Writer.Write(AmountLimit);
			p_Writer.Write(TimeLimit);
			p_Writer.Write(PlayerToPlayer);
			p_Writer.WriteNullBytes(3);
		}
	}
}
