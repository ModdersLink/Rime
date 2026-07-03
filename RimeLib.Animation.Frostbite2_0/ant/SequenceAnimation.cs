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

	[AntBinding(0x4896fb08)]
	[AntBinding(0xa3d7b18c)] // BF3 alpha schema (adds Flags + Start/EndHoldTime)
	public class SequenceAnimation
		: AntObject
	{
		// BF3-alpha-only fields (dropped in retail; slots per the alpha reflection table).
		public int Flags { get; set; }
		public short StartHoldTime { get; set; }
		public short EndHoldTime { get; set; }

		[AntField(0)]
		public IdRef<ClipControllerAsset> Asset { get; set; } = new(); // ClipControllerAsset

		[AntField(1)]
		public IdRef<BlendCurveAsset> BlendAsset { get; set; } = new();

		[AntField(2)]
		public IdRef<ClipInitParam> InitParams { get; set; } = new();

		[AntField(3)]
		public IdRef<AntObject> AnimParams { get; set; } = new();

		[AntField(4)]
		public short StartTime { get; set; }

		[AntField(5)]
		public short StartInTime { get; set; }

		[AntField(6)]
		public short EndInTime { get; set; }

		[AntField(7)]
		public float Scale { get; set; }

	}
}
