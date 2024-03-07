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

	[AntBinding(0x83a9a138)]
	public class ControllerUpdateInitParamsAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<AntObject> ControllerAsset { get; set; } = new();

		[AntField(1)]
		public IdRef<AntObject> InitParams { get; set; } = new();

	}
}
