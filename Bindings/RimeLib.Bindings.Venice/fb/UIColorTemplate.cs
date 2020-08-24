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
	public class UIColorTemplate : 
		Asset
	{
		protected RefArray<UIColor> m_Colors = new RefArray<UIColor>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(2713814155), ContainerRefArray]
		public RefArray<UIColor> Colors { get { return m_Colors; } set { if (OnPropertyChanging("UIColorTemplate." + nameof(Colors), this, m_Colors, value)) m_Colors = value; } } // 0xC (12)
		
		protected bool m_Active = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2484178249)]
		public bool Active { get { return m_Active; } set { if (OnPropertyChanging("UIColorTemplate." + nameof(Active), this, m_Active, value)) m_Active = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2713814155:
					Colors = (RefArray<UIColor>) p_Value;
					break;

				case 2484178249:
					Active = (bool) p_Value;
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
				case 2713814155:
					return Colors;

				case 2484178249:
					return Active;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2713814155:
					return typeof(UIColorTemplate).GetProperty(nameof(Colors));

				case 2484178249:
					return typeof(UIColorTemplate).GetProperty(nameof(Active));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
