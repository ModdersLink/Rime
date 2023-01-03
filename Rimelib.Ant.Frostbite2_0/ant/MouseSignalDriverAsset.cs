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

	[AntBinding(0x2765f139)]
	public class MouseSignalDriverAsset
		: SignalDriverAsset
	{
		[AntField(0)]
		public IdRef<MouseValueAsset> MouseValueAsset { get; set; } = new();

		[AntField(1)]
		public uint DriverType { get; set; }

		[AntField(2)]
		public uint AngleType { get; set; }

		[AntField(3)]
		public float MinClampValue { get; set; }

		[AntField(4)]
		public float MaxClampValue { get; set; }

		[AntField(5)]
		public float Sensitivity { get; set; }

		[AntField(6)]
		public bool AccumulateMotion { get; set; }

		[AntField(7)]
		public bool InvertSignal { get; set; }

		[AntField(8)]
		public bool ClampSignal { get; set; }

		[AntField(9)]
		public bool ToggleSignal { get; set; }

	}
}
