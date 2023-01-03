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

	[AntBinding(0x5bfa3a4d)]
	public class CurveAnimationAsset__ChannelGroup
		: AntObject
	{
		[AntField(0)]
		public ushort NumKeys { get; set; }

		[AntField(1)]
		public ushort NumChannels { get; set; }

	}
}
