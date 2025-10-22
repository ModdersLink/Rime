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

namespace fb.Emitter;

[ContainerType(8, 40)]
public class EmitterSystemComponent
	: fb.Entity.SubWorldDataComponent
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint ExclusionVolumesCount { get; set; } = 0;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<EmitterExclusionVolume> ExclusionVolumes { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<EmitterExclusionVolumeBoundingSphereSoA> ExclusionVolumeBoundingSpheres { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ExclusionVolumesCount);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ExclusionVolumes = p_EbxWriter.GetArrayWriter(ExclusionVolumes.GetType(), ExclusionVolumes.Count);
		p_Writer.Write(s_ExclusionVolumes.ArrayIndex);
		foreach (var s_Entry in ExclusionVolumes)
		{
			s_Entry.Serialize(s_ExclusionVolumes.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ExclusionVolumeBoundingSpheres = p_EbxWriter.GetArrayWriter(ExclusionVolumeBoundingSpheres.GetType(), ExclusionVolumeBoundingSpheres.Count);
		p_Writer.Write(s_ExclusionVolumeBoundingSpheres.ArrayIndex);
		foreach (var s_Entry in ExclusionVolumeBoundingSpheres)
		{
			s_Entry.Serialize(s_ExclusionVolumeBoundingSpheres.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

