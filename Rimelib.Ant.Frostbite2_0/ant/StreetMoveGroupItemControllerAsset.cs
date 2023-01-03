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

	[AntBinding(0x5c918ed7)]
	public class StreetMoveGroupItemControllerAsset
		: ControllerAsset
	{
		[AntField(0)]
		public IdRef<ClipControllerAsset> ControllerAsset { get; set; } = new();

		[AntField(1)]
		public float ItemSpeed { get; set; }

		[AntField(2)]
		public float ItemStartPhase { get; set; }

		[AntField(3)]
		public bool ItemMirror { get; set; }

		[AntField(4)]
		public float NumPhase { get; set; }

		[AntField(5)]
		public float ItemAchievedAngle { get; set; }

		[AntField(6)]
		public float Velocity { get; set; }

	}
}
