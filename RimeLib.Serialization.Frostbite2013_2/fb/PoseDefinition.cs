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

namespace fb.GameShared;

[ContainerType(8, 48)]
public class PoseDefinition
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AntRef Animation { get; set; } = new();
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float AnimationDuration { get; set; } = 0.000f;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<PoseTransitionBase> Transitions { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Animation.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AnimationDuration);
		(RimeWriter Writer, uint ArrayIndex) s_Transitions = p_EbxWriter.GetArrayWriter(Transitions.GetType(), Transitions.Count);
		p_Writer.Write(s_Transitions.ArrayIndex);
		foreach (var s_Entry in Transitions)
		{
			s_Transitions.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

