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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 80)]
	public class AISettingsData :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<SoundEnvironmentConstantData> SoundEnvironmentConstants { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<CoverConstantData> CoverConstants { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<DecisionConstantData> DecisionConstants { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<PositionEvaluationConstantData> PositionEvaluationConstants { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public CtrRef<TimingConstantData> TimingConstants { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public CtrRef<DebugConstantData> DebugConstants { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public ReadinessLevels ReadinessLevels { get; set; } = new();

		[ContainerField(72), JsonProperty(Order = 72)]
		public CtrRef<BehaviourTemplateData> DefaultBehaviourTemplate { get; set; } = new();

		[ContainerField(76), JsonProperty(Order = 76)]
		public CtrRef<AIVehicleBehaviourData> DefaultVehicleType { get; set; } = new();

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
