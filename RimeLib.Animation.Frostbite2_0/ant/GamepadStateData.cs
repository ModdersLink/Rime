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

	[AntBinding(0x189e95)]
	public class GamepadStateData
		: AntObject
	{
		[AntField(0)]
		public int lState { get; set; }

		[AntField(1)]
		public bool lCharRelative { get; set; }

		[AntField(2)]
		public bool lMirrorAnalog { get; set; }

		[AntField(3)]
		public float lMinAngle { get; set; }

		[AntField(4)]
		public float lMaxAngle { get; set; }

		[AntField(5)]
		public int lMinPower { get; set; }

		[AntField(6)]
		public int lMaxPower { get; set; }

		[AntField(7)]
		public float lMinAngularV { get; set; }

		[AntField(8)]
		public float lMinRadialV { get; set; }

		[AntField(9)]
		public bool lUseVelocityFilter { get; set; }

		[AntField(10)]
		public int rState { get; set; }

		[AntField(11)]
		public bool rCharRelative { get; set; }

		[AntField(12)]
		public bool rMirrorAnalog { get; set; }

		[AntField(13)]
		public float rMinAngle { get; set; }

		[AntField(14)]
		public float rMaxAngle { get; set; }

		[AntField(15)]
		public int rMinPower { get; set; }

		[AntField(16)]
		public int rMaxPower { get; set; }

		[AntField(17)]
		public float rMinAngularV { get; set; }

		[AntField(18)]
		public float rMinRadialV { get; set; }

		[AntField(19)]
		public bool rUseVelocityFilter { get; set; }

		[AntField(20)]
		public int ltState { get; set; }

		[AntField(21)]
		public float ltMinRange { get; set; }

		[AntField(22)]
		public float ltMaxRange { get; set; }

		[AntField(23)]
		public int rtState { get; set; }

		[AntField(24)]
		public float rtMinRange { get; set; }

		[AntField(25)]
		public float rtMaxRange { get; set; }

		[AntField(26)]
		public float deltaLtRt { get; set; }

		[AntField(27)]
		public uint Hold { get; set; }

		[AntField(28)]
		public uint Press { get; set; }

		[AntField(29)]
		public uint Release { get; set; }

	}
}
