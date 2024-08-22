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

	[AntBinding(0x8c338695)]
	public class GamepadButtonsStateAsset
		: AntObject
	{
		[AntField(0)]
		public float[] Current { get; set; } = new float[20];

		[AntField(1)]
		public float[] Previous { get; set; } = new float[20];

		[AntField(2)]
		public float DeltaTicks { get; set; }

	}
}
