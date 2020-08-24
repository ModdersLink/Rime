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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class VignetteComponentData : 
		ComponentData
	{
		protected Vec2 m_Scale = new Vec2();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(231223453)]
		public Vec2 Scale { get { return m_Scale; } set { if (OnPropertyChanging("VignetteComponentData." + nameof(Scale), this, m_Scale, value)) m_Scale = value; } } // 0x60 (96)
		
		protected Vec3 m_Color = new Vec3();
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(212387320)]
		public Vec3 Color { get { return m_Color; } set { if (OnPropertyChanging("VignetteComponentData." + nameof(Color), this, m_Color, value)) m_Color = value; } } // 0x70 (112)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(128), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("VignetteComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x80 (128)
		
		protected float m_Exponent = new float();
		[ContainerField(132), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4228690070)]
		public float Exponent { get { return m_Exponent; } set { if (OnPropertyChanging("VignetteComponentData." + nameof(Exponent), this, m_Exponent, value)) m_Exponent = value; } } // 0x84 (132)
		
		protected float m_Opacity = new float();
		[ContainerField(136), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(972165084)]
		public float Opacity { get { return m_Opacity; } set { if (OnPropertyChanging("VignetteComponentData." + nameof(Opacity), this, m_Opacity, value)) m_Opacity = value; } } // 0x88 (136)
		
		protected bool m_Enable = new bool();
		[ContainerField(140), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("VignetteComponentData." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x8C (140)
		
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
