///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class SequenceEventData : FrostbiteContainer
	{
		[ContainerField(Name: "Event", Offset: 0, NameHash: 201427689, Flags: 41)]
		public EventSpec Event { get; set; } = new EventSpec(); // 0x0 (0)
		
		[ContainerField(Name: "Time", Offset: 4, NameHash: 2089313744, Flags: 49405), LayoutImmutable, Blittable]
		public int Time { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 201427689:
					Event = (EventSpec) p_Value;
					break;

				case 2089313744:
					Time = (int) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 201427689:
					return Event;

				case 2089313744:
					return Time;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 201427689:
					return typeof(SequenceEventData).GetProperty(nameof(Event));

				case 2089313744:
					return typeof(SequenceEventData).GetProperty(nameof(Time));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
