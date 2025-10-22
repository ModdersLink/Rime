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

[ContainerType(8, 32)]
public class SubWorldInclusionSetting
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<SubWorldInclusionCriterion> Criterion { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<string> EnabledOptions { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Criterion));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_EnabledOptions = p_EbxWriter.GetArrayWriter(EnabledOptions.GetType(), EnabledOptions.Count);
		p_Writer.Write(s_EnabledOptions.ArrayIndex);
		foreach (var s_Entry in EnabledOptions)
		{
			s_EnabledOptions.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

