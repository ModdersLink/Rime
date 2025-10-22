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

[ContainerType(8, 80)]
public class ANTControlTrackData
	: fb.Entity.LinkTrackData
{
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public RefArray<ANTLayerData> LayerTracks { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<int> SkipToEndBones { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public List<LinearTransform> SkipToEndTransforms { get; set; } = new();
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public bool HideWhenNoClip { get; set; } = false;
	
	[ContainerField(0x49), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
	public bool DisableInterpolationBetweenClips { get; set; } = false;
	
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
		(RimeWriter Writer, uint ArrayIndex) s_SkipToEndBones = p_EbxWriter.GetArrayWriter(SkipToEndBones.GetType(), SkipToEndBones.Count);
		p_Writer.Write(s_SkipToEndBones.ArrayIndex);
		foreach (var s_Entry in SkipToEndBones)
		{
			s_SkipToEndBones.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_SkipToEndTransforms = p_EbxWriter.GetArrayWriter(SkipToEndTransforms.GetType(), SkipToEndTransforms.Count);
		p_Writer.Write(s_SkipToEndTransforms.ArrayIndex);
		foreach (var s_Entry in SkipToEndTransforms)
		{
			s_Entry.Serialize(s_SkipToEndTransforms.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(HideWhenNoClip);
		p_Writer.Write(DisableInterpolationBetweenClips);
		p_Writer.WriteNullBytes(6);
	}
}

