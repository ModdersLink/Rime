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

namespace fb.GameShared;

[ContainerType(8, 56)]
public class RichPresenceContext
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string Name { get; set; } = string.Empty;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public RefArray<RichPresenceContextValue> Values { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<RichPresenceContextValue> DefaultValue { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string StatCode { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public byte Index { get; set; } = 0;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(Name));
		(RimeWriter Writer, uint ArrayIndex) s_Values = p_EbxWriter.GetArrayWriter(Values.GetType(), Values.Count);
		p_Writer.Write(s_Values.ArrayIndex);
		foreach (var s_Entry in Values)
		{
			s_Values.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DefaultValue));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(StatCode));
		p_Writer.Write(Index);
		p_Writer.WriteNullBytes(7);
	}
}

