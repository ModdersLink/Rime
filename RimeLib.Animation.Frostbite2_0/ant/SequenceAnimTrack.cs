///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// As type schemas dont contain full information, modifying  //
// can be done to fix information thats wrong or missing.    //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using RimeLib.Animation.EA.Attributes;
using RimeLib.Animation.EA.Types;

namespace ant
{

	[AntBinding(0x6298211d)]
	[AntBinding(0xe67a7291)] // BF3 alpha schema (adds Target)
	public class SequenceAnimTrack
		: AntObject
	{
		// BF3-alpha-only field (dropped in retail; slot 0 in the alpha reflection table).
		public IdRef<AntObject> Target { get; set; } = new();

		[AntField(0)]
		public int NumWarpers { get; set; }

		[AntField(1)]
		public List<AntObject?> WarpersParam { get; set; } = new();

		[AntField(2)]
		public int NumAnims { get; set; }

		[AntField(3)]
		public List<SequenceAnimation?> Anims { get; set; } = new();

	}
}
