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

	[AntBinding(0x883361ae)]
	public class GestureToSignalMappingAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<AntObject> Signal { get; set; } = new();

		[AntField(1)]
		public IdRef<AntObject> Enabled { get; set; } = new();

		[AntField(2)]
		public IdRefArray<AntObject> DeviceList { get; set; } = new();

		[AntField(3)]
		public IdRefArray<AntObject> Gesture { get; set; } = new();

		[AntField(4)]
		public IdRef<AntObject> Config { get; set; } = new();

	}
}
