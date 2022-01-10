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
	[ContainerType(4, 120)]
	public class SoldierAimingSimulationData : 
		GameDataContainer
	{
		[ContainerField(8)]
		public List<CtrRef<ZoomLevelData>> ZoomLevels { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public float ZoomTransitionTime { get; set; }

		[ContainerField(16)]
		public CtrRef<SoldierAimAssistData> AimAssist { get; set; } = new();

		[ContainerField(20)]
		public AimingPoseData StandPose { get; set; } = new();

		[ContainerField(44)]
		public AimingPoseData CrouchPose { get; set; } = new();

		[ContainerField(68)]
		public AimingPoseData PronePose { get; set; } = new();

		[ContainerField(92)]
		public List<ZoomLevelSpecificTransitionTime> ZoomTransitionTimeArray { get; set; } = new();

		[ContainerField(96), LayoutImmutable, Blittable]
		public float FovTransitionTime { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float FovDelayTime { get; set; }

		[ContainerField(104)]
		public List<CtrRef<AimerModifierData>> Modifiers { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public float AimingRange { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float LockAimToTargetSpeed { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public bool ReturnToZoomAfterReload { get; set; }

		public static void Deserialize(SoldierAimingSimulationData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ZoomLevels.Clear();
			(RimeReader Reader, uint Count) s_ZoomLevels = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ZoomLevels.Count; ++i)
			{
				var s_CtrRef = new CtrRef<ZoomLevelData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_ZoomLevels.Reader.ReadUInt32()));
				p_Instance.ZoomLevels.Add(s_CtrRef);
			}
			
			s_ZoomLevels.Reader.Dispose();
			p_Instance.ZoomTransitionTime = p_Reader.ReadSingle();
			p_Instance.AimAssist.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			fb.AimingPoseData.Deserialize(p_Instance.StandPose, p_Reader, p_Parser);
			fb.AimingPoseData.Deserialize(p_Instance.CrouchPose, p_Reader, p_Parser);
			fb.AimingPoseData.Deserialize(p_Instance.PronePose, p_Reader, p_Parser);
			p_Instance.ZoomTransitionTimeArray.Clear();
			(RimeReader Reader, uint Count) s_ZoomTransitionTimeArray = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ZoomTransitionTimeArray.Count; ++i)
			{
				var s_Value = new ZoomLevelSpecificTransitionTime();
				fb.ZoomLevelSpecificTransitionTime.Deserialize(s_Value, s_ZoomTransitionTimeArray.Reader, p_Parser);
				p_Instance.ZoomTransitionTimeArray.Add(s_Value);
			}
			
			s_ZoomTransitionTimeArray.Reader.Dispose();
			p_Instance.FovTransitionTime = p_Reader.ReadSingle();
			p_Instance.FovDelayTime = p_Reader.ReadSingle();
			p_Instance.Modifiers.Clear();
			(RimeReader Reader, uint Count) s_Modifiers = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Modifiers.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AimerModifierData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Modifiers.Reader.ReadUInt32()));
				p_Instance.Modifiers.Add(s_CtrRef);
			}
			
			s_Modifiers.Reader.Dispose();
			p_Instance.AimingRange = p_Reader.ReadSingle();
			p_Instance.LockAimToTargetSpeed = p_Reader.ReadSingle();
			p_Instance.ReturnToZoomAfterReload = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
