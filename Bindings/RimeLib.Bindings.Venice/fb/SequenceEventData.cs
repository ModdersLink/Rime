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
	public class SequenceEventData
	{
		[ContainerField(0)]
		public EventSpec Event { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public int Time { get; set; }
		
		public static void Deserialize(SequenceEventData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.EventSpec.Deserialize(p_Instance.Event, p_Reader, p_Parser);
			p_Instance.Time = p_Reader.ReadInt32();
		}
	}
}
