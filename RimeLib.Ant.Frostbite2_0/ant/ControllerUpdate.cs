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

	[AntBinding(0x1ff9092c)]
	public class ControllerUpdate
		: AntObject
	{
		[AntField(0)]
		public IdRef<ControllerUpdateInitParamsAsset> InitParams { get; set; } = new();

	}
}
