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
	public class PropertyDebugEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Vec3Value { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TextColor { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ScreenPosition { get; set; } = new Vec2(); // 0x30 (48)
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform TransformValue { get; set; } = new LinearTransform(); // 0x40 (64)
		
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Vec2Value { get; set; } = new Vec2(); // 0x80 (128)
		
		[ContainerField(136), LayoutImmutable]
		public string ValuePrefix { get; set; } // 0x88 (136)
		
		[ContainerField(140)]
		public Realm Realm { get; set; } = new Realm(); // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float FloatValue { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public int IntValue { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float TextScale { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable]
		public string StringValue { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public bool DefaultVisible { get; set; } // 0xA0 (160)
		
		[ContainerField(161), LayoutImmutable, Blittable]
		public bool BoolValue { get; set; } // 0xA1 (161)
		
		[ContainerField(162), LayoutImmutable, Blittable]
		public bool Multiline { get; set; } // 0xA2 (162)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 277101325:
					Vec3Value = (Vec3) p_Value;
					break;

				case 2527550245:
					TextColor = (Vec3) p_Value;
					break;

				case 2288910864:
					ScreenPosition = (Vec2) p_Value;
					break;

				case 3606782274:
					TransformValue = (LinearTransform) p_Value;
					break;

				case 311491116:
					Vec2Value = (Vec2) p_Value;
					break;

				case 1051050718:
					ValuePrefix = (string) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 3123792190:
					FloatValue = (float) p_Value;
					break;

				case 5685821:
					IntValue = (int) p_Value;
					break;

				case 2508713728:
					TextScale = (float) p_Value;
					break;

				case 1269878171:
					StringValue = (string) p_Value;
					break;

				case 3341302816:
					DefaultVisible = (bool) p_Value;
					break;

				case 176040160:
					BoolValue = (bool) p_Value;
					break;

				case 1101961090:
					Multiline = (bool) p_Value;
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
				case 277101325:
					return Vec3Value;

				case 2527550245:
					return TextColor;

				case 2288910864:
					return ScreenPosition;

				case 3606782274:
					return TransformValue;

				case 311491116:
					return Vec2Value;

				case 1051050718:
					return ValuePrefix;

				case 229961746:
					return Realm;

				case 3123792190:
					return FloatValue;

				case 5685821:
					return IntValue;

				case 2508713728:
					return TextScale;

				case 1269878171:
					return StringValue;

				case 3341302816:
					return DefaultVisible;

				case 176040160:
					return BoolValue;

				case 1101961090:
					return Multiline;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 277101325:
					return typeof(PropertyDebugEntityData).GetProperty(nameof(Vec3Value));

				case 2527550245:
					return typeof(PropertyDebugEntityData).GetProperty(nameof(TextColor));

				case 2288910864:
					return typeof(PropertyDebugEntityData).GetProperty(nameof(ScreenPosition));

				case 3606782274:
					return typeof(PropertyDebugEntityData).GetProperty(nameof(TransformValue));

				case 311491116:
					return typeof(PropertyDebugEntityData).GetProperty(nameof(Vec2Value));

				case 1051050718:
					return typeof(PropertyDebugEntityData).GetProperty(nameof(ValuePrefix));

				case 229961746:
					return typeof(PropertyDebugEntityData).GetProperty(nameof(Realm));

				case 3123792190:
					return typeof(PropertyDebugEntityData).GetProperty(nameof(FloatValue));

				case 5685821:
					return typeof(PropertyDebugEntityData).GetProperty(nameof(IntValue));

				case 2508713728:
					return typeof(PropertyDebugEntityData).GetProperty(nameof(TextScale));

				case 1269878171:
					return typeof(PropertyDebugEntityData).GetProperty(nameof(StringValue));

				case 3341302816:
					return typeof(PropertyDebugEntityData).GetProperty(nameof(DefaultVisible));

				case 176040160:
					return typeof(PropertyDebugEntityData).GetProperty(nameof(BoolValue));

				case 1101961090:
					return typeof(PropertyDebugEntityData).GetProperty(nameof(Multiline));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
