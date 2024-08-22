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

	[AntBinding(0xd063ee7c)]
	public class LagData
		: AntObject
	{
		[AntField(0)]
		public PIDData PitchData { get; set; } = new();

		[AntField(1)]
		public PIDData YawData { get; set; } = new();

		[AntField(2)]
		public PIDData RollData { get; set; } = new();

	}
}
