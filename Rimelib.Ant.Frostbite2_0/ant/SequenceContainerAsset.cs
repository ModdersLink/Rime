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

	[AntBinding(0xeae58e8d)]
	public class SequenceContainerAsset
		: ControllerAsset
	{
		[AntField(0)]
		public IdRefArray<ActorControllerAsset> ActorAssets { get; set; } = new();

	}
}
