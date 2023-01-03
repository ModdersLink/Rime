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

	[AntBinding(0x5620316e)]
	public class MouseValueAsset
		: AntObject
	{
		[AntField(0)]
		public byte Buttons { get; set; }

		[AntField(1)]
		public int DeltaX { get; set; }

		[AntField(2)]
		public int DeltaY { get; set; }

		[AntField(3)]
		public int DeltaWheel { get; set; }

		[AntField(4)]
		public float DeltaXSpeed { get; set; }

		[AntField(5)]
		public float DeltaYSpeed { get; set; }

		[AntField(6)]
		public float DeltaWheelSpeed { get; set; }

	}
}
