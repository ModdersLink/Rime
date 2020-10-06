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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(24), ContainerClass]
	public class EnlightenEntityData : 
		EntityData
	{
		protected int m_Priority = new int();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3062102871)]
		public int Priority { get { return m_Priority; } set { if (OnPropertyChanging("EnlightenEntityData." + nameof(Priority), this, m_Priority, value)) m_Priority = value; } } // 0xC (12)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(16), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("EnlightenEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x10 (16)
		
		protected bool m_Enable = new bool();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("EnlightenEntityData." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3062102871:
					Priority = (int) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2342790116:
					Enable = (bool) p_Value;
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
				case 3062102871:
					return Priority;

				case 229961746:
					return Realm;

				case 2342790116:
					return Enable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3062102871:
					return typeof(EnlightenEntityData).GetProperty(nameof(Priority));

				case 229961746:
					return typeof(EnlightenEntityData).GetProperty(nameof(Realm));

				case 2342790116:
					return typeof(EnlightenEntityData).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
