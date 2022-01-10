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
	public class AntEventData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public int TagId { get; set; }
		
		[ContainerField(4)]
		public EventSpec Event { get; set; } = new();
		
		public static void Deserialize(AntEventData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TagId = p_Reader.ReadInt32();
			fb.EventSpec.Deserialize(p_Instance.Event, p_Reader, p_Parser);
		}
	}
}
