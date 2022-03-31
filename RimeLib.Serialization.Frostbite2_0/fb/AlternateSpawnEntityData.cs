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
	[ContainerType(16, 96)]
	public class AlternateSpawnEntityData :
		SpatialEntityData
	{
		[ContainerField(80), JsonProperty(Order = 80)]
		public TeamId Team { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float Priority { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public bool Enabled { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Team);
			p_Writer.Write(Priority);
			p_Writer.Write(Enabled);
			p_Writer.WriteNullBytes(7);
		}
	}
}
