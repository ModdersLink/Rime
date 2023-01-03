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

	[AntBinding(0x13f8f136)]
	public class LodLayersControllerAsset
		: LayersControllerAsset
	{
		[AntField(0)]
		public IdRef<FloatAsset> CameraDistance { get; set; } = new();

		[AntField(1)]
		public IdRefArray<ExpressionBoolAsset> EnabledValueAssets { get; set; } = new();

		[AntField(2)]
		public List<float> LodDistancesNear { get; set; } = new();

		[AntField(3)]
		public List<float> LodDistancesFar { get; set; } = new();

	}
}
