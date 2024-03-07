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

	[AntBinding(0x9e0f8443)]
	public class RigOpListBinding
		: AntObject
	{
		[AntField(0)]
		public string DataRigOpType { get; set; } = string.Empty;

		[AntField(1)]
		public IdRef<DeltaTrajectory> DataRigOpKey { get; set; } = new();

		[AntField(2)]
		public List<RigOpListBindingParam> DataParam { get; set; } = new();

		[AntField(3)]
		public IdRef<BoolAsset> DataEnableKey { get; set; } = new();

	}
}
