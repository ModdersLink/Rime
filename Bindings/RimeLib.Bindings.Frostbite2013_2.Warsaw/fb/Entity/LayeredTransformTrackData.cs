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

namespace fb.Entity;

[ContainerType(8, 64)]
public class LayeredTransformTrackData
	: fb.Entity.PropertyTrackBaseData
{
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public RefArray<TransformLayerData> LayerTracks { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public int TimelineOriginPinId { get; set; } = 0;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_LayerTracks = p_EbxWriter.GetArrayWriter(LayerTracks.GetType(), LayerTracks.Count);
		p_Writer.Write(s_LayerTracks.ArrayIndex);
		foreach (var s_Entry in LayerTracks)
		{
			s_LayerTracks.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(TimelineOriginPinId);
		p_Writer.WriteNullBytes(4);
	}
}

