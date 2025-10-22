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

using fb.GameShared;
using fb.Core;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(16, 272)]
public class UIIngameBoostsWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<UIElementButtonStyle> MenuButtonStyle { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<UIElementFillData> FocusedFill { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public UIElementColor DefaultBoostArrowColor { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public UIElementColor ActiveBoostArrowColor { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public UIElementColor ActiveBoostTextHighlightColor { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public UIElementColor ActiveBoostTextDefaultColor { get; set; } = new();
	
	[ContainerField(0x100), JsonProperty(Order = 256)]
	public CtrRef<UIElementFillData> UnfocusedFill { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(MenuButtonStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FocusedFill));
		p_Writer.WriteNullBytes(12);
		DefaultBoostArrowColor.Serialize(p_Writer, p_EbxWriter);
		ActiveBoostArrowColor.Serialize(p_Writer, p_EbxWriter);
		ActiveBoostTextHighlightColor.Serialize(p_Writer, p_EbxWriter);
		ActiveBoostTextDefaultColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(UnfocusedFill));
		p_Writer.WriteNullBytes(12);
	}
}

