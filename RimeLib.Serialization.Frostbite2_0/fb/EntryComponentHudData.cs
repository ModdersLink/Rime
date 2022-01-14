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
	[ContainerType(4, 12)]
	public class EntryComponentHudData :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public int Index { get; set; }
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public EntrySeatType SeatType { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public bool Frustum { get; set; }
		
		[ContainerField(9), LayoutImmutable, Blittable, JsonProperty(Order = 9)]
		public bool Visible { get; set; }
		
		[ContainerField(10), LayoutImmutable, Blittable, JsonProperty(Order = 10)]
		public bool MaximizeMiniMapOnEntry { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Index);
			p_Writer.Write((int) SeatType);
			p_Writer.Write(Frustum);
			p_Writer.Write(Visible);
			p_Writer.Write(MaximizeMiniMapOnEntry);
			p_Writer.WriteNullBytes(1);
		}
	}
}
