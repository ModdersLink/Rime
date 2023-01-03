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

	[AntBinding(0xa654c8cd)]
	public class AnalogStickGestureMatchAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<AntObject> AnalogStick { get; set; } = new();

		[AntField(1)]
		public int MatchType { get; set; }

		[AntField(2)]
		public float MinAngle { get; set; }

		[AntField(3)]
		public float MaxAngle { get; set; }

		[AntField(4)]
		public float MinMagnitude { get; set; }

		[AntField(5)]
		public float MaxMagnitude { get; set; }

		[AntField(6)]
		public float AngularVelocity { get; set; }

		[AntField(7)]
		public float MagnitudeVelocity { get; set; }

		[AntField(8)]
		public float OffsetAngle { get; set; }

		[AntField(9)]
		public float AngleRangeMin { get; set; }

		[AntField(10)]
		public float AngleRangeMax { get; set; }

		[AntField(11)]
		public int OutputValue { get; set; }

		[AntField(12)]
		public IdRef<AntObject> OutputTo { get; set; } = new();

		[AntField(13)]
		public int Options { get; set; }

	}
}
