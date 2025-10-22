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

[ContainerType(8, 72)]
public class EntitlementQuery
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<EntitlementData> EntitlementsData { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<string> GroupNames { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public GamePlatform Platform { get; set; } = GamePlatform.GamePlatform_Invalid;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string EntitlementTag { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string ProductId { get; set; } = string.Empty;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string ProjectId { get; set; } = string.Empty;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_EntitlementsData = p_EbxWriter.GetArrayWriter(EntitlementsData.GetType(), EntitlementsData.Count);
		p_Writer.Write(s_EntitlementsData.ArrayIndex);
		foreach (var s_Entry in EntitlementsData)
		{
			s_Entry.Serialize(s_EntitlementsData.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_GroupNames = p_EbxWriter.GetArrayWriter(GroupNames.GetType(), GroupNames.Count);
		p_Writer.Write(s_GroupNames.ArrayIndex);
		foreach (var s_Entry in GroupNames)
		{
			s_GroupNames.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) Platform);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(EntitlementTag));
		p_Writer.Write(p_EbxWriter.WriteString(ProductId));
		p_Writer.Write(p_EbxWriter.WriteString(ProjectId));
	}
}

