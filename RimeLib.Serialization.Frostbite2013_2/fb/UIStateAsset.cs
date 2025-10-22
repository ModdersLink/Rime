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

namespace fb.UI;

[ContainerType(8, 56)]
public class UIStateAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public RefArray<UIComponentData> UIComponents { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<string> ActionscriptNames { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string StateName { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string StatePath { get; set; } = string.Empty;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_UIComponents = p_EbxWriter.GetArrayWriter(UIComponents.GetType(), UIComponents.Count);
		p_Writer.Write(s_UIComponents.ArrayIndex);
		foreach (var s_Entry in UIComponents)
		{
			s_UIComponents.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ActionscriptNames = p_EbxWriter.GetArrayWriter(ActionscriptNames.GetType(), ActionscriptNames.Count);
		p_Writer.Write(s_ActionscriptNames.ArrayIndex);
		foreach (var s_Entry in ActionscriptNames)
		{
			s_ActionscriptNames.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(StateName));
		p_Writer.Write(p_EbxWriter.WriteString(StatePath));
	}
}

