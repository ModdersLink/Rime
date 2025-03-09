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

	[AntBinding(0x2c597123)]
	public class TaggingControllerAsset
		: ControllerAsset
	{
		[AntField(0)]
		public IdRef<ClipControllerAsset> SubjectControllerAsset { get; set; } = new();

		[AntField(1)]
		public IdRef<ClipInitParam> SubjectInitParams { get; set; } = new();

	}
}
