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
	public class PhysicsDrivenAnimationEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new Realm(); // 0xC (12)
		
		[ContainerField(16)]
		public PhysicsDrivenAnimationEntityBinding Binding { get; set; } = new PhysicsDrivenAnimationEntityBinding(); // 0x10 (16)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get; set; } // 0x84 (132)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2590060228:
					Binding = (PhysicsDrivenAnimationEntityBinding) p_Value;
					break;

				case 4041607518:
					AnimationEntitySpacePriority = (int) p_Value;
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

				case 2590060228:
					return Binding;

				case 4041607518:
					return AnimationEntitySpacePriority;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(PhysicsDrivenAnimationEntityData).GetProperty(nameof(Realm));

				case 2590060228:
					return typeof(PhysicsDrivenAnimationEntityData).GetProperty(nameof(Binding));

				case 4041607518:
					return typeof(PhysicsDrivenAnimationEntityData).GetProperty(nameof(AnimationEntitySpacePriority));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
