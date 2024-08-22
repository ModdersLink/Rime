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

	[AntBinding(0xe0b7f3af)]
	public class LevelOfDetailFeatureAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<FloatAsset> CameraDistance { get; set; } = new();

	}
}
