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
using fb.UI;

namespace fb.VeniceShared;

[ContainerType(8, 80)]
public class UITextDataBinding
	: fb.UI.UIDataBinding
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string StaticText { get; set; } = string.Empty;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public UIDataSourceInfo TextData { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public UIDataSourceInfo Visibility { get; set; } = new();
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public bool Refresh { get; set; } = true;
	
	[ContainerField(0x49), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
	public bool OverrideDirectAccess { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(StaticText));
		TextData.Serialize(p_Writer, p_EbxWriter);
		Visibility.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Refresh);
		p_Writer.Write(OverrideDirectAccess);
		p_Writer.WriteNullBytes(6);
	}
}

