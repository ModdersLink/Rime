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

	[AntBinding(0x66ef9747)]
	public class WeaponAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<EnumerationEnumeratorPair> WeaponEnum { get; set; } = new();

		[AntField(1)]
		public IdRef<EnumerationEnumeratorPair> WeaponClassEnum { get; set; } = new();

		[AntField(2)]
		public IdRef<BoolAsset> WeaponSelectSignal { get; set; } = new();

		[AntField(3)]
		public IdRef<AntObject> WeaponClassSelectSignal { get; set; } = new();

		[AntField(4)]
		public int Package1PId { get; set; }

	}
}
