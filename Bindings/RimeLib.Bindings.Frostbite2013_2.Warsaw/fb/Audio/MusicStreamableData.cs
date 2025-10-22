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

namespace fb.Audio;

[ContainerType(8, 80)]
public class MusicStreamableData
	: fb.Audio.MusicPlayableData
{
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float RangeValue { get; set; } = 0.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public int Weight { get; set; } = 0;
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public CtrRef<MusicStreamableData> NextPlayable { get; set; } = new();
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public bool AllowRangeFade { get; set; } = true;
	
	[ContainerField(0x49), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
	public bool ResumePrevious { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RangeValue);
		p_Writer.Write(Weight);
		p_Writer.Write(p_EbxWriter.WriteImport(NextPlayable));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AllowRangeFade);
		p_Writer.Write(ResumePrevious);
		p_Writer.WriteNullBytes(6);
	}
}

