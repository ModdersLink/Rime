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
	[ContainerType(4, 32)]
	public class FriendZoneEntityData :
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public int EnemyWeight { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public int FriendlyWeight { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public int CorpsTimeout { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public int CorpsWeight { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public bool CountCorpsesForAllTeams { get; set; }

		[ContainerField(29), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
		public bool InitialZoneRandomized { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(EnemyWeight);
			p_Writer.Write(FriendlyWeight);
			p_Writer.Write(CorpsTimeout);
			p_Writer.Write(CorpsWeight);
			p_Writer.Write(CountCorpsesForAllTeams);
			p_Writer.Write(InitialZoneRandomized);
			p_Writer.WriteNullBytes(2);
		}
	}
}
