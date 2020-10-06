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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(20), ContainerClass]
	public class Or4EntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(12), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("Or4EntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected bool m_In1 = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(193450867)]
		public bool In1 { get { return m_In1; } set { if (OnPropertyChanging("Or4EntityData." + nameof(In1), this, m_In1, value)) m_In1 = value; } } // 0x10 (16)
		
		protected bool m_In2 = new bool();
		[ContainerField(17), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(193450864)]
		public bool In2 { get { return m_In2; } set { if (OnPropertyChanging("Or4EntityData." + nameof(In2), this, m_In2, value)) m_In2 = value; } } // 0x11 (17)
		
		protected bool m_In3 = new bool();
		[ContainerField(18), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(193450865)]
		public bool In3 { get { return m_In3; } set { if (OnPropertyChanging("Or4EntityData." + nameof(In3), this, m_In3, value)) m_In3 = value; } } // 0x12 (18)
		
		protected bool m_In4 = new bool();
		[ContainerField(19), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(193450870)]
		public bool In4 { get { return m_In4; } set { if (OnPropertyChanging("Or4EntityData." + nameof(In4), this, m_In4, value)) m_In4 = value; } } // 0x13 (19)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 193450867:
					In1 = (bool) p_Value;
					break;

				case 193450864:
					In2 = (bool) p_Value;
					break;

				case 193450865:
					In3 = (bool) p_Value;
					break;

				case 193450870:
					In4 = (bool) p_Value;
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
				case 229961746:
					return Realm;

				case 193450867:
					return In1;

				case 193450864:
					return In2;

				case 193450865:
					return In3;

				case 193450870:
					return In4;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(Or4EntityData).GetProperty(nameof(Realm));

				case 193450867:
					return typeof(Or4EntityData).GetProperty(nameof(In1));

				case 193450864:
					return typeof(Or4EntityData).GetProperty(nameof(In2));

				case 193450865:
					return typeof(Or4EntityData).GetProperty(nameof(In3));

				case 193450870:
					return typeof(Or4EntityData).GetProperty(nameof(In4));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
