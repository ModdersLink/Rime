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
	[ContainerType(4)]
	public class CompareFloatEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(12), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("CompareFloatEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected float m_A = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(177636)]
		public float A { get { return m_A; } set { if (OnPropertyChanging("CompareFloatEntityData." + nameof(A), this, m_A, value)) m_A = value; } } // 0x10 (16)
		
		protected float m_B = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(177639)]
		public float B { get { return m_B; } set { if (OnPropertyChanging("CompareFloatEntityData." + nameof(B), this, m_B, value)) m_B = value; } } // 0x14 (20)
		
		protected bool m_TriggerOnPropertyChange = new bool();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(3134109917)]
		public bool TriggerOnPropertyChange { get { return m_TriggerOnPropertyChange; } set { if (OnPropertyChanging("CompareFloatEntityData." + nameof(TriggerOnPropertyChange), this, m_TriggerOnPropertyChange, value)) m_TriggerOnPropertyChange = value; } } // 0x18 (24)
		
		protected bool m_TriggerOnStart = new bool();
		[ContainerField(25), LayoutImmutable, Blittable, ContainerFieldNameHash(3859836348)]
		public bool TriggerOnStart { get { return m_TriggerOnStart; } set { if (OnPropertyChanging("CompareFloatEntityData." + nameof(TriggerOnStart), this, m_TriggerOnStart, value)) m_TriggerOnStart = value; } } // 0x19 (25)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 177636:
					A = (float) p_Value;
					break;

				case 177639:
					B = (float) p_Value;
					break;

				case 3134109917:
					TriggerOnPropertyChange = (bool) p_Value;
					break;

				case 3859836348:
					TriggerOnStart = (bool) p_Value;
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

				case 177636:
					return A;

				case 177639:
					return B;

				case 3134109917:
					return TriggerOnPropertyChange;

				case 3859836348:
					return TriggerOnStart;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(CompareFloatEntityData).GetProperty(nameof(Realm));

				case 177636:
					return typeof(CompareFloatEntityData).GetProperty(nameof(A));

				case 177639:
					return typeof(CompareFloatEntityData).GetProperty(nameof(B));

				case 3134109917:
					return typeof(CompareFloatEntityData).GetProperty(nameof(TriggerOnPropertyChange));

				case 3859836348:
					return typeof(CompareFloatEntityData).GetProperty(nameof(TriggerOnStart));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
