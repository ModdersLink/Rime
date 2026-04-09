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
	[ContainerType(16, 208)]
	public partial class SoldierTestEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private CtrRef<SoldierBlueprint> _TestSoldier = new();

		[ObservableProperty]
		[property: ContainerField(100), JsonProperty(Order = 100)]
		private CtrRef<SoldierSpawnTemplateData> _Template = new();

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private CtrRef<VehicleBlueprint> _TestVehicle = new();

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _SpecialAnimationIndex;

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private CtrRef<RawFileAsset> _UnlocksProfile = new();

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private TeamId _Team = new();

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private int _RandomSeed;

		[ObservableProperty]
		[property: ContainerField(124), JsonProperty(Order = 124)]
		private CtrRef<MovementActionData> _StartSequence = new();

		[ObservableProperty]
		[property: ContainerField(128), JsonProperty(Order = 128)]
		private CtrRef<MovementActionRoot> _StartSequenceRoot = new();

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _YawInputVal;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, JsonProperty(Order = 136)]
		private string _CameraMovementsFilename = string.Empty;

		[ObservableProperty]
		[property: ContainerField(140), JsonProperty(Order = 140)]
		private CtrRef<InputRecorderData> _InputRecorder = new();

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _ThrottleInputVal;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _FireInputVal;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _StrafeInputVal;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private float _ProneInputVal;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _PitchInputVal;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _RollInputVal;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private float _ZoomInputVal;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private float _JumpInputVal;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _ActiveInputRecording;

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private float _AuthoritativeAimingActive;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private float _FireCounterMeasure;

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private float _AuthoritativeYaw;

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private float _AuthoritativePitch;

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private bool _RunAutomatically;

		[ObservableProperty]
		[property: ContainerField(197), LayoutImmutable, Blittable, JsonProperty(Order = 197)]
		private bool _UseUnlocksProfile;

		[ObservableProperty]
		[property: ContainerField(198), LayoutImmutable, Blittable, JsonProperty(Order = 198)]
		private bool _SprintInputVal;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(TestSoldier));
			p_Writer.Write(p_EbxWriter.WriteImport(Template));
			p_Writer.Write(p_EbxWriter.WriteImport(TestVehicle));
			p_Writer.Write(SpecialAnimationIndex);
			p_Writer.Write(p_EbxWriter.WriteImport(UnlocksProfile));
			p_Writer.Write((int) Team);
			p_Writer.Write(RandomSeed);
			p_Writer.Write(p_EbxWriter.WriteImport(StartSequence));
			p_Writer.Write(p_EbxWriter.WriteImport(StartSequenceRoot));
			p_Writer.Write(YawInputVal);
			p_Writer.Write(p_EbxWriter.WriteString(CameraMovementsFilename));
			p_Writer.Write(p_EbxWriter.WriteImport(InputRecorder));
			p_Writer.Write(ThrottleInputVal);
			p_Writer.Write(FireInputVal);
			p_Writer.Write(StrafeInputVal);
			p_Writer.Write(ProneInputVal);
			p_Writer.Write(PitchInputVal);
			p_Writer.Write(RollInputVal);
			p_Writer.Write(ZoomInputVal);
			p_Writer.Write(JumpInputVal);
			p_Writer.Write(ActiveInputRecording);
			p_Writer.Write(AuthoritativeAimingActive);
			p_Writer.Write(FireCounterMeasure);
			p_Writer.Write(AuthoritativeYaw);
			p_Writer.Write(AuthoritativePitch);
			p_Writer.Write(RunAutomatically);
			p_Writer.Write(UseUnlocksProfile);
			p_Writer.Write(SprintInputVal);
			p_Writer.WriteNullBytes(9);
		}
	}
}
