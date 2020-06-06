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
	public class IntegratorOrDifferentiatorEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new Realm(); // 0xC (12)
		
		[ContainerField(16)]
		public EntityUpdateOrder UpdatePass { get; set; } = new EntityUpdateOrder(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float StartValue { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Input { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaxValue { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float MinValue { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool Bounded { get; set; } // 0x24 (36)
		
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
