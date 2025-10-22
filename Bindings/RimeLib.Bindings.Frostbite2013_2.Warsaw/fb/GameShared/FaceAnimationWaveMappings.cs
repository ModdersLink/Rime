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

using fb.Ant;
using fb.Core;

namespace fb.GameShared;

[ContainerType(8, 64)]
public class FaceAnimationWaveMappings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AntRef AntAsset { get; set; } = new();
	
	[ContainerField(0x24), JsonProperty(Order = 36)]
	public AntRef OnStartedTalking { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<FaceAnimationWaveMapping> Mappings { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		AntAsset.Serialize(p_Writer, p_EbxWriter);
		OnStartedTalking.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Mappings = p_EbxWriter.GetArrayWriter(Mappings.GetType(), Mappings.Count);
		p_Writer.Write(s_Mappings.ArrayIndex);
		foreach (var s_Entry in Mappings)
		{
			s_Entry.Serialize(s_Mappings.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

