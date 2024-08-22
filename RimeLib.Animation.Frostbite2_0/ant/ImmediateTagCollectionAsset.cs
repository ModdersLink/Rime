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

	[AntBinding(0xcc109eea)]
	public class ImmediateTagCollectionAsset
		: AntObject
	{
		[AntField(0)]
		public IdRefArray<ImmediateBoolGameStateTag> ImmediateTagKeys { get; set; } = new();

	}
}
