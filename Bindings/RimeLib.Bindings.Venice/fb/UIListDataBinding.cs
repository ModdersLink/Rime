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
	[ContainerType(4, 104)]
	public class UIListDataBinding : 
		UIDataBinding
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int ListIndex { get; set; }

		[ContainerField(12)]
		public UIDataSourceInfo ListQuery { get; set; } = new();

		[ContainerField(28)]
		public List<StaticListItem> StaticItems { get; set; } = new();

		[ContainerField(32)]
		public UIListEmptyRowType EmptyRowType { get; set; } = new();

		[ContainerField(36)]
		public DefaultSelectionItem DefaultHighlightedRow { get; set; } = new();

		[ContainerField(56)]
		public UIListRowType RowType { get; set; } = new();

		[ContainerField(60)]
		public UIListNavigationType NavigationType { get; set; } = new();

		[ContainerField(64)]
		public UIDataSourceInfo NavigationTypeSource { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable]
		public int RowSpacing { get; set; }

		[ContainerField(84)]
		public UIListUnFocusMode UnFocusMode { get; set; } = new();

		[ContainerField(88), LayoutImmutable]
		public string DisabledRows { get; set; } = string.Empty;

		[ContainerField(92), LayoutImmutable, Blittable]
		public bool ClearListAtNavigationEvent { get; set; }

		[ContainerField(93), LayoutImmutable, Blittable]
		public bool SendIndexWithEvent { get; set; }

		[ContainerField(94), LayoutImmutable, Blittable]
		public bool ScreenRotationEnabled { get; set; }

		[ContainerField(95), LayoutImmutable, Blittable]
		public bool Use3DSelection { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public bool FireHighlightOnMouseOut { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable]
		public bool DataIncludesButtonLayout { get; set; }

		[ContainerField(98), LayoutImmutable, Blittable]
		public bool Visible { get; set; }

		[ContainerField(99), LayoutImmutable, Blittable]
		public bool SpinnerEnabled { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public bool UseScrollBar { get; set; }

		[ContainerField(101), LayoutImmutable, Blittable]
		public bool HighLightOnUpdate { get; set; }

		[ContainerField(102), LayoutImmutable, Blittable]
		public bool KeepScrollOffset { get; set; }

		public static void Deserialize(UIListDataBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ListIndex = p_Reader.ReadInt32();
			fb.UIDataSourceInfo.Deserialize(p_Instance.ListQuery, p_Reader, p_Parser);
			p_Instance.StaticItems.Clear();
			(RimeReader Reader, uint Count) s_StaticItems = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_StaticItems.Count; ++i)
			{
				var s_Value = new StaticListItem();
				fb.StaticListItem.Deserialize(s_Value, s_StaticItems.Reader, p_Parser);
				p_Instance.StaticItems.Add(s_Value);
			}
			
			s_StaticItems.Reader.Dispose();
			p_Instance.EmptyRowType = (UIListEmptyRowType) p_Reader.ReadInt32();
			fb.DefaultSelectionItem.Deserialize(p_Instance.DefaultHighlightedRow, p_Reader, p_Parser);
			p_Instance.RowType = (UIListRowType) p_Reader.ReadInt32();
			p_Instance.NavigationType = (UIListNavigationType) p_Reader.ReadInt32();
			fb.UIDataSourceInfo.Deserialize(p_Instance.NavigationTypeSource, p_Reader, p_Parser);
			p_Instance.RowSpacing = p_Reader.ReadInt32();
			p_Instance.UnFocusMode = (UIListUnFocusMode) p_Reader.ReadInt32();
			p_Instance.DisabledRows = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ClearListAtNavigationEvent = p_Reader.ReadBool();
			p_Instance.SendIndexWithEvent = p_Reader.ReadBool();
			p_Instance.ScreenRotationEnabled = p_Reader.ReadBool();
			p_Instance.Use3DSelection = p_Reader.ReadBool();
			p_Instance.FireHighlightOnMouseOut = p_Reader.ReadBool();
			p_Instance.DataIncludesButtonLayout = p_Reader.ReadBool();
			p_Instance.Visible = p_Reader.ReadBool();
			p_Instance.SpinnerEnabled = p_Reader.ReadBool();
			p_Instance.UseScrollBar = p_Reader.ReadBool();
			p_Instance.HighLightOnUpdate = p_Reader.ReadBool();
			p_Instance.KeepScrollOffset = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
