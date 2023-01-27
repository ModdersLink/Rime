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

	[AntBinding(0xb2dc926f)]
	public class GamepadSceneOpInitParamsAsset
		: AntObject
	{
		[AntField(0)]
		public IdRefArray<GamepadConfigAsset> GamepadConfigAssetKeys { get; set; } = new();

		[AntField(1)]
		public int GamepadID { get; set; }

		[AntField(2)]
		public int GamepadType { get; set; }

		[AntField(3)]
		public IdRef<AntObject> LeftAnalogFlipXAxis { get; set; } = new();

		[AntField(4)]
		public IdRef<AntObject> LeftAnalogFlipYAxis { get; set; } = new();

		[AntField(5)]
		public IdRef<AntObject> RightAnalogFlipXAxis { get; set; } = new();

		[AntField(6)]
		public IdRef<AntObject> RightAnalogFlipYAxis { get; set; } = new();

		[AntField(7)]
		public IdRef<MouseValueAsset> Mouse { get; set; } = new();

		[AntField(8)]
		public IdRef<KeyboardValueAsset> Keyboard { get; set; } = new();

	}
}
