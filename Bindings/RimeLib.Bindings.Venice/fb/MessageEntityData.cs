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
	[ContainerType(4, 36)]
	public class MessageEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable]
		public string MessageSid { get; set; } = string.Empty;

		[ContainerField(16)]
		public List<MessageLineData> AdditionalMessages { get; set; } = new();

		[ContainerField(20)]
		public UIMessageEntityType MessageType { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public float DisplayTime { get; set; }

		[ContainerField(28)]
		public EntryInputActionEnum EntryInputAction { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool Enabled { get; set; }

		public static void Deserialize(MessageEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MessageSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.AdditionalMessages.Clear();
			(RimeReader Reader, uint Count) s_AdditionalMessages = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_AdditionalMessages.Count; ++i)
			{
				var s_Value = new MessageLineData();
				fb.MessageLineData.Deserialize(s_Value, s_AdditionalMessages.Reader, p_Parser);
				p_Instance.AdditionalMessages.Add(s_Value);
			}
			
			s_AdditionalMessages.Reader.Dispose();
			p_Instance.MessageType = (UIMessageEntityType) p_Reader.ReadInt32();
			p_Instance.DisplayTime = p_Reader.ReadSingle();
			p_Instance.EntryInputAction = (EntryInputActionEnum) p_Reader.ReadInt32();
			p_Instance.Enabled = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
