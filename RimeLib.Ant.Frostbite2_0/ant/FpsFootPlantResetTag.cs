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

	[AntBinding(0x1e056921)]
	public class FpsFootPlantResetTag
		: AntObject
	{
		[AntField(0)]
		public byte ResetFoot { get; set; }

		[AntField(1)]
		public float Time { get; set; }

		[AntField(2)]
		public float Duration { get; set; }

	}
}
