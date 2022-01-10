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
	[ContainerType(4, 32)]
	public class UIDetailedServerInfoCompData : 
		UIComponentData
	{
		[ContainerField(28)]
		public List<ServerInfoSetting> Settings { get; set; } = new();

		public static void Deserialize(UIDetailedServerInfoCompData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Settings.Clear();
			(RimeReader Reader, uint Count) s_Settings = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Settings.Count; ++i)
			{
				var s_Value = new ServerInfoSetting();
				fb.ServerInfoSetting.Deserialize(s_Value, s_Settings.Reader, p_Parser);
				p_Instance.Settings.Add(s_Value);
			}
			
			s_Settings.Reader.Dispose();
		}

	}
}
