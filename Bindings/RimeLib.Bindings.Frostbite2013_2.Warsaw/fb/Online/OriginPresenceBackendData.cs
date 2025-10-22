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

namespace fb.Online;

[ContainerType(8, 48)]
public class OriginPresenceBackendData
	: fb.Online.PresenceBackendData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<string> CommerceCategories { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int Timeout { get; set; } = 10000;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public OriginPartyType PartyType { get; set; } = OriginPartyType.OriginPartyType_Public;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool PartySupportEnabled { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_CommerceCategories = p_EbxWriter.GetArrayWriter(CommerceCategories.GetType(), CommerceCategories.Count);
		p_Writer.Write(s_CommerceCategories.ArrayIndex);
		foreach (var s_Entry in CommerceCategories)
		{
			s_CommerceCategories.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Timeout);
		p_Writer.Write((int) PartyType);
		p_Writer.Write(PartySupportEnabled);
		p_Writer.WriteNullBytes(7);
	}
}

