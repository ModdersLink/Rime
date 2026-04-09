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
	[ContainerType(4, 120)]
	public partial class SoldierAimingSimulationData :
		GameDataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private RefArray<ZoomLevelData> _ZoomLevels = new();

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _ZoomTransitionTime;

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<SoldierAimAssistData> _AimAssist = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private AimingPoseData _StandPose = new();

		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private AimingPoseData _CrouchPose = new();

		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private AimingPoseData _PronePose = new();

		[ObservableProperty]
		[property: ContainerField(92), JsonProperty(Order = 92)]
		private List<ZoomLevelSpecificTransitionTime> _ZoomTransitionTimeArray = new();

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _FovTransitionTime;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _FovDelayTime;

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private RefArray<AimerModifierData> _Modifiers = new();

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _AimingRange;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _LockAimToTargetSpeed;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private bool _ReturnToZoomAfterReload;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_ZoomLevels = p_EbxWriter.GetArrayWriter(ZoomLevels.GetType(), ZoomLevels.Count);
			p_Writer.Write(s_ZoomLevels.ArrayIndex);
			foreach (var s_Entry in ZoomLevels)
			{
				s_ZoomLevels.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(ZoomTransitionTime);
			p_Writer.Write(p_EbxWriter.WriteImport(AimAssist));
			StandPose.Serialize(p_Writer, p_EbxWriter);
			CrouchPose.Serialize(p_Writer, p_EbxWriter);
			PronePose.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_ZoomTransitionTimeArray = p_EbxWriter.GetArrayWriter(ZoomTransitionTimeArray.GetType(), ZoomTransitionTimeArray.Count);
			p_Writer.Write(s_ZoomTransitionTimeArray.ArrayIndex);
			foreach (var s_Entry in ZoomTransitionTimeArray)
			{
				s_Entry.Serialize(s_ZoomTransitionTimeArray.Writer, p_EbxWriter);
			}
			p_Writer.Write(FovTransitionTime);
			p_Writer.Write(FovDelayTime);
			(RimeWriter Writer, uint ArrayIndex) s_Modifiers = p_EbxWriter.GetArrayWriter(Modifiers.GetType(), Modifiers.Count);
			p_Writer.Write(s_Modifiers.ArrayIndex);
			foreach (var s_Entry in Modifiers)
			{
				s_Modifiers.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(AimingRange);
			p_Writer.Write(LockAimToTargetSpeed);
			p_Writer.Write(ReturnToZoomAfterReload);
			p_Writer.WriteNullBytes(3);
		}
	}
}
