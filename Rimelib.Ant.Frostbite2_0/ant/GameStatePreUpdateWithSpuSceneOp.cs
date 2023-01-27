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

	[AntBinding(0x9558fac5)]
	public class GameStatePreUpdateWithSpuSceneOp
		: AntObject
	{
		[AntField(0)]
		public IdRefArray<ExpressionBoolAsset> CPUGenericList { get; set; } = new();

		[AntField(1)]
		public IdRefArray<AntObject> CPUSignalExpressionList { get; set; } = new();

		[AntField(2)]
		public IdRefArray<ExpressionFloatAsset> SPUFloatExpressionList { get; set; } = new();

		[AntField(3)]
		public IdRefArray<ExpressionBoolAsset> SPUBoolExpressionList { get; set; } = new();

	}
}
