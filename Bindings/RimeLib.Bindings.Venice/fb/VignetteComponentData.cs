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
	public class VignetteComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Scale { get; set; } = new Vec2(); // 0x60 (96)
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Color { get; set; } = new Vec3(); // 0x70 (112)
		
		[ContainerField(128)]
		public Realm Realm { get; set; } = new Realm(); // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float Exponent { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float Opacity { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x8C (140)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 231223453:
					Scale = (Vec2) p_Value;
					break;

				case 212387320:
					Color = (Vec3) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 4228690070:
					Exponent = (float) p_Value;
					break;

				case 972165084:
					Opacity = (float) p_Value;
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
				case 231223453:
					return Scale;

				case 212387320:
					return Color;

				case 229961746:
					return Realm;

				case 4228690070:
					return Exponent;

				case 972165084:
					return Opacity;

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
				case 231223453:
					return typeof(VignetteComponentData).GetProperty(nameof(Scale));

				case 212387320:
					return typeof(VignetteComponentData).GetProperty(nameof(Color));

				case 229961746:
					return typeof(VignetteComponentData).GetProperty(nameof(Realm));

				case 4228690070:
					return typeof(VignetteComponentData).GetProperty(nameof(Exponent));

				case 972165084:
					return typeof(VignetteComponentData).GetProperty(nameof(Opacity));

				case 2342790116:
					return typeof(VignetteComponentData).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
