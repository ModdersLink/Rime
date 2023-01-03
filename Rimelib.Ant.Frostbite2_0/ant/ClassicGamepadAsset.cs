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

	[AntBinding(0x825fb771)]
	public class ClassicGamepadAsset
		: InputDeviceAsset
	{
		[AntField(0)]
		public IdRef<AnalogStickStateAsset> LeftAnalog { get; set; } = new();

		[AntField(1)]
		public IdRef<AnalogStickStateAsset> RightAnalog { get; set; } = new();

		[AntField(2)]
		public IdRef<AnalogStickStateAsset> DPad { get; set; } = new();

		[AntField(3)]
		public IdRef<GamepadButtonsStateAsset> Buttons { get; set; } = new();

	}
}
