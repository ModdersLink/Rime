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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(144), ContainerClass]
	public class LoggingEntityData : 
		EntityData
	{
		protected Vec2 m_Vec2Value = new Vec2();
		[ContainerField(12), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(311491116)]
		public Vec2 Vec2Value { get { return m_Vec2Value; } set { if (OnPropertyChanging("LoggingEntityData." + nameof(Vec2Value), this, m_Vec2Value, value)) m_Vec2Value = value; } } // 0xC (12)
		
		protected Vec3 m_Vec3Value = new Vec3();
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(277101325)]
		public Vec3 Vec3Value { get { return m_Vec3Value; } set { if (OnPropertyChanging("LoggingEntityData." + nameof(Vec3Value), this, m_Vec3Value, value)) m_Vec3Value = value; } } // 0x20 (32)
		
		protected LinearTransform m_TransformValue = new LinearTransform();
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(3606782274)]
		public LinearTransform TransformValue { get { return m_TransformValue; } set { if (OnPropertyChanging("LoggingEntityData." + nameof(TransformValue), this, m_TransformValue, value)) m_TransformValue = value; } } // 0x30 (48)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(112), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("LoggingEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x70 (112)
		
		protected float m_FloatValue = new float();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3123792190)]
		public float FloatValue { get { return m_FloatValue; } set { if (OnPropertyChanging("LoggingEntityData." + nameof(FloatValue), this, m_FloatValue, value)) m_FloatValue = value; } } // 0x74 (116)
		
		protected List<string> m_Strings = new List<string>();
		[ContainerField(120), MemberInfoFlag(65), ContainerFieldNameHash(2189562659), ContainerArray]
		public List<string> Strings { get { return m_Strings; } set { if (OnPropertyChanging("LoggingEntityData." + nameof(Strings), this, m_Strings, value)) m_Strings = value; } } // 0x78 (120)
		
		protected int m_IntValue = new int();
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(5685821)]
		public int IntValue { get { return m_IntValue; } set { if (OnPropertyChanging("LoggingEntityData." + nameof(IntValue), this, m_IntValue, value)) m_IntValue = value; } } // 0x7C (124)
		
		protected bool m_BoolValue = new bool();
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(176040160)]
		public bool BoolValue { get { return m_BoolValue; } set { if (OnPropertyChanging("LoggingEntityData." + nameof(BoolValue), this, m_BoolValue, value)) m_BoolValue = value; } } // 0x80 (128)
		
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
