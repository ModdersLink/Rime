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
	[ContainerType(4, 16)]
	public class SoldierEmoteNetworkedMessageMapping : 
		DataContainer
	{
		[ContainerField(8)]
		public SoldierEmote Emote { get; set; } = new();

		[ContainerField(12)]
		public List<UIMessageType> Messages { get; set; } = new();

		public static void Deserialize(SoldierEmoteNetworkedMessageMapping p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Emote = (SoldierEmote) p_Reader.ReadInt32();
			p_Instance.Messages.Clear();
			(RimeReader Reader, uint Count) s_Messages = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Messages.Count; ++i)
			{
				var s_Value = (UIMessageType) s_Messages.Reader.ReadInt32();
				p_Instance.Messages.Add(s_Value);
			}
			
			s_Messages.Reader.Dispose();
		}

	}
}
