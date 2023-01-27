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

	[AntBinding(0x2614fb3e)]
	public class GamepadConfigMappingData
		: AntObject
	{
		[AntField(0)]
		public IdRef<BoolAsset> SignalAsset { get; set; } = new();

		[AntField(1)]
		public IdRefArray<GamepadAsset> SignalDriverList { get; set; } = new();

		[AntField(2)]
		public int AdditiveSignalDriverCount { get; set; }

	}
}
