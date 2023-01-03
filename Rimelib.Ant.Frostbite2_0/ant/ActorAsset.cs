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

	[AntBinding(0xea86d88e)]
	public class ActorAsset
		: ActorGroupAsset
	{
		[AntField(0)]
		public IdRef<AnimatableAsset> AnimatableAsset { get; set; } = new();

		[AntField(1)]
		public IdRef<AnimatableConfigAsset> ConfigAsset { get; set; } = new();

	}
}
