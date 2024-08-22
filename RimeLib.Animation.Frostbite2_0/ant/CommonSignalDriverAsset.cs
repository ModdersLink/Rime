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

	[AntBinding(0x24399c98)]
	public class CommonSignalDriverAsset
		: SignalDriverAsset
	{
		[AntField(0)]
		public int DriverType { get; set; }

		[AntField(1)]
		public int AngleType { get; set; }

		[AntField(2)]
		public int MirrorAnalog { get; set; }

		[AntField(3)]
		public IdRef<GamepadAsset> DeadZoneAsset { get; set; } = new();

	}
}
