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
	[ContainerType(16, 144)]
	public partial class ChassisComponentData :
		PartComponentData
	{
		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private CtrRef<VehicleConfigData> _VehicleConfig = new();

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private CtrRef<GearboxConfigData> _GearboxConfig = new();

		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private RefArray<VehicleWaterEffectData> _WaterStreakEffects = new();

		[ObservableProperty]
		[property: ContainerField(124), JsonProperty(Order = 124)]
		private RefArray<VehicleWaterEffectData> _WaterEffects = new();

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _TriggerGroundEffectImpulse;

		[ObservableProperty]
		[property: ContainerField(132), JsonProperty(Order = 132)]
		private CtrRef<LandingGearLogicData> _LandingGearLogic = new();

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private bool _AlwaysFullThrottle;

		[ObservableProperty]
		[property: ContainerField(137), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
		private bool _ForceLandingGearsRetract;

		[ObservableProperty]
		[property: ContainerField(138), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
		private bool _AllowNegativeThrottle;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(VehicleConfig));
			p_Writer.Write(p_EbxWriter.WriteImport(GearboxConfig));
			(RimeWriter Writer, uint ArrayIndex) s_WaterStreakEffects = p_EbxWriter.GetArrayWriter(WaterStreakEffects.GetType(), WaterStreakEffects.Count);
			p_Writer.Write(s_WaterStreakEffects.ArrayIndex);
			foreach (var s_Entry in WaterStreakEffects)
			{
				s_WaterStreakEffects.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_WaterEffects = p_EbxWriter.GetArrayWriter(WaterEffects.GetType(), WaterEffects.Count);
			p_Writer.Write(s_WaterEffects.ArrayIndex);
			foreach (var s_Entry in WaterEffects)
			{
				s_WaterEffects.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(TriggerGroundEffectImpulse);
			p_Writer.Write(p_EbxWriter.WriteImport(LandingGearLogic));
			p_Writer.Write(AlwaysFullThrottle);
			p_Writer.Write(ForceLandingGearsRetract);
			p_Writer.Write(AllowNegativeThrottle);
			p_Writer.WriteNullBytes(5);
		}
	}
}
