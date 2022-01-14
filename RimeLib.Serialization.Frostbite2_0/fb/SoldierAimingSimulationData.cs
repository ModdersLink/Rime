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
	[ContainerType(4, 120)]
	public class SoldierAimingSimulationData :
		GameDataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public RefArray<ZoomLevelData> ZoomLevels { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float ZoomTransitionTime { get; set; }

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<SoldierAimAssistData> AimAssist { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public AimingPoseData StandPose { get; set; } = new();

		[ContainerField(44), JsonProperty(Order = 44)]
		public AimingPoseData CrouchPose { get; set; } = new();

		[ContainerField(68), JsonProperty(Order = 68)]
		public AimingPoseData PronePose { get; set; } = new();

		[ContainerField(92), JsonProperty(Order = 92)]
		public List<ZoomLevelSpecificTransitionTime> ZoomTransitionTimeArray { get; set; } = new();

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float FovTransitionTime { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float FovDelayTime { get; set; }

		[ContainerField(104), JsonProperty(Order = 104)]
		public RefArray<AimerModifierData> Modifiers { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float AimingRange { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float LockAimToTargetSpeed { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public bool ReturnToZoomAfterReload { get; set; }

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
