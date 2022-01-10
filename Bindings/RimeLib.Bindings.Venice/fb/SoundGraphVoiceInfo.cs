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
	[ContainerType(4, 8)]
	public class SoundGraphVoiceInfo
	{
		[ContainerField(0)]
		public List<SoundGraphPluginInfo> Plugins { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public sbyte ProcessingStage { get; set; }
		
		public static void Deserialize(SoundGraphVoiceInfo p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Plugins.Clear();
			(RimeReader Reader, uint Count) s_Plugins = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Plugins.Count; ++i)
			{
				var s_Value = new SoundGraphPluginInfo();
				fb.SoundGraphPluginInfo.Deserialize(s_Value, s_Plugins.Reader, p_Parser);
				p_Instance.Plugins.Add(s_Value);
			}
			
			s_Plugins.Reader.Dispose();
			p_Instance.ProcessingStage = p_Reader.ReadSByte();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
