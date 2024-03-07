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

	[AntBinding(0x8cd9e9c2)]
	public class PrimaryRigFeatureAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<RigAsset> Rig { get; set; } = new();

	}
}
