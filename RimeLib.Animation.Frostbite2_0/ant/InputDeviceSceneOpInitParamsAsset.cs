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

	[AntBinding(0xfaaac0e)]
	public class InputDeviceSceneOpInitParamsAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<AntObject> DeviceList { get; set; } = new();

		[AntField(1)]
		public IdRef<AntObject> Config { get; set; } = new();

		[AntField(2)]
		public uint InputDeviceMask { get; set; }

		[AntField(3)]
		public float CameraAngle { get; set; }

		[AntField(4)]
		public float CharacterAngle { get; set; }

	}
}
