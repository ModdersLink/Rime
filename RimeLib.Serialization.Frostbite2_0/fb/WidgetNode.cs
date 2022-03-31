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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 64)]
	public class WidgetNode :
		UINodeData
	{
		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<UIWidgetAsset> WidgetAsset { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public int FocusIndex { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public int ZDepthLevel { get; set; }

		[ContainerField(32), JsonProperty(Order = 32)]
		public WidgetVerticalAlignment VerticalAlign { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public WidgetHorisontalAlignment HorisontalAlign { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public CtrRef<UIDataBinding> DataBinding { get; set; } = new();

		[ContainerField(44), JsonProperty(Order = 44)]
		public List<UIWidgetProperty> WidgetProperties { get; set; } = new();

		[ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		public string InstanceName { get; set; } = string.Empty;

		[ContainerField(52), JsonProperty(Order = 52)]
		public RefArray<UINodePort> Inputs { get; set; } = new();

		[ContainerField(56), JsonProperty(Order = 56)]
		public RefArray<UINodePort> Outputs { get; set; } = new();

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public bool AlwaysInFocus { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(WidgetAsset));
			p_Writer.Write(FocusIndex);
			p_Writer.Write(ZDepthLevel);
			p_Writer.Write((int) VerticalAlign);
			p_Writer.Write((int) HorisontalAlign);
			p_Writer.Write(p_EbxWriter.WriteImport(DataBinding));
			(RimeWriter Writer, uint ArrayIndex) s_WidgetProperties = p_EbxWriter.GetArrayWriter(WidgetProperties.GetType(), WidgetProperties.Count);
			p_Writer.Write(s_WidgetProperties.ArrayIndex);
			foreach (var s_Entry in WidgetProperties)
			{
				s_Entry.Serialize(s_WidgetProperties.Writer, p_EbxWriter);
			}
			p_Writer.Write(p_EbxWriter.WriteString(InstanceName));
			(RimeWriter Writer, uint ArrayIndex) s_Inputs = p_EbxWriter.GetArrayWriter(Inputs.GetType(), Inputs.Count);
			p_Writer.Write(s_Inputs.ArrayIndex);
			foreach (var s_Entry in Inputs)
			{
				s_Inputs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Outputs = p_EbxWriter.GetArrayWriter(Outputs.GetType(), Outputs.Count);
			p_Writer.Write(s_Outputs.ArrayIndex);
			foreach (var s_Entry in Outputs)
			{
				s_Outputs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(AlwaysInFocus);
			p_Writer.WriteNullBytes(3);
		}
	}
}
