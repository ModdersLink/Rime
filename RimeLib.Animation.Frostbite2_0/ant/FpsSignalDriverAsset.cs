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

	[AntBinding(0x7b0ec08a)]
	public class FpsSignalDriverAsset
		: SignalDriverAsset
	{
		[AntField(0)]
		public int DriverType { get; set; }

		[AntField(1)]
		public float Deadzone { get; set; }

		[AntField(2)]
		public float Scale { get; set; }

		[AntField(3)]
		public float Min { get; set; }

		[AntField(4)]
		public float Max { get; set; }

		[AntField(5)]
		public int SignalMode { get; set; }

	}
}
