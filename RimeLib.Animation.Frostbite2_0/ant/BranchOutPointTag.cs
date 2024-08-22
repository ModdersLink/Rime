///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// As type schemas dont contain full information, modifying  //
// can be done to fix information thats wrong or missing.    //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using RimeLib.Animation.EA.Attributes;
using RimeLib.Animation.EA.Types;

namespace ant
{

	[AntBinding(0xbf7ec369)]
	public class BranchOutPointTag
		: AntObject
	{
		[AntField(0)]
		public float Time { get; set; }

		[AntField(1)]
		public float Length { get; set; }

		[AntField(2)]
		public float StartTuningOffset { get; set; }

		[AntField(3)]
		public float EndTuningOffset { get; set; }

		[AntField(4)]
		public float Trigger { get; set; }

		[AntField(5)]
		public bool Active { get; set; }

		[AntField(6)]
		public IdRef<BlendCurveAsset> BlendAsset { get; set; } = new();

		[AntField(7)]
		public IdRef<BranchTypeAsset> BranchTypeAsset { get; set; } = new();

		[AntField(8)]
		public IdRef<ClipInitParam> TargetInitParam { get; set; } = new();

		[AntField(9)]
		public IdRef<StreetMoveGroupControllerAsset> TargetAsset { get; set; } = new();

		[AntField(10)]
		public float fSpeed { get; set; }

		[AntField(11)]
		public float fMoveAngle { get; set; }

		[AntField(12)]
		public float fBodyAngle { get; set; }

		[AntField(13)]
		public AntVector3 posPlayer { get; set; } = new();

		[AntField(14)]
		public bool Buffered { get; set; }

		[AntField(15)]
		public float BufferStartTime { get; set; }

		[AntField(16)]
		public float BufferTuningOffset { get; set; }

		[AntField(17)]
		public float BufferLength { get; set; }

		[AntField(18)]
		public float DestinationPhase { get; set; }

		[AntField(19)]
		public float BufferTuningOffsetLength { get; set; }

		[AntField(20)]
		public float BranchInBufferDelay { get; set; }

	}
}
