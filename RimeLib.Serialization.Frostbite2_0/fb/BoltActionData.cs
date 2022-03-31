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
	public class BoltActionData :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public float BoltActionDelay { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public float BoltActionTime { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public bool HoldBoltActionUntilFireRelease { get; set; }
		
		[ContainerField(9), LayoutImmutable, Blittable, JsonProperty(Order = 9)]
		public bool HoldBoltActionUntilZoomRelease { get; set; }
		
		[ContainerField(10), LayoutImmutable, Blittable, JsonProperty(Order = 10)]
		public bool ForceBoltActionOnFireTrigger { get; set; }
		
		[ContainerField(11), LayoutImmutable, Blittable, JsonProperty(Order = 11)]
		public bool UnZoomOnBoltAction { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public bool ReturnToZoomAfterBoltAction { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(BoltActionDelay);
			p_Writer.Write(BoltActionTime);
			p_Writer.Write(HoldBoltActionUntilFireRelease);
			p_Writer.Write(HoldBoltActionUntilZoomRelease);
			p_Writer.Write(ForceBoltActionOnFireTrigger);
			p_Writer.Write(UnZoomOnBoltAction);
			p_Writer.Write(ReturnToZoomAfterBoltAction);
			p_Writer.WriteNullBytes(3);
		}
	}
}
