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

	[AntBinding(0xb0644356)]
	public class WarpSegment
		: AntObject
	{
		[AntField(0)]
		public int Type { get; set; }

		[AntField(1)]
		public float StartT { get; set; }

		[AntField(2)]
		public float EndT { get; set; }

		[AntField(3)]
		public float NormalizedT { get; set; }

		[AntField(4)]
		public float StartMoveAngle { get; set; }

		[AntField(5)]
		public float EndMoveAngle { get; set; }

		[AntField(6)]
		public float StartSpeed { get; set; }

		[AntField(7)]
		public float EndSpeed { get; set; }

		[AntField(8)]
		public float MaxPositiveWarp { get; set; }

		[AntField(9)]
		public float MaxNegativeWarp { get; set; }

		[AntField(10)]
		public float MaxPositiveRotation { get; set; }

		[AntField(11)]
		public float MaxNegativeRotation { get; set; }

		[AntField(12)]
		public float MaxPositiveScale { get; set; }

		[AntField(13)]
		public float MaxNegativeScale { get; set; }

	}
}
