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
	public class RandomWalkOrderEntityData : 
		BFOrderEntityData
	{
		protected bool m_CombatForbidden = new bool();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2646993448)]
		public bool CombatForbidden { get { return m_CombatForbidden; } set { if (OnPropertyChanging("RandomWalkOrderEntityData." + nameof(CombatForbidden), this, m_CombatForbidden, value)) m_CombatForbidden = value; } } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2646993448:
					CombatForbidden = (bool) p_Value;
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
				case 2646993448:
					return CombatForbidden;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2646993448:
					return typeof(RandomWalkOrderEntityData).GetProperty(nameof(CombatForbidden));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
