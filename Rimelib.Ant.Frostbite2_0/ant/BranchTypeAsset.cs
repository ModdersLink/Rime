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

	[AntBinding(0xdb05f04c)]
	public class BranchTypeAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<AntObject> BranchTuner { get; set; } = new();

		[AntField(1)]
		public IdRef<AntObject> BufferTuner { get; set; } = new();

		[AntField(2)]
		public uint ControllerFilterIdentifier { get; set; }

	}
}
