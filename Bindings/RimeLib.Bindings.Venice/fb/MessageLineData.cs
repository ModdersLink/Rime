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
	public class MessageLineData
	{
		[ContainerField(0), LayoutImmutable]
		public string MessageSid { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public EntryInputActionEnum EntryInputAction { get; set; } = new();
		
	}
}
