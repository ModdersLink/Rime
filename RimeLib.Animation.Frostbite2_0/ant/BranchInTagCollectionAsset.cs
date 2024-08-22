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

	[AntBinding(0x418bc0b4)]
	public class BranchInTagCollectionAsset
		: AntObject
	{
		[AntField(0)]
		public IdRefArray<BranchInWindowTag> TagKeys { get; set; } = new();

	}
}
