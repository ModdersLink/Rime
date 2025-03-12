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

	[AntBinding(0x6663dd97)]
	public class RigOpListUpdate
		: AntObject
	{
		[AntField(0)]
		public IdRef<RigOpListAsset> RigOpListKey { get; set; } = new();

		[AntField(1)]
		public bool RunOnSpuKey { get; set; }

		[AntField(2)]
		public uint NumJobs { get; set; }

		[AntField(3)]
		public uint MaxAnimatablesPerJob { get; set; }

		[AntField(4)]
		public uint QueueBatchSize { get; set; }

	}
}
