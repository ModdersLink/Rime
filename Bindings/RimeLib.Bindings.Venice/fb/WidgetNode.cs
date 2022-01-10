///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 64)]
	public class WidgetNode : 
		UINodeData
	{
		[ContainerField(20)]
		public CtrRef<UIWidgetAsset> WidgetAsset { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public int FocusIndex { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public int ZDepthLevel { get; set; }

		[ContainerField(32)]
		public WidgetVerticalAlignment VerticalAlign { get; set; } = new();

		[ContainerField(36)]
		public WidgetHorisontalAlignment HorisontalAlign { get; set; } = new();

		[ContainerField(40)]
		public CtrRef<UIDataBinding> DataBinding { get; set; } = new();

		[ContainerField(44)]
		public List<UIWidgetProperty> WidgetProperties { get; set; } = new();

		[ContainerField(48), LayoutImmutable]
		public string InstanceName { get; set; } = string.Empty;

		[ContainerField(52)]
		public List<CtrRef<UINodePort>> Inputs { get; set; } = new();

		[ContainerField(56)]
		public List<CtrRef<UINodePort>> Outputs { get; set; } = new();

		[ContainerField(60), LayoutImmutable, Blittable]
		public bool AlwaysInFocus { get; set; }

		public static void Deserialize(WidgetNode p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.WidgetAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.FocusIndex = p_Reader.ReadInt32();
			p_Instance.ZDepthLevel = p_Reader.ReadInt32();
			p_Instance.VerticalAlign = (WidgetVerticalAlignment) p_Reader.ReadInt32();
			p_Instance.HorisontalAlign = (WidgetHorisontalAlignment) p_Reader.ReadInt32();
			p_Instance.DataBinding.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.WidgetProperties.Clear();
			(RimeReader Reader, uint Count) s_WidgetProperties = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_WidgetProperties.Count; ++i)
			{
				var s_Value = new UIWidgetProperty();
				fb.UIWidgetProperty.Deserialize(s_Value, s_WidgetProperties.Reader, p_Parser);
				p_Instance.WidgetProperties.Add(s_Value);
			}
			
			s_WidgetProperties.Reader.Dispose();
			p_Instance.InstanceName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Inputs.Clear();
			(RimeReader Reader, uint Count) s_Inputs = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Inputs.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UINodePort>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Inputs.Reader.ReadUInt32()));
				p_Instance.Inputs.Add(s_CtrRef);
			}
			
			s_Inputs.Reader.Dispose();
			p_Instance.Outputs.Clear();
			(RimeReader Reader, uint Count) s_Outputs = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Outputs.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UINodePort>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Outputs.Reader.ReadUInt32()));
				p_Instance.Outputs.Add(s_CtrRef);
			}
			
			s_Outputs.Reader.Dispose();
			p_Instance.AlwaysInFocus = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
