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

[ContainerType(16, 128)]
public class VisualEnvironmentComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public List<string> PropertyOverrides { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public List<uint> PropertyOverrideMasks { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_PropertyOverrides = p_EbxWriter.GetArrayWriter(PropertyOverrides.GetType(), PropertyOverrides.Count);
		p_Writer.Write(s_PropertyOverrides.ArrayIndex);
		foreach (var s_Entry in PropertyOverrides)
		{
			s_PropertyOverrides.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PropertyOverrideMasks = p_EbxWriter.GetArrayWriter(PropertyOverrideMasks.GetType(), PropertyOverrideMasks.Count);
		p_Writer.Write(s_PropertyOverrideMasks.ArrayIndex);
		foreach (var s_Entry in PropertyOverrideMasks)
		{
			s_PropertyOverrideMasks.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
	}
}

