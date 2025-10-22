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

[ContainerType(16, 240)]
public class UIBattlepacksMenuWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<UIWidgetBlueprint> BattlepackStepperCellTemplate { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<UIWidgetBlueprint> StoreStepperCellTemplate { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public UIElementColor LabelColor { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public UIElementColor LabelSelectedColor { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public CtrRef<UIElementFillData> StepperBackgroundNormalFill { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public CtrRef<UIElementFillData> StepperBackgroundSelectedFill { get; set; } = new();
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<UIElementFillData> StepperEmptyFill { get; set; } = new();
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public CtrRef<UIElementFillData> LabelSelectedFill { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public CtrRef<UIElementButtonStyle> StepperOpenButtonStyle { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(BattlepackStepperCellTemplate));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(StoreStepperCellTemplate));
		p_Writer.WriteNullBytes(12);
		LabelColor.Serialize(p_Writer, p_EbxWriter);
		LabelSelectedColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(StepperBackgroundNormalFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(StepperBackgroundSelectedFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(StepperEmptyFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(LabelSelectedFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(StepperOpenButtonStyle));
		p_Writer.WriteNullBytes(12);
	}
}

