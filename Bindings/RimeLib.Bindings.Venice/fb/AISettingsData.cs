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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 80)]
	public class AISettingsData : 
		Asset
	{
		protected CtrRef<SoundEnvironmentConstantData> m_SoundEnvironmentConstants = new CtrRef<SoundEnvironmentConstantData>();
		[ContainerField(Name: "SoundEnvironmentConstants", Offset: 12, NameHash: 2871470526, Flags: 53)]
		public CtrRef<SoundEnvironmentConstantData> SoundEnvironmentConstants { get { return m_SoundEnvironmentConstants; } set { if (OnPropertyChanging("AISettingsData." + nameof(SoundEnvironmentConstants), this, m_SoundEnvironmentConstants, value)) m_SoundEnvironmentConstants = value; } } // 0xC (12)
		
		protected CtrRef<CoverConstantData> m_CoverConstants = new CtrRef<CoverConstantData>();
		[ContainerField(Name: "CoverConstants", Offset: 16, NameHash: 1484010501, Flags: 53)]
		public CtrRef<CoverConstantData> CoverConstants { get { return m_CoverConstants; } set { if (OnPropertyChanging("AISettingsData." + nameof(CoverConstants), this, m_CoverConstants, value)) m_CoverConstants = value; } } // 0x10 (16)
		
		protected CtrRef<DecisionConstantData> m_DecisionConstants = new CtrRef<DecisionConstantData>();
		[ContainerField(Name: "DecisionConstants", Offset: 20, NameHash: 4064192024, Flags: 53)]
		public CtrRef<DecisionConstantData> DecisionConstants { get { return m_DecisionConstants; } set { if (OnPropertyChanging("AISettingsData." + nameof(DecisionConstants), this, m_DecisionConstants, value)) m_DecisionConstants = value; } } // 0x14 (20)
		
		protected CtrRef<PositionEvaluationConstantData> m_PositionEvaluationConstants = new CtrRef<PositionEvaluationConstantData>();
		[ContainerField(Name: "PositionEvaluationConstants", Offset: 24, NameHash: 3298295975, Flags: 53)]
		public CtrRef<PositionEvaluationConstantData> PositionEvaluationConstants { get { return m_PositionEvaluationConstants; } set { if (OnPropertyChanging("AISettingsData." + nameof(PositionEvaluationConstants), this, m_PositionEvaluationConstants, value)) m_PositionEvaluationConstants = value; } } // 0x18 (24)
		
		protected CtrRef<TimingConstantData> m_TimingConstants = new CtrRef<TimingConstantData>();
		[ContainerField(Name: "TimingConstants", Offset: 28, NameHash: 3077725272, Flags: 53)]
		public CtrRef<TimingConstantData> TimingConstants { get { return m_TimingConstants; } set { if (OnPropertyChanging("AISettingsData." + nameof(TimingConstants), this, m_TimingConstants, value)) m_TimingConstants = value; } } // 0x1C (28)
		
		protected CtrRef<DebugConstantData> m_DebugConstants = new CtrRef<DebugConstantData>();
		[ContainerField(Name: "DebugConstants", Offset: 32, NameHash: 565110489, Flags: 53)]
		public CtrRef<DebugConstantData> DebugConstants { get { return m_DebugConstants; } set { if (OnPropertyChanging("AISettingsData." + nameof(DebugConstants), this, m_DebugConstants, value)) m_DebugConstants = value; } } // 0x20 (32)
		
		protected ReadinessLevels m_ReadinessLevels = new ReadinessLevels();
		[ContainerField(Name: "ReadinessLevels", Offset: 36, NameHash: 4061966096, Flags: 41)]
		public ReadinessLevels ReadinessLevels { get { return m_ReadinessLevels; } set { if (OnPropertyChanging("AISettingsData." + nameof(ReadinessLevels), this, m_ReadinessLevels, value)) m_ReadinessLevels = value; } } // 0x24 (36)
		
		protected CtrRef<BehaviourTemplateData> m_DefaultBehaviourTemplate = new CtrRef<BehaviourTemplateData>();
		[ContainerField(Name: "DefaultBehaviourTemplate", Offset: 72, NameHash: 1055461031, Flags: 53)]
		public CtrRef<BehaviourTemplateData> DefaultBehaviourTemplate { get { return m_DefaultBehaviourTemplate; } set { if (OnPropertyChanging("AISettingsData." + nameof(DefaultBehaviourTemplate), this, m_DefaultBehaviourTemplate, value)) m_DefaultBehaviourTemplate = value; } } // 0x48 (72)
		
		protected CtrRef<AIVehicleBehaviourData> m_DefaultVehicleType = new CtrRef<AIVehicleBehaviourData>();
		[ContainerField(Name: "DefaultVehicleType", Offset: 76, NameHash: 2788836174, Flags: 53)]
		public CtrRef<AIVehicleBehaviourData> DefaultVehicleType { get { return m_DefaultVehicleType; } set { if (OnPropertyChanging("AISettingsData." + nameof(DefaultVehicleType), this, m_DefaultVehicleType, value)) m_DefaultVehicleType = value; } } // 0x4C (76)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2871470526:
					SoundEnvironmentConstants = (CtrRef<SoundEnvironmentConstantData>) p_Value;
					break;

				case 1484010501:
					CoverConstants = (CtrRef<CoverConstantData>) p_Value;
					break;

				case 4064192024:
					DecisionConstants = (CtrRef<DecisionConstantData>) p_Value;
					break;

				case 3298295975:
					PositionEvaluationConstants = (CtrRef<PositionEvaluationConstantData>) p_Value;
					break;

				case 3077725272:
					TimingConstants = (CtrRef<TimingConstantData>) p_Value;
					break;

				case 565110489:
					DebugConstants = (CtrRef<DebugConstantData>) p_Value;
					break;

				case 4061966096:
					ReadinessLevels = (ReadinessLevels) p_Value;
					break;

				case 1055461031:
					DefaultBehaviourTemplate = (CtrRef<BehaviourTemplateData>) p_Value;
					break;

				case 2788836174:
					DefaultVehicleType = (CtrRef<AIVehicleBehaviourData>) p_Value;
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
				case 2871470526:
					return SoundEnvironmentConstants;

				case 1484010501:
					return CoverConstants;

				case 4064192024:
					return DecisionConstants;

				case 3298295975:
					return PositionEvaluationConstants;

				case 3077725272:
					return TimingConstants;

				case 565110489:
					return DebugConstants;

				case 4061966096:
					return ReadinessLevels;

				case 1055461031:
					return DefaultBehaviourTemplate;

				case 2788836174:
					return DefaultVehicleType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2871470526:
					return typeof(AISettingsData).GetProperty(nameof(SoundEnvironmentConstants));

				case 1484010501:
					return typeof(AISettingsData).GetProperty(nameof(CoverConstants));

				case 4064192024:
					return typeof(AISettingsData).GetProperty(nameof(DecisionConstants));

				case 3298295975:
					return typeof(AISettingsData).GetProperty(nameof(PositionEvaluationConstants));

				case 3077725272:
					return typeof(AISettingsData).GetProperty(nameof(TimingConstants));

				case 565110489:
					return typeof(AISettingsData).GetProperty(nameof(DebugConstants));

				case 4061966096:
					return typeof(AISettingsData).GetProperty(nameof(ReadinessLevels));

				case 1055461031:
					return typeof(AISettingsData).GetProperty(nameof(DefaultBehaviourTemplate));

				case 2788836174:
					return typeof(AISettingsData).GetProperty(nameof(DefaultVehicleType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
