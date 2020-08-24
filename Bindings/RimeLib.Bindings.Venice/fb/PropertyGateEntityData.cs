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
	public class PropertyGateEntityData : 
		EntityData
	{
		protected LinearTransform m_TransformIn = new LinearTransform();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2771982766)]
		public LinearTransform TransformIn { get { return m_TransformIn; } set { if (OnPropertyChanging("PropertyGateEntityData." + nameof(TransformIn), this, m_TransformIn, value)) m_TransformIn = value; } } // 0x10 (16)
		
		protected Vec4 m_Vec4In = new Vec4();
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(3146684934)]
		public Vec4 Vec4In { get { return m_Vec4In; } set { if (OnPropertyChanging("PropertyGateEntityData." + nameof(Vec4In), this, m_Vec4In, value)) m_Vec4In = value; } } // 0x50 (80)
		
		protected Vec3 m_Vec3In = new Vec3();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(3146686209)]
		public Vec3 Vec3In { get { return m_Vec3In; } set { if (OnPropertyChanging("PropertyGateEntityData." + nameof(Vec3In), this, m_Vec3In, value)) m_Vec3In = value; } } // 0x60 (96)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(112), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("PropertyGateEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x70 (112)
		
		protected float m_FloatIn = new float();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2134484562)]
		public float FloatIn { get { return m_FloatIn; } set { if (OnPropertyChanging("PropertyGateEntityData." + nameof(FloatIn), this, m_FloatIn, value)) m_FloatIn = value; } } // 0x74 (116)
		
		protected int m_IntIn = new int();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(214528497)]
		public int IntIn { get { return m_IntIn; } set { if (OnPropertyChanging("PropertyGateEntityData." + nameof(IntIn), this, m_IntIn, value)) m_IntIn = value; } } // 0x78 (120)
		
		protected bool m_BoolIn = new bool();
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2679383756)]
		public bool BoolIn { get { return m_BoolIn; } set { if (OnPropertyChanging("PropertyGateEntityData." + nameof(BoolIn), this, m_BoolIn, value)) m_BoolIn = value; } } // 0x7C (124)
		
		protected bool m_Default = new bool();
		[ContainerField(125), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3998752238)]
		public bool Default { get { return m_Default; } set { if (OnPropertyChanging("PropertyGateEntityData." + nameof(Default), this, m_Default, value)) m_Default = value; } } // 0x7D (125)
		
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
