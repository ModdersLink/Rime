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
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 56)]
public class FadeTrackData
	: fb.Entity.TimelineTrackData
{
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<FadeTrackKeyframe> Keyframes { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool FadeScreen { get; set; } = true;
	
	[ContainerField(0x31), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
	public bool FadeUI { get; set; } = false;
	
	[ContainerField(0x32), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
	public bool FadeAudio { get; set; } = false;
	
	[ContainerField(0x33), LayoutImmutable, Blittable, JsonProperty(Order = 51)]
	public bool FadeMovie { get; set; } = false;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public bool FadeRumble { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Keyframes = p_EbxWriter.GetArrayWriter(Keyframes.GetType(), Keyframes.Count);
		p_Writer.Write(s_Keyframes.ArrayIndex);
		foreach (var s_Entry in Keyframes)
		{
			s_Keyframes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(FadeScreen);
		p_Writer.Write(FadeUI);
		p_Writer.Write(FadeAudio);
		p_Writer.Write(FadeMovie);
		p_Writer.Write(FadeRumble);
		p_Writer.WriteNullBytes(3);
	}
}

