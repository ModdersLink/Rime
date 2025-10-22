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
using fb.Ant;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 80)]
public class ANTBoolTrackData
	: fb.Entity.BoolTrackData
{
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public AntRef Signal { get; set; } = new();
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public bool ResetOnLeave { get; set; } = true;
	
	[ContainerField(0x4d), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
	public bool ResetValue { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Signal.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ResetOnLeave);
		p_Writer.Write(ResetValue);
		p_Writer.WriteNullBytes(2);
	}
}

