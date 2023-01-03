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

	[AntBinding(0xa324e1ba)]
	public class KeyboardSignalDriverAsset
		: SignalDriverAsset
	{
		[AntField(0)]
		public IdRef<KeyboardValueAsset> KeyboardValueAsset { get; set; } = new();

		[AntField(1)]
		public uint DriverType { get; set; }

		[AntField(2)]
		public uint AngleType { get; set; }

		[AntField(3)]
		public byte Key { get; set; }

		[AntField(4)]
		public bool LeftCtrlDown { get; set; }

		[AntField(5)]
		public bool RightCtrlDown { get; set; }

		[AntField(6)]
		public bool LeftAltDown { get; set; }

		[AntField(7)]
		public bool RightAltDown { get; set; }

		[AntField(8)]
		public bool LeftShiftDown { get; set; }

		[AntField(9)]
		public bool RightShiftDown { get; set; }

		[AntField(10)]
		public bool SignalToggle { get; set; }

		[AntField(11)]
		public bool UseMetaKeyCombination { get; set; }

	}
}
