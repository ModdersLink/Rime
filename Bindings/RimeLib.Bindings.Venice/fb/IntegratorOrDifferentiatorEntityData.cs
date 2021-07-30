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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 40)]
	public class IntegratorOrDifferentiatorEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 12, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("IntegratorOrDifferentiatorEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected EntityUpdateOrder m_UpdatePass = new EntityUpdateOrder();
		[ContainerField(Name: "UpdatePass", Offset: 16, NameHash: 2270785669, Flags: 137)]
		public EntityUpdateOrder UpdatePass { get { return m_UpdatePass; } set { if (OnPropertyChanging("IntegratorOrDifferentiatorEntityData." + nameof(UpdatePass), this, m_UpdatePass, value)) m_UpdatePass = value; } } // 0x10 (16)
		
		protected float m_StartValue = new float();
		[ContainerField(Name: "StartValue", Offset: 20, NameHash: 2748522638, Flags: 49469), LayoutImmutable, Blittable]
		public float StartValue { get { return m_StartValue; } set { if (OnPropertyChanging("IntegratorOrDifferentiatorEntityData." + nameof(StartValue), this, m_StartValue, value)) m_StartValue = value; } } // 0x14 (20)
		
		protected float m_Input = new float();
		[ContainerField(Name: "Input", Offset: 24, NameHash: 214522259, Flags: 49469), LayoutImmutable, Blittable]
		public float Input { get { return m_Input; } set { if (OnPropertyChanging("IntegratorOrDifferentiatorEntityData." + nameof(Input), this, m_Input, value)) m_Input = value; } } // 0x18 (24)
		
		protected float m_MaxValue = new float();
		[ContainerField(Name: "MaxValue", Offset: 28, NameHash: 408516922, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxValue { get { return m_MaxValue; } set { if (OnPropertyChanging("IntegratorOrDifferentiatorEntityData." + nameof(MaxValue), this, m_MaxValue, value)) m_MaxValue = value; } } // 0x1C (28)
		
		protected float m_MinValue = new float();
		[ContainerField(Name: "MinValue", Offset: 32, NameHash: 3371854436, Flags: 49469), LayoutImmutable, Blittable]
		public float MinValue { get { return m_MinValue; } set { if (OnPropertyChanging("IntegratorOrDifferentiatorEntityData." + nameof(MinValue), this, m_MinValue, value)) m_MinValue = value; } } // 0x20 (32)
		
		protected bool m_Bounded = new bool();
		[ContainerField(Name: "Bounded", Offset: 36, NameHash: 2541140406, Flags: 49325), LayoutImmutable, Blittable]
		public bool Bounded { get { return m_Bounded; } set { if (OnPropertyChanging("IntegratorOrDifferentiatorEntityData." + nameof(Bounded), this, m_Bounded, value)) m_Bounded = value; } } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2270785669:
					UpdatePass = (EntityUpdateOrder) Enum.ToObject(typeof(EntityUpdateOrder), p_Value);
					break;

				case 2748522638:
					StartValue = (float) p_Value;
					break;

				case 214522259:
					Input = (float) p_Value;
					break;

				case 408516922:
					MaxValue = (float) p_Value;
					break;

				case 3371854436:
					MinValue = (float) p_Value;
					break;

				case 2541140406:
					Bounded = (bool) p_Value;
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

				case 2270785669:
					return UpdatePass;

				case 2748522638:
					return StartValue;

				case 214522259:
					return Input;

				case 408516922:
					return MaxValue;

				case 3371854436:
					return MinValue;

				case 2541140406:
					return Bounded;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(IntegratorOrDifferentiatorEntityData).GetProperty(nameof(Realm));

				case 2270785669:
					return typeof(IntegratorOrDifferentiatorEntityData).GetProperty(nameof(UpdatePass));

				case 2748522638:
					return typeof(IntegratorOrDifferentiatorEntityData).GetProperty(nameof(StartValue));

				case 214522259:
					return typeof(IntegratorOrDifferentiatorEntityData).GetProperty(nameof(Input));

				case 408516922:
					return typeof(IntegratorOrDifferentiatorEntityData).GetProperty(nameof(MaxValue));

				case 3371854436:
					return typeof(IntegratorOrDifferentiatorEntityData).GetProperty(nameof(MinValue));

				case 2541140406:
					return typeof(IntegratorOrDifferentiatorEntityData).GetProperty(nameof(Bounded));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
