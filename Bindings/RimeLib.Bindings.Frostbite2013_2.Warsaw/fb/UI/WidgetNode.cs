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

[ContainerType(8, 112)]
public class WidgetNode
	: fb.UI.UINodeData
{
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<UIWidgetAsset> WidgetAsset { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public int FocusIndex { get; set; } = 0;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public WidgetVerticalAlignment VerticalAlign { get; set; } = WidgetVerticalAlignment.WVA_Center;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public WidgetHorisontalAlignment HorisontalAlign { get; set; } = WidgetHorisontalAlignment.WHA_Center;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public int ZDepthLevel { get; set; } = 0;
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public CtrRef<UIDataBinding> DataBinding { get; set; } = new();
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string InstanceName { get; set; } = string.Empty;
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public List<UIWidgetProperty> WidgetProperties { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public RefArray<UINodePort> Outputs { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public RefArray<UINodePort> Inputs { get; set; } = new();
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public bool AlwaysInFocus { get; set; } = false;
	
	[ContainerField(0x69), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
	public bool IsDisabled { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(WidgetAsset));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(FocusIndex);
		p_Writer.Write((int) VerticalAlign);
		p_Writer.Write((int) HorisontalAlign);
		p_Writer.Write(ZDepthLevel);
		p_Writer.Write(p_EbxWriter.WriteImport(DataBinding));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(InstanceName));
		(RimeWriter Writer, uint ArrayIndex) s_WidgetProperties = p_EbxWriter.GetArrayWriter(WidgetProperties.GetType(), WidgetProperties.Count);
		p_Writer.Write(s_WidgetProperties.ArrayIndex);
		foreach (var s_Entry in WidgetProperties)
		{
			s_Entry.Serialize(s_WidgetProperties.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Outputs = p_EbxWriter.GetArrayWriter(Outputs.GetType(), Outputs.Count);
		p_Writer.Write(s_Outputs.ArrayIndex);
		foreach (var s_Entry in Outputs)
		{
			s_Outputs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Inputs = p_EbxWriter.GetArrayWriter(Inputs.GetType(), Inputs.Count);
		p_Writer.Write(s_Inputs.ArrayIndex);
		foreach (var s_Entry in Inputs)
		{
			s_Inputs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AlwaysInFocus);
		p_Writer.Write(IsDisabled);
		p_Writer.WriteNullBytes(6);
	}
}

