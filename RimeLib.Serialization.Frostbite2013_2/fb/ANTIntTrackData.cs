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

[ContainerType(8, 88)]
public class ANTIntTrackData
	: fb.Entity.IntTrackData
{
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public AntRef Signal { get; set; } = new();
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public int ResetValue { get; set; } = 0;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool ResetOnLeave { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Signal.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ResetValue);
		p_Writer.Write(ResetOnLeave);
		p_Writer.WriteNullBytes(7);
	}
}

