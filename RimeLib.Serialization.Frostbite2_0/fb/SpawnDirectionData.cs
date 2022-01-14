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
	[ContainerType(16, 64)]
	public class SpawnDirectionData :
		ProcessorData
	{
		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float DirectionFromEmitterOrigin { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public bool InheritSpeedAndDirectionFromEmitter { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(DirectionFromEmitterOrigin);
			p_Writer.Write(InheritSpeedAndDirectionFromEmitter);
			p_Writer.WriteNullBytes(11);
		}
	}
}
