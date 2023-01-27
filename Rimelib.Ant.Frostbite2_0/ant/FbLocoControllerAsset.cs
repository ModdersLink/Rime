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

	[AntBinding(0x68c8bc5a)]
	public class FbLocoControllerAsset
		: LocoControllerAsset
	{
		[AntField(0)]
		public IdRef<PointerAsset> LocoCommandHandle { get; set; } = new();

		[AntField(1)]
		public IdRef<PointerAsset> CommandQueue { get; set; } = new();

	}
}
