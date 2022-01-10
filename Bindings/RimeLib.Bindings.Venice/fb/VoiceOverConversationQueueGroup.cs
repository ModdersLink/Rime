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
	[ContainerType(4, 20)]
	public class VoiceOverConversationQueueGroup : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12)]
		public VoiceOverConversationQueueGroupPolyphony PolyphonyMode { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint Polyphony { get; set; }

		public static void Deserialize(VoiceOverConversationQueueGroup p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.PolyphonyMode = (VoiceOverConversationQueueGroupPolyphony) p_Reader.ReadInt32();
			p_Instance.Polyphony = p_Reader.ReadUInt32();
		}

	}
}
