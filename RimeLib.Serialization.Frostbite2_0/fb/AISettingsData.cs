///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 80)]
	public partial class AISettingsData :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<SoundEnvironmentConstantData> _SoundEnvironmentConstants = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<CoverConstantData> _CoverConstants = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<DecisionConstantData> _DecisionConstants = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private CtrRef<PositionEvaluationConstantData> _PositionEvaluationConstants = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private CtrRef<TimingConstantData> _TimingConstants = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private CtrRef<DebugConstantData> _DebugConstants = new();

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private ReadinessLevels _ReadinessLevels = new();

		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private CtrRef<BehaviourTemplateData> _DefaultBehaviourTemplate = new();

		[ObservableProperty]
		[property: ContainerField(76), JsonProperty(Order = 76)]
		private CtrRef<AIVehicleBehaviourData> _DefaultVehicleType = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(SoundEnvironmentConstants));
			p_Writer.Write(p_EbxWriter.WriteImport(CoverConstants));
			p_Writer.Write(p_EbxWriter.WriteImport(DecisionConstants));
			p_Writer.Write(p_EbxWriter.WriteImport(PositionEvaluationConstants));
			p_Writer.Write(p_EbxWriter.WriteImport(TimingConstants));
			p_Writer.Write(p_EbxWriter.WriteImport(DebugConstants));
			ReadinessLevels.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(DefaultBehaviourTemplate));
			p_Writer.Write(p_EbxWriter.WriteImport(DefaultVehicleType));
		}
	}
}
