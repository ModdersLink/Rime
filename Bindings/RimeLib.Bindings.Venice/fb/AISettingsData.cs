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

		public static void Deserialize(AISettingsData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SoundEnvironmentConstants.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.CoverConstants.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.DecisionConstants.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.PositionEvaluationConstants.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.TimingConstants.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.DebugConstants.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			fb.ReadinessLevels.Deserialize(p_Instance.ReadinessLevels, p_Reader, p_Parser);
			p_Instance.DefaultBehaviourTemplate.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.DefaultVehicleType.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
