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

	[AntBinding(0xc7d9aadd)]
	public class ActorControllerInitParams
		: AntObject
	{
		[AntField(0)]
		public float X { get; set; }

		[AntField(1)]
		public float Y { get; set; }

		[AntField(2)]
		public float Z { get; set; }

		[AntField(3)]
		public float LaunchAngle { get; set; }

		[AntField(4)]
		public float Scale { get; set; }

		[AntField(5)]
		public int Mirror { get; set; }

		[AntField(6)]
		public float StartTick { get; set; }

	}
}
