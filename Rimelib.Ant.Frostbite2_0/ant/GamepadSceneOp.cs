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

	[AntBinding(0xf50c82e0)]
	public class GamepadSceneOp
		: AntObject
	{
		[AntField(0)]
		public IdRef<GamepadSceneOpInitParamsAsset> GamepadSceneOpInitParams { get; set; } = new();

	}
}
