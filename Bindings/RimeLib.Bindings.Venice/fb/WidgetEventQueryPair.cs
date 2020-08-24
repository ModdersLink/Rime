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
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class WidgetEventQueryPair : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, MemberInfoFlag(16509)]
		public string Name { get; set; } // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(137)]
		public UIWidgetEventID Query { get; set; } = new UIWidgetEventID(); // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509)]
		public string InstanceName { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool IsOutput { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 223744783:
						Query = (UIWidgetEventID) Enum.ToObject(typeof(UIWidgetEventID), p_Value);
					break;

				case 1186954283:
					InstanceName = (string) p_Value;
					break;

				case 599241184:
					IsOutput = (bool) p_Value;
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
				case 2088949890:
					return Name;

				case 223744783:
					return Query;

				case 1186954283:
					return InstanceName;

				case 599241184:
					return IsOutput;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(WidgetEventQueryPair).GetProperty(nameof(Name));

				case 223744783:
					return typeof(WidgetEventQueryPair).GetProperty(nameof(Query));

				case 1186954283:
					return typeof(WidgetEventQueryPair).GetProperty(nameof(InstanceName));

				case 599241184:
					return typeof(WidgetEventQueryPair).GetProperty(nameof(IsOutput));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
