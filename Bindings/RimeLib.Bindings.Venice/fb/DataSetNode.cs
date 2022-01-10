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
	[ContainerType(4, 52)]
	public class DataSetNode : 
		UINodeData
	{
		[ContainerField(20)]
		public CtrRef<UINodePort> In { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<UINodePort> Out { get; set; } = new();

		[ContainerField(28), LayoutImmutable]
		public string Param { get; set; } = string.Empty;

		[ContainerField(32)]
		public UIDataSourceInfo DataSource { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable]
		public bool SetToEmptyString { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable]
		public bool ForceUpdate { get; set; }

		public static void Deserialize(DataSetNode p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.In.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Out.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Param = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			fb.UIDataSourceInfo.Deserialize(p_Instance.DataSource, p_Reader, p_Parser);
			p_Instance.SetToEmptyString = p_Reader.ReadBool();
			p_Instance.ForceUpdate = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
