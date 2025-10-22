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
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 272)]
public class UIElementCustomEntityData
	: fb.GameShared.UIElementEntityData
{
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<UIElementGenericStyle> Style { get; set; } = new();
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public UIElementText Text { get; set; } = new();
	
	[ContainerField(0xf8), JsonProperty(Order = 248)]
	public CtrRef<UIElementFontStyle> FontStyle { get; set; } = new();
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public string TextureId { get; set; } = string.Empty;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Style));
		p_Writer.WriteNullBytes(4);
		Text.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(FontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(TextureId));
		p_Writer.WriteNullBytes(8);
	}
}

