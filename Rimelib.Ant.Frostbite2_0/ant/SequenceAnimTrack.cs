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

	[AntBinding(0x6298211d)]
	public class SequenceAnimTrack
		: AntObject
	{
		[AntField(0)]
		public int NumWarpers { get; set; }

		[AntField(1)]
		public List<AntObject?> WarpersParam { get; set; } = new();

		[AntField(2)]
		public int NumAnims { get; set; }

		[AntField(3)]
		public List<AntObject?> Anims { get; set; } = new();

	}
}
