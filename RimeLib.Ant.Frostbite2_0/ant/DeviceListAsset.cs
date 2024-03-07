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

	[AntBinding(0xa3ded923)]
	public class DeviceListAsset
		: AntObject
	{
		[AntField(0)]
		public IdRefArray<ClassicGamepadAsset> Devices { get; set; } = new();

		[AntField(1)]
		public IdRefArray<AntObject> Expressions { get; set; } = new();

		[AntField(2)]
		public float DeltaTicks { get; set; }

		[AntField(3)]
		public int UpdatesPerFrame { get; set; }

	}
}
