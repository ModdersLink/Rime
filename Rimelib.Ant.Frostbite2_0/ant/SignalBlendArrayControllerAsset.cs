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

	[AntBinding(0xe3ccf947)]
	public class SignalBlendArrayControllerAsset
		: ControllerAsset
	{
		[AntField(0)]
		public float ClampMax { get; set; }

		[AntField(1)]
		public float ClampMin { get; set; }

		[AntField(2)]
		public float PositiveDamping { get; set; }

		[AntField(3)]
		public float NegativeDamping { get; set; }

		[AntField(4)]
		public bool Mirrored { get; set; }

		[AntField(5)]
		public IdRef<ActorControllerAsset> MasterController { get; set; } = new();

		[AntField(6)]
		public float MasterControllerLength { get; set; }

		[AntField(7)]
		public IdRef<FloatAsset> BlendSignal { get; set; } = new();

		[AntField(8)]
		public IdRef<BlendArrayAsset> BlendArray { get; set; } = new();

	}
}
