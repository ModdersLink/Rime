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

	}
}
