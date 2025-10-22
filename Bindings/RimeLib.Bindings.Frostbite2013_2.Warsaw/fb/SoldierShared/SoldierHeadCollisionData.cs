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

namespace fb.SoldierShared;

[ContainerType(8, 32)]
public class SoldierHeadCollisionData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float HeadRadius { get; set; } = 0.200f;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<SoldierHeadCollisionPoseData> PoseStates { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(HeadRadius);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PoseStates = p_EbxWriter.GetArrayWriter(PoseStates.GetType(), PoseStates.Count);
		p_Writer.Write(s_PoseStates.ArrayIndex);
		foreach (var s_Entry in PoseStates)
		{
			s_Entry.Serialize(s_PoseStates.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

