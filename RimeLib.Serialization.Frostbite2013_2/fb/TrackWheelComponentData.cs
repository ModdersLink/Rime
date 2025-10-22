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

using fb.Core;
using fb.Physics;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 144)]
public class TrackWheelComponentData
	: fb.GameShared.WheelComponentData
{
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public string BoneName { get; set; } = string.Empty;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(BoneName));
		p_Writer.WriteNullBytes(8);
	}
}

