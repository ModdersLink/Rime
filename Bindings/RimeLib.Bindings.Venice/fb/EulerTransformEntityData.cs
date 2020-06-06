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
    [ContainerType(16)]
	public class EulerTransformEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 In1 { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32)]
		public Realm Realm { get; set; } = new Realm(); // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float In { get; set; } // 0x24 (36)
		
		[ContainerField(40)]
		public ModifierEuler Euler { get; set; } = new ModifierEuler(); // 0x28 (40)
		
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
