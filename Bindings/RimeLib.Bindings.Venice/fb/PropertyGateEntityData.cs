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
	public class PropertyGateEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform TransformIn { get; set; } = new LinearTransform(); // 0x10 (16)
		
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Vec4In { get; set; } = new Vec4(); // 0x50 (80)
		
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Vec3In { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112)]
		public Realm Realm { get; set; } = new Realm(); // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float FloatIn { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public int IntIn { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public bool BoolIn { get; set; } // 0x7C (124)
		
		[ContainerField(125), LayoutImmutable, Blittable]
		public bool Default { get; set; } // 0x7D (125)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2771982766:
					TransformIn = (LinearTransform) p_Value;
					break;

				case 3146684934:
					Vec4In = (Vec4) p_Value;
					break;

				case 3146686209:
					Vec3In = (Vec3) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2134484562:
					FloatIn = (float) p_Value;
					break;

				case 214528497:
					IntIn = (int) p_Value;
					break;

				case 2679383756:
					BoolIn = (bool) p_Value;
					break;

				case 3998752238:
					Default = (bool) p_Value;
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
				case 2771982766:
					return TransformIn;

				case 3146684934:
					return Vec4In;

				case 3146686209:
					return Vec3In;

				case 229961746:
					return Realm;

				case 2134484562:
					return FloatIn;

				case 214528497:
					return IntIn;

				case 2679383756:
					return BoolIn;

				case 3998752238:
					return Default;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2771982766:
					return typeof(PropertyGateEntityData).GetProperty(nameof(TransformIn));

				case 3146684934:
					return typeof(PropertyGateEntityData).GetProperty(nameof(Vec4In));

				case 3146686209:
					return typeof(PropertyGateEntityData).GetProperty(nameof(Vec3In));

				case 229961746:
					return typeof(PropertyGateEntityData).GetProperty(nameof(Realm));

				case 2134484562:
					return typeof(PropertyGateEntityData).GetProperty(nameof(FloatIn));

				case 214528497:
					return typeof(PropertyGateEntityData).GetProperty(nameof(IntIn));

				case 2679383756:
					return typeof(PropertyGateEntityData).GetProperty(nameof(BoolIn));

				case 3998752238:
					return typeof(PropertyGateEntityData).GetProperty(nameof(Default));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
