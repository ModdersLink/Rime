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
	[ContainerType(16)]
	public class EulerTransformEntityData : 
		EntityData
	{
		protected Vec3 m_In1 = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(193450867)]
		public Vec3 In1 { get { return m_In1; } set { if (OnPropertyChanging("EulerTransformEntityData." + nameof(In1), this, m_In1, value)) m_In1 = value; } } // 0x10 (16)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(32), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("EulerTransformEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x20 (32)
		
		protected float m_In = new float();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(5862146)]
		public float In { get { return m_In; } set { if (OnPropertyChanging("EulerTransformEntityData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x24 (36)
		
		protected ModifierEuler m_Euler = new ModifierEuler();
		[ContainerField(40), ContainerFieldNameHash(201462510)]
		public ModifierEuler Euler { get { return m_Euler; } set { if (OnPropertyChanging("EulerTransformEntityData." + nameof(Euler), this, m_Euler, value)) m_Euler = value; } } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193450867:
					In1 = (Vec3) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 5862146:
					In = (float) p_Value;
					break;

				case 201462510:
					Euler = (ModifierEuler) Enum.ToObject(typeof(ModifierEuler), p_Value);
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
				case 193450867:
					return In1;

				case 229961746:
					return Realm;

				case 5862146:
					return In;

				case 201462510:
					return Euler;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193450867:
					return typeof(EulerTransformEntityData).GetProperty(nameof(In1));

				case 229961746:
					return typeof(EulerTransformEntityData).GetProperty(nameof(Realm));

				case 5862146:
					return typeof(EulerTransformEntityData).GetProperty(nameof(In));

				case 201462510:
					return typeof(EulerTransformEntityData).GetProperty(nameof(Euler));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
