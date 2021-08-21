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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class FakeHingeData : 
		FakePhysicsData
	{
		protected Vec3 m_Pivot = new Vec3();
		[ContainerField(Name: "Pivot", Offset: 48, NameHash: 232602033, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Pivot { get { return m_Pivot; } set { if (OnPropertyChanging("FakeHingeData." + nameof(Pivot), this, m_Pivot, value)) m_Pivot = value; } } // 0x30 (48)
		
		protected Vec3 m_RotationAxis = new Vec3();
		[ContainerField(Name: "RotationAxis", Offset: 64, NameHash: 3148542130, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 RotationAxis { get { return m_RotationAxis; } set { if (OnPropertyChanging("FakeHingeData." + nameof(RotationAxis), this, m_RotationAxis, value)) m_RotationAxis = value; } } // 0x40 (64)
		
		protected Vec3 m_ExtensionAxis = new Vec3();
		[ContainerField(Name: "ExtensionAxis", Offset: 80, NameHash: 4281429311, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ExtensionAxis { get { return m_ExtensionAxis; } set { if (OnPropertyChanging("FakeHingeData." + nameof(ExtensionAxis), this, m_ExtensionAxis, value)) m_ExtensionAxis = value; } } // 0x50 (80)
		
		protected float m_MinAngle = new float();
		[ContainerField(Name: "MinAngle", Offset: 96, NameHash: 3356124462, Flags: 49469), LayoutImmutable, Blittable]
		public float MinAngle { get { return m_MinAngle; } set { if (OnPropertyChanging("FakeHingeData." + nameof(MinAngle), this, m_MinAngle, value)) m_MinAngle = value; } } // 0x60 (96)
		
		protected float m_MaxAngle = new float();
		[ContainerField(Name: "MaxAngle", Offset: 100, NameHash: 417488496, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxAngle { get { return m_MaxAngle; } set { if (OnPropertyChanging("FakeHingeData." + nameof(MaxAngle), this, m_MaxAngle, value)) m_MaxAngle = value; } } // 0x64 (100)
		
		protected float m_AngularDampening = new float();
		[ContainerField(Name: "AngularDampening", Offset: 104, NameHash: 705185012, Flags: 49469), LayoutImmutable, Blittable]
		public float AngularDampening { get { return m_AngularDampening; } set { if (OnPropertyChanging("FakeHingeData." + nameof(AngularDampening), this, m_AngularDampening, value)) m_AngularDampening = value; } } // 0x68 (104)
		
		protected float m_PullbackAcceleration = new float();
		[ContainerField(Name: "PullbackAcceleration", Offset: 108, NameHash: 1407037897, Flags: 49469), LayoutImmutable, Blittable]
		public float PullbackAcceleration { get { return m_PullbackAcceleration; } set { if (OnPropertyChanging("FakeHingeData." + nameof(PullbackAcceleration), this, m_PullbackAcceleration, value)) m_PullbackAcceleration = value; } } // 0x6C (108)
		
		protected float m_ProgressiveExponent = new float();
		[ContainerField(Name: "ProgressiveExponent", Offset: 112, NameHash: 487101329, Flags: 49469), LayoutImmutable, Blittable]
		public float ProgressiveExponent { get { return m_ProgressiveExponent; } set { if (OnPropertyChanging("FakeHingeData." + nameof(ProgressiveExponent), this, m_ProgressiveExponent, value)) m_ProgressiveExponent = value; } } // 0x70 (112)
		
		protected float m_InertiaModifier = new float();
		[ContainerField(Name: "InertiaModifier", Offset: 116, NameHash: 3532865534, Flags: 49469), LayoutImmutable, Blittable]
		public float InertiaModifier { get { return m_InertiaModifier; } set { if (OnPropertyChanging("FakeHingeData." + nameof(InertiaModifier), this, m_InertiaModifier, value)) m_InertiaModifier = value; } } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 232602033:
					Pivot = (Vec3) p_Value;
					break;

				case 3148542130:
					RotationAxis = (Vec3) p_Value;
					break;

				case 4281429311:
					ExtensionAxis = (Vec3) p_Value;
					break;

				case 3356124462:
					MinAngle = (float) p_Value;
					break;

				case 417488496:
					MaxAngle = (float) p_Value;
					break;

				case 705185012:
					AngularDampening = (float) p_Value;
					break;

				case 1407037897:
					PullbackAcceleration = (float) p_Value;
					break;

				case 487101329:
					ProgressiveExponent = (float) p_Value;
					break;

				case 3532865534:
					InertiaModifier = (float) p_Value;
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
				case 232602033:
					return Pivot;

				case 3148542130:
					return RotationAxis;

				case 4281429311:
					return ExtensionAxis;

				case 3356124462:
					return MinAngle;

				case 417488496:
					return MaxAngle;

				case 705185012:
					return AngularDampening;

				case 1407037897:
					return PullbackAcceleration;

				case 487101329:
					return ProgressiveExponent;

				case 3532865534:
					return InertiaModifier;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 232602033:
					return typeof(FakeHingeData).GetProperty(nameof(Pivot));

				case 3148542130:
					return typeof(FakeHingeData).GetProperty(nameof(RotationAxis));

				case 4281429311:
					return typeof(FakeHingeData).GetProperty(nameof(ExtensionAxis));

				case 3356124462:
					return typeof(FakeHingeData).GetProperty(nameof(MinAngle));

				case 417488496:
					return typeof(FakeHingeData).GetProperty(nameof(MaxAngle));

				case 705185012:
					return typeof(FakeHingeData).GetProperty(nameof(AngularDampening));

				case 1407037897:
					return typeof(FakeHingeData).GetProperty(nameof(PullbackAcceleration));

				case 487101329:
					return typeof(FakeHingeData).GetProperty(nameof(ProgressiveExponent));

				case 3532865534:
					return typeof(FakeHingeData).GetProperty(nameof(InertiaModifier));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
