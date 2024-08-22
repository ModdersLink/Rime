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

	[AntBinding(0xccb2dae7)]
	public class SimpleWorldSceneOp
		: AntObject
	{
		[AntField(0)]
		public IdRef<PointerAsset> AsyncQueryPointer { get; set; } = new();

	}
}
