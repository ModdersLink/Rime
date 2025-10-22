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

[ContainerType(16, 256)]
public class UIElementEditBoxEntityData
	: fb.GameShared.UIElementEntityData
{
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<UIElementEditBoxStyle> Style { get; set; } = new();
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public UIDataSource DataSource { get; set; } = new();
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public CtrRef<UIElementTrigger> OnEnteredText { get; set; } = new();
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public uint MaxTextLength { get; set; } = 256;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public bool PasswordMaskingEnabled { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Style));
		p_Writer.WriteNullBytes(4);
		DataSource.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(OnEnteredText));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MaxTextLength);
		p_Writer.Write(PasswordMaskingEnabled);
		p_Writer.WriteNullBytes(3);
	}
}

