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

	[AntBinding(0x3d52acb)]
	public class MonitoredTag
		: AntObject
	{
		[AntField(0)]
		public float Time { get; set; }

		[AntField(1)]
		public float Duration { get; set; }

		[AntField(2)]
		public bool AlwaysActive { get; set; }

		[AntField(3)]
		public IdRef<AntObject> TagEnable { get; set; } = new();

	}
}
