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
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 304)]
public class UIElementButtonEntityData
	: fb.GameShared.UIElementEntityData
{
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<UIElementButtonStyle> Style { get; set; } = new();
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public UIElementText Text { get; set; } = new();
	
	[ContainerField(0xf8), JsonProperty(Order = 248)]
	public CtrRef<UIElementTrigger> Action { get; set; } = new();
	
	[ContainerField(0x100), JsonProperty(Order = 256)]
	public CtrRef<UIElementTrigger> ActionGotFocus { get; set; } = new();
	
	[ContainerField(0x108), JsonProperty(Order = 264)]
	public CtrRef<UIElementTrigger> ActionLostFocus { get; set; } = new();
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public UIInputAction KeyboardShortcut { get; set; } = UIInputAction.UIInputAction_None;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public string EnabledProperty { get; set; } = string.Empty;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public bool UseAutoScroll { get; set; } = false;
	
	[ContainerField(0x121), LayoutImmutable, Blittable, JsonProperty(Order = 289)]
	public bool Enabled { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Style));
		p_Writer.WriteNullBytes(4);
		Text.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Action));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ActionGotFocus));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ActionLostFocus));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) KeyboardShortcut);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(EnabledProperty));
		p_Writer.Write(UseAutoScroll);
		p_Writer.Write(Enabled);
		p_Writer.WriteNullBytes(14);
	}
}

