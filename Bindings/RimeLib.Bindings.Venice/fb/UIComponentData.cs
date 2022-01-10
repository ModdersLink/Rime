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
	[ContainerType(4, 28)]
	public class UIComponentData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string ShortName { get; set; } = string.Empty;

		[ContainerField(16)]
		public List<string> DataSources { get; set; } = new();

		[ContainerField(20)]
		public UIUpdateType UpdateType { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public int UpdatesPerSecond { get; set; }

		public static void Deserialize(UIComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ShortName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.DataSources.Clear();
			(RimeReader Reader, uint Count) s_DataSources = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_DataSources.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_DataSources.Reader.ReadUInt32());
				p_Instance.DataSources.Add(s_Value);
			}
			
			s_DataSources.Reader.Dispose();
			p_Instance.UpdateType = (UIUpdateType) p_Reader.ReadInt32();
			p_Instance.UpdatesPerSecond = p_Reader.ReadInt32();
		}

	}
}
