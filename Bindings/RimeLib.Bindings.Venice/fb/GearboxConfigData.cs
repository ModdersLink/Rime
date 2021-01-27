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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 64)]
	public class GearboxConfigData : 
		DataContainer
	{
		protected List<float> m_ForwardGearRatios = new List<float>();
		[ContainerField(Name: "ForwardGearRatios", Offset: 8, NameHash: 3289089437, Flags: 65)]
		public List<float> ForwardGearRatios { get { return m_ForwardGearRatios; } set { if (OnPropertyChanging("GearboxConfigData." + nameof(ForwardGearRatios), this, m_ForwardGearRatios, value)) m_ForwardGearRatios = value; } } // 0x8 (8)
		
		protected List<float> m_ForwardGearSpeeds = new List<float>();
		[ContainerField(Name: "ForwardGearSpeeds", Offset: 12, NameHash: 3306387643, Flags: 65)]
		public List<float> ForwardGearSpeeds { get { return m_ForwardGearSpeeds; } set { if (OnPropertyChanging("GearboxConfigData." + nameof(ForwardGearSpeeds), this, m_ForwardGearSpeeds, value)) m_ForwardGearSpeeds = value; } } // 0xC (12)
		
		protected List<float> m_ReverseGearRatios = new List<float>();
		[ContainerField(Name: "ReverseGearRatios", Offset: 16, NameHash: 180205926, Flags: 65)]
		public List<float> ReverseGearRatios { get { return m_ReverseGearRatios; } set { if (OnPropertyChanging("GearboxConfigData." + nameof(ReverseGearRatios), this, m_ReverseGearRatios, value)) m_ReverseGearRatios = value; } } // 0x10 (16)
		
		protected List<float> m_ReverseGearSpeeds = new List<float>();
		[ContainerField(Name: "ReverseGearSpeeds", Offset: 20, NameHash: 162915904, Flags: 65)]
		public List<float> ReverseGearSpeeds { get { return m_ReverseGearSpeeds; } set { if (OnPropertyChanging("GearboxConfigData." + nameof(ReverseGearSpeeds), this, m_ReverseGearSpeeds, value)) m_ReverseGearSpeeds = value; } } // 0x14 (20)
		
		protected int m_GearboxType = new int();
		[ContainerField(Name: "GearboxType", Offset: 24, NameHash: 1540232153, Flags: 49405), LayoutImmutable, Blittable]
		public int GearboxType { get { return m_GearboxType; } set { if (OnPropertyChanging("GearboxConfigData." + nameof(GearboxType), this, m_GearboxType, value)) m_GearboxType = value; } } // 0x18 (24)
		
		protected int m_GearboxMode = new int();
		[ContainerField(Name: "GearboxMode", Offset: 28, NameHash: 1539978082, Flags: 49405), LayoutImmutable, Blittable]
		public int GearboxMode { get { return m_GearboxMode; } set { if (OnPropertyChanging("GearboxConfigData." + nameof(GearboxMode), this, m_GearboxMode, value)) m_GearboxMode = value; } } // 0x1C (28)
		
		protected float m_GearChangeTime = new float();
		[ContainerField(Name: "GearChangeTime", Offset: 32, NameHash: 2688527911, Flags: 49469), LayoutImmutable, Blittable]
		public float GearChangeTime { get { return m_GearChangeTime; } set { if (OnPropertyChanging("GearboxConfigData." + nameof(GearChangeTime), this, m_GearChangeTime, value)) m_GearChangeTime = value; } } // 0x20 (32)
		
		protected float m_GearDownSpeedFactor = new float();
		[ContainerField(Name: "GearDownSpeedFactor", Offset: 36, NameHash: 699099436, Flags: 49469), LayoutImmutable, Blittable]
		public float GearDownSpeedFactor { get { return m_GearDownSpeedFactor; } set { if (OnPropertyChanging("GearboxConfigData." + nameof(GearDownSpeedFactor), this, m_GearDownSpeedFactor, value)) m_GearDownSpeedFactor = value; } } // 0x24 (36)
		
		protected float m_OppositeDirGearChangeMaxSpeed = new float();
		[ContainerField(Name: "OppositeDirGearChangeMaxSpeed", Offset: 40, NameHash: 3344611765, Flags: 49469), LayoutImmutable, Blittable]
		public float OppositeDirGearChangeMaxSpeed { get { return m_OppositeDirGearChangeMaxSpeed; } set { if (OnPropertyChanging("GearboxConfigData." + nameof(OppositeDirGearChangeMaxSpeed), this, m_OppositeDirGearChangeMaxSpeed, value)) m_OppositeDirGearChangeMaxSpeed = value; } } // 0x28 (40)
		
		protected float m_OppositeDirGearChangeTime = new float();
		[ContainerField(Name: "OppositeDirGearChangeTime", Offset: 44, NameHash: 777981235, Flags: 49469), LayoutImmutable, Blittable]
		public float OppositeDirGearChangeTime { get { return m_OppositeDirGearChangeTime; } set { if (OnPropertyChanging("GearboxConfigData." + nameof(OppositeDirGearChangeTime), this, m_OppositeDirGearChangeTime, value)) m_OppositeDirGearChangeTime = value; } } // 0x2C (44)
		
		protected float m_ClutchSpeedFactor = new float();
		[ContainerField(Name: "ClutchSpeedFactor", Offset: 48, NameHash: 1429608074, Flags: 49469), LayoutImmutable, Blittable]
		public float ClutchSpeedFactor { get { return m_ClutchSpeedFactor; } set { if (OnPropertyChanging("GearboxConfigData." + nameof(ClutchSpeedFactor), this, m_ClutchSpeedFactor, value)) m_ClutchSpeedFactor = value; } } // 0x30 (48)
		
		protected float m_TransmissionEfficiency = new float();
		[ContainerField(Name: "TransmissionEfficiency", Offset: 52, NameHash: 846717476, Flags: 49469), LayoutImmutable, Blittable]
		public float TransmissionEfficiency { get { return m_TransmissionEfficiency; } set { if (OnPropertyChanging("GearboxConfigData." + nameof(TransmissionEfficiency), this, m_TransmissionEfficiency, value)) m_TransmissionEfficiency = value; } } // 0x34 (52)
		
		protected float m_BackwardThrottleLimit = new float();
		[ContainerField(Name: "BackwardThrottleLimit", Offset: 56, NameHash: 3691491475, Flags: 49469), LayoutImmutable, Blittable]
		public float BackwardThrottleLimit { get { return m_BackwardThrottleLimit; } set { if (OnPropertyChanging("GearboxConfigData." + nameof(BackwardThrottleLimit), this, m_BackwardThrottleLimit, value)) m_BackwardThrottleLimit = value; } } // 0x38 (56)
		
		protected bool m_UseClassicGearBoxAutoClutch = new bool();
		[ContainerField(Name: "UseClassicGearBoxAutoClutch", Offset: 60, NameHash: 1239657644, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseClassicGearBoxAutoClutch { get { return m_UseClassicGearBoxAutoClutch; } set { if (OnPropertyChanging("GearboxConfigData." + nameof(UseClassicGearBoxAutoClutch), this, m_UseClassicGearBoxAutoClutch, value)) m_UseClassicGearBoxAutoClutch = value; } } // 0x3C (60)
		
		protected bool m_UseNeutralGear = new bool();
		[ContainerField(Name: "UseNeutralGear", Offset: 61, NameHash: 3124815010, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseNeutralGear { get { return m_UseNeutralGear; } set { if (OnPropertyChanging("GearboxConfigData." + nameof(UseNeutralGear), this, m_UseNeutralGear, value)) m_UseNeutralGear = value; } } // 0x3D (61)
		
		protected bool m_LimitBackwardThrottle = new bool();
		[ContainerField(Name: "LimitBackwardThrottle", Offset: 62, NameHash: 3340732019, Flags: 49325), LayoutImmutable, Blittable]
		public bool LimitBackwardThrottle { get { return m_LimitBackwardThrottle; } set { if (OnPropertyChanging("GearboxConfigData." + nameof(LimitBackwardThrottle), this, m_LimitBackwardThrottle, value)) m_LimitBackwardThrottle = value; } } // 0x3E (62)
		
		protected bool m_UseAutoClutch = new bool();
		[ContainerField(Name: "UseAutoClutch", Offset: 63, NameHash: 3208098444, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseAutoClutch { get { return m_UseAutoClutch; } set { if (OnPropertyChanging("GearboxConfigData." + nameof(UseAutoClutch), this, m_UseAutoClutch, value)) m_UseAutoClutch = value; } } // 0x3F (63)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3289089437:
					ForwardGearRatios = (List<float>) p_Value;
					break;

				case 3306387643:
					ForwardGearSpeeds = (List<float>) p_Value;
					break;

				case 180205926:
					ReverseGearRatios = (List<float>) p_Value;
					break;

				case 162915904:
					ReverseGearSpeeds = (List<float>) p_Value;
					break;

				case 1540232153:
					GearboxType = (int) p_Value;
					break;

				case 1539978082:
					GearboxMode = (int) p_Value;
					break;

				case 2688527911:
					GearChangeTime = (float) p_Value;
					break;

				case 699099436:
					GearDownSpeedFactor = (float) p_Value;
					break;

				case 3344611765:
					OppositeDirGearChangeMaxSpeed = (float) p_Value;
					break;

				case 777981235:
					OppositeDirGearChangeTime = (float) p_Value;
					break;

				case 1429608074:
					ClutchSpeedFactor = (float) p_Value;
					break;

				case 846717476:
					TransmissionEfficiency = (float) p_Value;
					break;

				case 3691491475:
					BackwardThrottleLimit = (float) p_Value;
					break;

				case 1239657644:
					UseClassicGearBoxAutoClutch = (bool) p_Value;
					break;

				case 3124815010:
					UseNeutralGear = (bool) p_Value;
					break;

				case 3340732019:
					LimitBackwardThrottle = (bool) p_Value;
					break;

				case 3208098444:
					UseAutoClutch = (bool) p_Value;
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
				case 3289089437:
					return ForwardGearRatios;

				case 3306387643:
					return ForwardGearSpeeds;

				case 180205926:
					return ReverseGearRatios;

				case 162915904:
					return ReverseGearSpeeds;

				case 1540232153:
					return GearboxType;

				case 1539978082:
					return GearboxMode;

				case 2688527911:
					return GearChangeTime;

				case 699099436:
					return GearDownSpeedFactor;

				case 3344611765:
					return OppositeDirGearChangeMaxSpeed;

				case 777981235:
					return OppositeDirGearChangeTime;

				case 1429608074:
					return ClutchSpeedFactor;

				case 846717476:
					return TransmissionEfficiency;

				case 3691491475:
					return BackwardThrottleLimit;

				case 1239657644:
					return UseClassicGearBoxAutoClutch;

				case 3124815010:
					return UseNeutralGear;

				case 3340732019:
					return LimitBackwardThrottle;

				case 3208098444:
					return UseAutoClutch;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3289089437:
					return typeof(GearboxConfigData).GetProperty(nameof(ForwardGearRatios));

				case 3306387643:
					return typeof(GearboxConfigData).GetProperty(nameof(ForwardGearSpeeds));

				case 180205926:
					return typeof(GearboxConfigData).GetProperty(nameof(ReverseGearRatios));

				case 162915904:
					return typeof(GearboxConfigData).GetProperty(nameof(ReverseGearSpeeds));

				case 1540232153:
					return typeof(GearboxConfigData).GetProperty(nameof(GearboxType));

				case 1539978082:
					return typeof(GearboxConfigData).GetProperty(nameof(GearboxMode));

				case 2688527911:
					return typeof(GearboxConfigData).GetProperty(nameof(GearChangeTime));

				case 699099436:
					return typeof(GearboxConfigData).GetProperty(nameof(GearDownSpeedFactor));

				case 3344611765:
					return typeof(GearboxConfigData).GetProperty(nameof(OppositeDirGearChangeMaxSpeed));

				case 777981235:
					return typeof(GearboxConfigData).GetProperty(nameof(OppositeDirGearChangeTime));

				case 1429608074:
					return typeof(GearboxConfigData).GetProperty(nameof(ClutchSpeedFactor));

				case 846717476:
					return typeof(GearboxConfigData).GetProperty(nameof(TransmissionEfficiency));

				case 3691491475:
					return typeof(GearboxConfigData).GetProperty(nameof(BackwardThrottleLimit));

				case 1239657644:
					return typeof(GearboxConfigData).GetProperty(nameof(UseClassicGearBoxAutoClutch));

				case 3124815010:
					return typeof(GearboxConfigData).GetProperty(nameof(UseNeutralGear));

				case 3340732019:
					return typeof(GearboxConfigData).GetProperty(nameof(LimitBackwardThrottle));

				case 3208098444:
					return typeof(GearboxConfigData).GetProperty(nameof(UseAutoClutch));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
