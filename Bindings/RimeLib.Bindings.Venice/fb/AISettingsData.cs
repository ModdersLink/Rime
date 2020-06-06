///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class AISettingsData : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<SoundEnvironmentConstantData> SoundEnvironmentConstants { get; set; } = new CtrRef<SoundEnvironmentConstantData>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<CoverConstantData> CoverConstants { get; set; } = new CtrRef<CoverConstantData>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<DecisionConstantData> DecisionConstants { get; set; } = new CtrRef<DecisionConstantData>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<PositionEvaluationConstantData> PositionEvaluationConstants { get; set; } = new CtrRef<PositionEvaluationConstantData>(); // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<TimingConstantData> TimingConstants { get; set; } = new CtrRef<TimingConstantData>(); // 0x1C (28)
		
		[ContainerField(32)]
		public CtrRef<DebugConstantData> DebugConstants { get; set; } = new CtrRef<DebugConstantData>(); // 0x20 (32)
		
		[ContainerField(36)]
		public ReadinessLevels ReadinessLevels { get; set; } = new ReadinessLevels(); // 0x24 (36)
		
		[ContainerField(72)]
		public CtrRef<BehaviourTemplateData> DefaultBehaviourTemplate { get; set; } = new CtrRef<BehaviourTemplateData>(); // 0x48 (72)
		
		[ContainerField(76)]
		public CtrRef<AIVehicleBehaviourData> DefaultVehicleType { get; set; } = new CtrRef<AIVehicleBehaviourData>(); // 0x4C (76)
		
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
