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

	[AntBinding(0x16389839)]
	public class SignalBranchTunerAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<FloatAsset> SignalAsset { get; set; } = new();

		[AntField(1)]
		public float ValueMappingToZero { get; set; }

		[AntField(2)]
		public float ValueMappingToOne { get; set; }

	}
}
