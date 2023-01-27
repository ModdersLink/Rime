///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// As type schemas dont contain full information, modifying  //
// can be done to fix information thats wrong or missing.    //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using RimeLib.Ant.EA.Attributes;
using RimeLib.Ant.EA.Types;

namespace ant
{

	[AntBinding(0xc3c86622)]
	public class WarpAsset
		: AntObject
	{
		[AntField(0)]
		public float DeltaT { get; set; }

		[AntField(1)]
		public float StartT { get; set; }

		[AntField(2)]
		public int StartRunStyle { get; set; }

		[AntField(3)]
		public int EndRunStyle { get; set; }

		[AntField(4)]
		public float EndPhase { get; set; }

		[AntField(5)]
		public int MoveTurnDir { get; set; }

		[AntField(6)]
		public int ShoulderTurnDir { get; set; }

		[AntField(7)]
		public float Urgency { get; set; }

		[AntField(8)]
		public float HoldPoseT { get; set; }

		[AntField(9)]
		public float PositiveExtensionOverride { get; set; }

		[AntField(10)]
		public float NegativeExtensionOverride { get; set; }

		[AntField(11)]
		public bool PositiveExtensionApplyOverride { get; set; }

		[AntField(12)]
		public bool NegativeExtensionApplyOverride { get; set; }

		[AntField(13)]
		public float PositiveMaxYWarp { get; set; }

		[AntField(14)]
		public float NegativeMaxYWarp { get; set; }

		[AntField(15)]
		public int NumTouchRegionSpeeds { get; set; }

		[AntField(16)]
		public int NumTouchRegionTouchTimes { get; set; }

		[AntField(17)]
		public List<AntObject?> TouchRegions { get; set; } = new();

		[AntField(18)]
		public List<float> TouchTimes { get; set; } = new();

		[AntField(19)]
		public int TouchSeg { get; set; }

		[AntField(20)]
		public AntVector3 TouchPosition { get; set; } = new();

		[AntField(21)]
		public float BonusRotation { get; set; }

		[AntField(22)]
		public int NumSegments { get; set; }

		[AntField(23)]
		public List<WarpSegment?> Segments { get; set; } = new();

		[AntField(24)]
		public int LenPosition { get; set; }

		[AntField(25)]
		public List<AntVector4> Pose { get; set; } = new();

	}
}
