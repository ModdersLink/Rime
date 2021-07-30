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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 176)]
	public class PropertyDebugEntityData : 
		EntityData
	{
		protected Vec3 m_Vec3Value = new Vec3();
		[ContainerField(Name: "Vec3Value", Offset: 16, NameHash: 277101325, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Vec3Value { get { return m_Vec3Value; } set { if (OnPropertyChanging("PropertyDebugEntityData." + nameof(Vec3Value), this, m_Vec3Value, value)) m_Vec3Value = value; } } // 0x10 (16)
		
		protected Vec3 m_TextColor = new Vec3();
		[ContainerField(Name: "TextColor", Offset: 32, NameHash: 2527550245, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TextColor { get { return m_TextColor; } set { if (OnPropertyChanging("PropertyDebugEntityData." + nameof(TextColor), this, m_TextColor, value)) m_TextColor = value; } } // 0x20 (32)
		
		protected Vec2 m_ScreenPosition = new Vec2();
		[ContainerField(Name: "ScreenPosition", Offset: 48, NameHash: 2288910864, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ScreenPosition { get { return m_ScreenPosition; } set { if (OnPropertyChanging("PropertyDebugEntityData." + nameof(ScreenPosition), this, m_ScreenPosition, value)) m_ScreenPosition = value; } } // 0x30 (48)
		
		protected LinearTransform m_TransformValue = new LinearTransform();
		[ContainerField(Name: "TransformValue", Offset: 64, NameHash: 3606782274, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform TransformValue { get { return m_TransformValue; } set { if (OnPropertyChanging("PropertyDebugEntityData." + nameof(TransformValue), this, m_TransformValue, value)) m_TransformValue = value; } } // 0x40 (64)
		
		protected Vec2 m_Vec2Value = new Vec2();
		[ContainerField(Name: "Vec2Value", Offset: 128, NameHash: 311491116, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Vec2Value { get { return m_Vec2Value; } set { if (OnPropertyChanging("PropertyDebugEntityData." + nameof(Vec2Value), this, m_Vec2Value, value)) m_Vec2Value = value; } } // 0x80 (128)
		
		protected string m_ValuePrefix = string.Empty;
		[ContainerField(Name: "ValuePrefix", Offset: 136, NameHash: 1051050718, Flags: 16509), LayoutImmutable]
		public string ValuePrefix { get { return m_ValuePrefix; } set { if (OnPropertyChanging("PropertyDebugEntityData." + nameof(ValuePrefix), this, m_ValuePrefix, value)) m_ValuePrefix = value; } } // 0x88 (136)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 140, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("PropertyDebugEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x8C (140)
		
		protected float m_FloatValue = new float();
		[ContainerField(Name: "FloatValue", Offset: 144, NameHash: 3123792190, Flags: 49469), LayoutImmutable, Blittable]
		public float FloatValue { get { return m_FloatValue; } set { if (OnPropertyChanging("PropertyDebugEntityData." + nameof(FloatValue), this, m_FloatValue, value)) m_FloatValue = value; } } // 0x90 (144)
		
		protected int m_IntValue = new int();
		[ContainerField(Name: "IntValue", Offset: 148, NameHash: 5685821, Flags: 49405), LayoutImmutable, Blittable]
		public int IntValue { get { return m_IntValue; } set { if (OnPropertyChanging("PropertyDebugEntityData." + nameof(IntValue), this, m_IntValue, value)) m_IntValue = value; } } // 0x94 (148)
		
		protected float m_TextScale = new float();
		[ContainerField(Name: "TextScale", Offset: 152, NameHash: 2508713728, Flags: 49469), LayoutImmutable, Blittable]
		public float TextScale { get { return m_TextScale; } set { if (OnPropertyChanging("PropertyDebugEntityData." + nameof(TextScale), this, m_TextScale, value)) m_TextScale = value; } } // 0x98 (152)
		
		protected string m_StringValue = string.Empty;
		[ContainerField(Name: "StringValue", Offset: 156, NameHash: 1269878171, Flags: 16509), LayoutImmutable]
		public string StringValue { get { return m_StringValue; } set { if (OnPropertyChanging("PropertyDebugEntityData." + nameof(StringValue), this, m_StringValue, value)) m_StringValue = value; } } // 0x9C (156)
		
		protected bool m_DefaultVisible = new bool();
		[ContainerField(Name: "DefaultVisible", Offset: 160, NameHash: 3341302816, Flags: 49325), LayoutImmutable, Blittable]
		public bool DefaultVisible { get { return m_DefaultVisible; } set { if (OnPropertyChanging("PropertyDebugEntityData." + nameof(DefaultVisible), this, m_DefaultVisible, value)) m_DefaultVisible = value; } } // 0xA0 (160)
		
		protected bool m_BoolValue = new bool();
		[ContainerField(Name: "BoolValue", Offset: 161, NameHash: 176040160, Flags: 49325), LayoutImmutable, Blittable]
		public bool BoolValue { get { return m_BoolValue; } set { if (OnPropertyChanging("PropertyDebugEntityData." + nameof(BoolValue), this, m_BoolValue, value)) m_BoolValue = value; } } // 0xA1 (161)
		
		protected bool m_Multiline = new bool();
		[ContainerField(Name: "Multiline", Offset: 162, NameHash: 1101961090, Flags: 49325), LayoutImmutable, Blittable]
		public bool Multiline { get { return m_Multiline; } set { if (OnPropertyChanging("PropertyDebugEntityData." + nameof(Multiline), this, m_Multiline, value)) m_Multiline = value; } } // 0xA2 (162)
		
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
