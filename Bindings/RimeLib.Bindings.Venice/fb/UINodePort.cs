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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class UINodePort : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("UINodePort." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected string m_InstanceName = string.Empty;
		[ContainerField(12), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1186954283)]
		public string InstanceName { get { return m_InstanceName; } set { if (OnPropertyChanging("UINodePort." + nameof(InstanceName), this, m_InstanceName, value)) m_InstanceName = value; } } // 0xC (12)
		
		protected UIWidgetEventID m_Query = new UIWidgetEventID();
		[ContainerField(16), MemberInfoFlag(137), ContainerFieldNameHash(223744783)]
		public UIWidgetEventID Query { get { return m_Query; } set { if (OnPropertyChanging("UINodePort." + nameof(Query), this, m_Query, value)) m_Query = value; } } // 0x10 (16)
		
		protected bool m_AllowManualRemove = new bool();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(64098272)]
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
