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
	[ContainerType(4, 168)]
	public class UIInteractionCompData :
		UI3dIconCompData
	{
		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float RepairSnapDistance { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public bool RepairSnapCircle { get; set; }

		[ContainerField(165), LayoutImmutable, Blittable, JsonProperty(Order = 165)]
		public bool PickupShrinkSnap { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(RepairSnapDistance);
			p_Writer.Write(RepairSnapCircle);
			p_Writer.Write(PickupShrinkSnap);
			p_Writer.WriteNullBytes(2);
		}
	}
}
