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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class UINodePort : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(Name: "Name", Offset: 8, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("UINodePort." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected string m_InstanceName = string.Empty;
		[ContainerField(Name: "InstanceName", Offset: 12, NameHash: 1186954283, Flags: 16509), LayoutImmutable]
		public string InstanceName { get { return m_InstanceName; } set { if (OnPropertyChanging("UINodePort." + nameof(InstanceName), this, m_InstanceName, value)) m_InstanceName = value; } } // 0xC (12)
		
		protected UIWidgetEventID m_Query = new UIWidgetEventID();
		[ContainerField(Name: "Query", Offset: 16, NameHash: 223744783, Flags: 137)]
		public UIWidgetEventID Query { get { return m_Query; } set { if (OnPropertyChanging("UINodePort." + nameof(Query), this, m_Query, value)) m_Query = value; } } // 0x10 (16)
		
		protected bool m_AllowManualRemove = new bool();
		[ContainerField(Name: "AllowManualRemove", Offset: 20, NameHash: 64098272, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowManualRemove { get { return m_AllowManualRemove; } set { if (OnPropertyChanging("UINodePort." + nameof(AllowManualRemove), this, m_AllowManualRemove, value)) m_AllowManualRemove = value; } } // 0x14 (20)
		
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
