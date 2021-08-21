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
	public class HullFloatPhysicsData : 
		FloatPhysicsData
	{
		protected Vec3 m_WaterResistanceAxisMod = new Vec3();
		[ContainerField(Name: "WaterResistanceAxisMod", Offset: 16, NameHash: 3948471318, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 WaterResistanceAxisMod { get { return m_WaterResistanceAxisMod; } set { if (OnPropertyChanging("HullFloatPhysicsData." + nameof(WaterResistanceAxisMod), this, m_WaterResistanceAxisMod, value)) m_WaterResistanceAxisMod = value; } } // 0x10 (16)
		
		protected Vec3 m_WaterFrictionAxisMod = new Vec3();
		[ContainerField(Name: "WaterFrictionAxisMod", Offset: 32, NameHash: 3626723959, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 WaterFrictionAxisMod { get { return m_WaterFrictionAxisMod; } set { if (OnPropertyChanging("HullFloatPhysicsData." + nameof(WaterFrictionAxisMod), this, m_WaterFrictionAxisMod, value)) m_WaterFrictionAxisMod = value; } } // 0x20 (32)
		
		protected Vec3 m_Offset = new Vec3();
		[ContainerField(Name: "Offset", Offset: 48, NameHash: 2871410728, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Offset { get { return m_Offset; } set { if (OnPropertyChanging("HullFloatPhysicsData." + nameof(Offset), this, m_Offset, value)) m_Offset = value; } } // 0x30 (48)
		
		protected int m_SubSurfaceSplits = new int();
		[ContainerField(Name: "SubSurfaceSplits", Offset: 64, NameHash: 1890108277, Flags: 49405), LayoutImmutable, Blittable]
		public int SubSurfaceSplits { get { return m_SubSurfaceSplits; } set { if (OnPropertyChanging("HullFloatPhysicsData." + nameof(SubSurfaceSplits), this, m_SubSurfaceSplits, value)) m_SubSurfaceSplits = value; } } // 0x40 (64)
		
		protected float m_Depth = new float();
		[ContainerField(Name: "Depth", Offset: 68, NameHash: 208780552, Flags: 49469), LayoutImmutable, Blittable]
		public float Depth { get { return m_Depth; } set { if (OnPropertyChanging("HullFloatPhysicsData." + nameof(Depth), this, m_Depth, value)) m_Depth = value; } } // 0x44 (68)
		
		protected float m_Width = new float();
		[ContainerField(Name: "Width", Offset: 72, NameHash: 226981187, Flags: 49469), LayoutImmutable, Blittable]
		public float Width { get { return m_Width; } set { if (OnPropertyChanging("HullFloatPhysicsData." + nameof(Width), this, m_Width, value)) m_Width = value; } } // 0x48 (72)
		
		protected float m_Length = new float();
		[ContainerField(Name: "Length", Offset: 76, NameHash: 2906827577, Flags: 49469), LayoutImmutable, Blittable]
		public float Length { get { return m_Length; } set { if (OnPropertyChanging("HullFloatPhysicsData." + nameof(Length), this, m_Length, value)) m_Length = value; } } // 0x4C (76)
		
		protected float m_FrontCurveDegree = new float();
		[ContainerField(Name: "FrontCurveDegree", Offset: 80, NameHash: 2319028903, Flags: 49469), LayoutImmutable, Blittable]
		public float FrontCurveDegree { get { return m_FrontCurveDegree; } set { if (OnPropertyChanging("HullFloatPhysicsData." + nameof(FrontCurveDegree), this, m_FrontCurveDegree, value)) m_FrontCurveDegree = value; } } // 0x50 (80)
		
		protected float m_SideCurveDegree = new float();
		[ContainerField(Name: "SideCurveDegree", Offset: 84, NameHash: 2221634077, Flags: 49469), LayoutImmutable, Blittable]
		public float SideCurveDegree { get { return m_SideCurveDegree; } set { if (OnPropertyChanging("HullFloatPhysicsData." + nameof(SideCurveDegree), this, m_SideCurveDegree, value)) m_SideCurveDegree = value; } } // 0x54 (84)
		
		protected float m_NonEngineSteer = new float();
		[ContainerField(Name: "NonEngineSteer", Offset: 88, NameHash: 2436950673, Flags: 49469), LayoutImmutable, Blittable]
		public float NonEngineSteer { get { return m_NonEngineSteer; } set { if (OnPropertyChanging("HullFloatPhysicsData." + nameof(NonEngineSteer), this, m_NonEngineSteer, value)) m_NonEngineSteer = value; } } // 0x58 (88)
		
		protected float m_NonEngineSteerMinSpeed = new float();
		[ContainerField(Name: "NonEngineSteerMinSpeed", Offset: 92, NameHash: 625608988, Flags: 49469), LayoutImmutable, Blittable]
		public float NonEngineSteerMinSpeed { get { return m_NonEngineSteerMinSpeed; } set { if (OnPropertyChanging("HullFloatPhysicsData." + nameof(NonEngineSteerMinSpeed), this, m_NonEngineSteerMinSpeed, value)) m_NonEngineSteerMinSpeed = value; } } // 0x5C (92)
		
		protected float m_NonEngineSteerMaxSpeed = new float();
		[ContainerField(Name: "NonEngineSteerMaxSpeed", Offset: 96, NameHash: 1082953922, Flags: 49469), LayoutImmutable, Blittable]
		public float NonEngineSteerMaxSpeed { get { return m_NonEngineSteerMaxSpeed; } set { if (OnPropertyChanging("HullFloatPhysicsData." + nameof(NonEngineSteerMaxSpeed), this, m_NonEngineSteerMaxSpeed, value)) m_NonEngineSteerMaxSpeed = value; } } // 0x60 (96)
		
		protected float m_WaterDampeningMod = new float();
		[ContainerField(Name: "WaterDampeningMod", Offset: 100, NameHash: 4227810501, Flags: 49469), LayoutImmutable, Blittable]
		public float WaterDampeningMod { get { return m_WaterDampeningMod; } set { if (OnPropertyChanging("HullFloatPhysicsData." + nameof(WaterDampeningMod), this, m_WaterDampeningMod, value)) m_WaterDampeningMod = value; } } // 0x64 (100)
		
		protected float m_LiftModifier = new float();
		[ContainerField(Name: "LiftModifier", Offset: 104, NameHash: 2708301317, Flags: 49469), LayoutImmutable, Blittable]
		public float LiftModifier { get { return m_LiftModifier; } set { if (OnPropertyChanging("HullFloatPhysicsData." + nameof(LiftModifier), this, m_LiftModifier, value)) m_LiftModifier = value; } } // 0x68 (104)
		
		protected float m_SupportSizeMod = new float();
		[ContainerField(Name: "SupportSizeMod", Offset: 108, NameHash: 115690313, Flags: 49469), LayoutImmutable, Blittable]
		public float SupportSizeMod { get { return m_SupportSizeMod; } set { if (OnPropertyChanging("HullFloatPhysicsData." + nameof(SupportSizeMod), this, m_SupportSizeMod, value)) m_SupportSizeMod = value; } } // 0x6C (108)
		
		protected float m_AngularDampening = new float();
		[ContainerField(Name: "AngularDampening", Offset: 112, NameHash: 705185012, Flags: 49469), LayoutImmutable, Blittable]
		public float AngularDampening { get { return m_AngularDampening; } set { if (OnPropertyChanging("HullFloatPhysicsData." + nameof(AngularDampening), this, m_AngularDampening, value)) m_AngularDampening = value; } } // 0x70 (112)
		
		protected float m_FrictionThrottleModifier = new float();
		[ContainerField(Name: "FrictionThrottleModifier", Offset: 116, NameHash: 2928282680, Flags: 49469), LayoutImmutable, Blittable]
		public float FrictionThrottleModifier { get { return m_FrictionThrottleModifier; } set { if (OnPropertyChanging("HullFloatPhysicsData." + nameof(FrictionThrottleModifier), this, m_FrictionThrottleModifier, value)) m_FrictionThrottleModifier = value; } } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3948471318:
					WaterResistanceAxisMod = (Vec3) p_Value;
					break;

				case 3626723959:
					WaterFrictionAxisMod = (Vec3) p_Value;
					break;

				case 2871410728:
					Offset = (Vec3) p_Value;
					break;

				case 1890108277:
					SubSurfaceSplits = (int) p_Value;
					break;

				case 208780552:
					Depth = (float) p_Value;
					break;

				case 226981187:
					Width = (float) p_Value;
					break;

				case 2906827577:
					Length = (float) p_Value;
					break;

				case 2319028903:
					FrontCurveDegree = (float) p_Value;
					break;

				case 2221634077:
					SideCurveDegree = (float) p_Value;
					break;

				case 2436950673:
					NonEngineSteer = (float) p_Value;
					break;

				case 625608988:
					NonEngineSteerMinSpeed = (float) p_Value;
					break;

				case 1082953922:
					NonEngineSteerMaxSpeed = (float) p_Value;
					break;

				case 4227810501:
					WaterDampeningMod = (float) p_Value;
					break;

				case 2708301317:
					LiftModifier = (float) p_Value;
					break;

				case 115690313:
					SupportSizeMod = (float) p_Value;
					break;

				case 705185012:
					AngularDampening = (float) p_Value;
					break;

				case 2928282680:
					FrictionThrottleModifier = (float) p_Value;
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
				case 3948471318:
					return WaterResistanceAxisMod;

				case 3626723959:
					return WaterFrictionAxisMod;

				case 2871410728:
					return Offset;

				case 1890108277:
					return SubSurfaceSplits;

				case 208780552:
					return Depth;

				case 226981187:
					return Width;

				case 2906827577:
					return Length;

				case 2319028903:
					return FrontCurveDegree;

				case 2221634077:
					return SideCurveDegree;

				case 2436950673:
					return NonEngineSteer;

				case 625608988:
					return NonEngineSteerMinSpeed;

				case 1082953922:
					return NonEngineSteerMaxSpeed;

				case 4227810501:
					return WaterDampeningMod;

				case 2708301317:
					return LiftModifier;

				case 115690313:
					return SupportSizeMod;

				case 705185012:
					return AngularDampening;

				case 2928282680:
					return FrictionThrottleModifier;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3948471318:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(WaterResistanceAxisMod));

				case 3626723959:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(WaterFrictionAxisMod));

				case 2871410728:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(Offset));

				case 1890108277:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(SubSurfaceSplits));

				case 208780552:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(Depth));

				case 226981187:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(Width));

				case 2906827577:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(Length));

				case 2319028903:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(FrontCurveDegree));

				case 2221634077:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(SideCurveDegree));

				case 2436950673:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(NonEngineSteer));

				case 625608988:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(NonEngineSteerMinSpeed));

				case 1082953922:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(NonEngineSteerMaxSpeed));

				case 4227810501:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(WaterDampeningMod));

				case 2708301317:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(LiftModifier));

				case 115690313:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(SupportSizeMod));

				case 705185012:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(AngularDampening));

				case 2928282680:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(FrictionThrottleModifier));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
