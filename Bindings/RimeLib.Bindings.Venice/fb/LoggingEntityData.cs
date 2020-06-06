///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class LoggingEntityData : 
		EntityData
	{
		[ContainerField(12), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Vec2Value { get; set; } = new Vec2(); // 0xC (12)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Vec3Value { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform TransformValue { get; set; } = new LinearTransform(); // 0x30 (48)
		
		[ContainerField(112)]
		public Realm Realm { get; set; } = new Realm(); // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float FloatValue { get; set; } // 0x74 (116)
		
		[ContainerField(120)]
		public List<string> Strings { get; set; } = new List<string>(); // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public int IntValue { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public bool BoolValue { get; set; } // 0x80 (128)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 311491116:
					Vec2Value = (Vec2) p_Value;
					break;

				case 277101325:
					Vec3Value = (Vec3) p_Value;
					break;

				case 3606782274:
					TransformValue = (LinearTransform) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 3123792190:
					FloatValue = (float) p_Value;
					break;

				case 2189562659:
					Strings = (List<string>) p_Value;
					break;

				case 5685821:
					IntValue = (int) p_Value;
					break;

				case 176040160:
					BoolValue = (bool) p_Value;
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
				case 311491116:
					return Vec2Value;

				case 277101325:
					return Vec3Value;

				case 3606782274:
					return TransformValue;

				case 229961746:
					return Realm;

				case 3123792190:
					return FloatValue;

				case 2189562659:
					return Strings;

				case 5685821:
					return IntValue;

				case 176040160:
					return BoolValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 311491116:
					return typeof(LoggingEntityData).GetProperty(nameof(Vec2Value));

				case 277101325:
					return typeof(LoggingEntityData).GetProperty(nameof(Vec3Value));

				case 3606782274:
					return typeof(LoggingEntityData).GetProperty(nameof(TransformValue));

				case 229961746:
					return typeof(LoggingEntityData).GetProperty(nameof(Realm));

				case 3123792190:
					return typeof(LoggingEntityData).GetProperty(nameof(FloatValue));

				case 2189562659:
					return typeof(LoggingEntityData).GetProperty(nameof(Strings));

				case 5685821:
					return typeof(LoggingEntityData).GetProperty(nameof(IntValue));

				case 176040160:
					return typeof(LoggingEntityData).GetProperty(nameof(BoolValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
