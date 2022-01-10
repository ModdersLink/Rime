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
	[ContainerType(4, 48)]
	public class ChatSettings : 
		Asset
	{
		[ContainerField(12)]
		public List<ChatChannelType> Channels { get; set; } = new();

		[ContainerField(16)]
		public AntiSpamConfig AntiSpam { get; set; } = new();

		public static void Deserialize(ChatSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Channels.Clear();
			(RimeReader Reader, uint Count) s_Channels = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Channels.Count; ++i)
			{
				var s_Value = (ChatChannelType) s_Channels.Reader.ReadInt32();
				p_Instance.Channels.Add(s_Value);
			}
			
			s_Channels.Reader.Dispose();
			fb.AntiSpamConfig.Deserialize(p_Instance.AntiSpam, p_Reader, p_Parser);
		}

	}
}
