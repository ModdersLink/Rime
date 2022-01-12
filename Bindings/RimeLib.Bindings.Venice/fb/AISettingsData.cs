///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 80)]
	public class AISettingsData : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<SoundEnvironmentConstantData> SoundEnvironmentConstants { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<CoverConstantData> CoverConstants { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<DecisionConstantData> DecisionConstants { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<PositionEvaluationConstantData> PositionEvaluationConstants { get; set; } = new();

		[ContainerField(28)]
		public CtrRef<TimingConstantData> TimingConstants { get; set; } = new();

		[ContainerField(32)]
		public CtrRef<DebugConstantData> DebugConstants { get; set; } = new();

		[ContainerField(36)]
		public ReadinessLevels ReadinessLevels { get; set; } = new();

		[ContainerField(72)]
		public CtrRef<BehaviourTemplateData> DefaultBehaviourTemplate { get; set; } = new();

		[ContainerField(76)]
		public CtrRef<AIVehicleBehaviourData> DefaultVehicleType { get; set; } = new();

	}
}
