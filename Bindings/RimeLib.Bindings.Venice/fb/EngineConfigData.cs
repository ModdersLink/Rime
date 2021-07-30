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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 96)]
	public class EngineConfigData : 
		DataContainer
	{
		protected Vec3 m_Position = new Vec3();
		[ContainerField(Name: "Position", Offset: 16, NameHash: 3402582524, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Position { get { return m_Position; } set { if (OnPropertyChanging("EngineConfigData." + nameof(Position), this, m_Position, value)) m_Position = value; } } // 0x10 (16)
		
		protected List<float> m_RpmCurvePoints = new List<float>();
		[ContainerField(Name: "RpmCurvePoints", Offset: 32, NameHash: 3171241218, Flags: 65)]
		public List<float> RpmCurvePoints { get { return m_RpmCurvePoints; } set { if (OnPropertyChanging("EngineConfigData." + nameof(RpmCurvePoints), this, m_RpmCurvePoints, value)) m_RpmCurvePoints = value; } } // 0x20 (32)
		
		protected List<float> m_TorqueCurvePoints = new List<float>();
		[ContainerField(Name: "TorqueCurvePoints", Offset: 36, NameHash: 3328974597, Flags: 65)]
		public List<float> TorqueCurvePoints { get { return m_TorqueCurvePoints; } set { if (OnPropertyChanging("EngineConfigData." + nameof(TorqueCurvePoints), this, m_TorqueCurvePoints, value)) m_TorqueCurvePoints = value; } } // 0x24 (36)
		
		protected float m_RpmMin = new float();
		[ContainerField(Name: "RpmMin", Offset: 40, NameHash: 3287857536, Flags: 49469), LayoutImmutable, Blittable]
		public float RpmMin { get { return m_RpmMin; } set { if (OnPropertyChanging("EngineConfigData." + nameof(RpmMin), this, m_RpmMin, value)) m_RpmMin = value; } } // 0x28 (40)
		
		protected float m_RpmMax = new float();
		[ContainerField(Name: "RpmMax", Offset: 44, NameHash: 3287857310, Flags: 49469), LayoutImmutable, Blittable]
		public float RpmMax { get { return m_RpmMax; } set { if (OnPropertyChanging("EngineConfigData." + nameof(RpmMax), this, m_RpmMax, value)) m_RpmMax = value; } } // 0x2C (44)
		
		protected float m_RpmCut = new float();
		[ContainerField(Name: "RpmCut", Offset: 48, NameHash: 3287864328, Flags: 49469), LayoutImmutable, Blittable]
		public float RpmCut { get { return m_RpmCut; } set { if (OnPropertyChanging("EngineConfigData." + nameof(RpmCut), this, m_RpmCut, value)) m_RpmCut = value; } } // 0x30 (48)
		
		protected float m_EnginePowerMultiplier = new float();
		[ContainerField(Name: "EnginePowerMultiplier", Offset: 52, NameHash: 3037532383, Flags: 49469), LayoutImmutable, Blittable]
		public float EnginePowerMultiplier { get { return m_EnginePowerMultiplier; } set { if (OnPropertyChanging("EngineConfigData." + nameof(EnginePowerMultiplier), this, m_EnginePowerMultiplier, value)) m_EnginePowerMultiplier = value; } } // 0x34 (52)
		
		protected float m_InternalAccelerationFactor = new float();
		[ContainerField(Name: "InternalAccelerationFactor", Offset: 56, NameHash: 1996992141, Flags: 49469), LayoutImmutable, Blittable]
		public float InternalAccelerationFactor { get { return m_InternalAccelerationFactor; } set { if (OnPropertyChanging("EngineConfigData." + nameof(InternalAccelerationFactor), this, m_InternalAccelerationFactor, value)) m_InternalAccelerationFactor = value; } } // 0x38 (56)
		
		protected float m_InternalDeaccelerationFactor = new float();
		[ContainerField(Name: "InternalDeaccelerationFactor", Offset: 60, NameHash: 820379788, Flags: 49469), LayoutImmutable, Blittable]
		public float InternalDeaccelerationFactor { get { return m_InternalDeaccelerationFactor; } set { if (OnPropertyChanging("EngineConfigData." + nameof(InternalDeaccelerationFactor), this, m_InternalDeaccelerationFactor, value)) m_InternalDeaccelerationFactor = value; } } // 0x3C (60)
		
		protected Boost m_Boost = new Boost();
		[ContainerField(Name: "Boost", Offset: 64, NameHash: 211344160, Flags: 41)]
		public Boost Boost { get { return m_Boost; } set { if (OnPropertyChanging("EngineConfigData." + nameof(Boost), this, m_Boost, value)) m_Boost = value; } } // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3402582524:
					Position = (Vec3) p_Value;
					break;

				case 3171241218:
					RpmCurvePoints = (List<float>) p_Value;
					break;

				case 3328974597:
					TorqueCurvePoints = (List<float>) p_Value;
					break;

				case 3287857536:
					RpmMin = (float) p_Value;
					break;

				case 3287857310:
					RpmMax = (float) p_Value;
					break;

				case 3287864328:
					RpmCut = (float) p_Value;
					break;

				case 3037532383:
					EnginePowerMultiplier = (float) p_Value;
					break;

				case 1996992141:
					InternalAccelerationFactor = (float) p_Value;
					break;

				case 820379788:
					InternalDeaccelerationFactor = (float) p_Value;
					break;

				case 211344160:
					Boost = (Boost) p_Value;
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
				case 3402582524:
					return Position;

				case 3171241218:
					return RpmCurvePoints;

				case 3328974597:
					return TorqueCurvePoints;

				case 3287857536:
					return RpmMin;

				case 3287857310:
					return RpmMax;

				case 3287864328:
					return RpmCut;

				case 3037532383:
					return EnginePowerMultiplier;

				case 1996992141:
					return InternalAccelerationFactor;

				case 820379788:
					return InternalDeaccelerationFactor;

				case 211344160:
					return Boost;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3402582524:
					return typeof(EngineConfigData).GetProperty(nameof(Position));

				case 3171241218:
					return typeof(EngineConfigData).GetProperty(nameof(RpmCurvePoints));

				case 3328974597:
					return typeof(EngineConfigData).GetProperty(nameof(TorqueCurvePoints));

				case 3287857536:
					return typeof(EngineConfigData).GetProperty(nameof(RpmMin));

				case 3287857310:
					return typeof(EngineConfigData).GetProperty(nameof(RpmMax));

				case 3287864328:
					return typeof(EngineConfigData).GetProperty(nameof(RpmCut));

				case 3037532383:
					return typeof(EngineConfigData).GetProperty(nameof(EnginePowerMultiplier));

				case 1996992141:
					return typeof(EngineConfigData).GetProperty(nameof(InternalAccelerationFactor));

				case 820379788:
					return typeof(EngineConfigData).GetProperty(nameof(InternalDeaccelerationFactor));

				case 211344160:
					return typeof(EngineConfigData).GetProperty(nameof(Boost));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
