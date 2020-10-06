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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(8), ContainerStruct]
	public class AntEventData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int TagId { get; set; } // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(41)]
		public EventSpec Event { get; set; } = new EventSpec(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 227597338:
					TagId = (int) p_Value;
					break;

				case 201427689:
					Event = (EventSpec) p_Value;
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
				case 227597338:
					return TagId;

				case 201427689:
					return Event;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 227597338:
					return typeof(AntEventData).GetProperty(nameof(TagId));

				case 201427689:
					return typeof(AntEventData).GetProperty(nameof(Event));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
