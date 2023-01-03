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

	[AntBinding(0x30531523)]
	public class GamepadMatchStateData
		: AntObject
	{
		[AntField(0)]
		public int MinTime { get; set; }

		[AntField(1)]
		public int MaxTime { get; set; }

		[AntField(2)]
		public GamepadStateData[] GamepadStateList { get; set; } = new GamepadStateData[2];

	}
}
