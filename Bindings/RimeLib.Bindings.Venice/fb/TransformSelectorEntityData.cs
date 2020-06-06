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
	public class TransformSelectorEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In1 { get; set; } = new LinearTransform(); // 0x10 (16)
		
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In2 { get; set; } = new LinearTransform(); // 0x50 (80)
		
		[ContainerField(144)]
		public Realm Realm { get; set; } = new Realm(); // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public bool Selection { get; set; } // 0x94 (148)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193450867:
					In1 = (LinearTransform) p_Value;
					break;

				case 193450864:
					In2 = (LinearTransform) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 299217285:
					Selection = (bool) p_Value;
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

				case 193450864:
					return In2;

				case 229961746:
					return Realm;

				case 299217285:
					return Selection;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193450867:
					return typeof(TransformSelectorEntityData).GetProperty(nameof(In1));

				case 193450864:
					return typeof(TransformSelectorEntityData).GetProperty(nameof(In2));

				case 229961746:
					return typeof(TransformSelectorEntityData).GetProperty(nameof(Realm));

				case 299217285:
					return typeof(TransformSelectorEntityData).GetProperty(nameof(Selection));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
