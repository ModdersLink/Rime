///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UINodePort : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable]
		public string InstanceName { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public UIWidgetEventID Query { get; set; } = new UIWidgetEventID(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool AllowManualRemove { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 1186954283:
					InstanceName = (string) p_Value;
					break;

				case 223744783:
					Query = (UIWidgetEventID) Enum.ToObject(typeof(UIWidgetEventID), p_Value);
					break;

				case 64098272:
					AllowManualRemove = (bool) p_Value;
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

				case 1186954283:
					return InstanceName;

				case 223744783:
					return Query;

				case 64098272:
					return AllowManualRemove;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(UINodePort).GetProperty(nameof(Name));

				case 1186954283:
					return typeof(UINodePort).GetProperty(nameof(InstanceName));

				case 223744783:
					return typeof(UINodePort).GetProperty(nameof(Query));

				case 64098272:
					return typeof(UINodePort).GetProperty(nameof(AllowManualRemove));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
