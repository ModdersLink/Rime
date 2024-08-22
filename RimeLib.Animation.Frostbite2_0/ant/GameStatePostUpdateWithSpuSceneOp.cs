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

	[AntBinding(0xf0a210ff)]
	public class GameStatePostUpdateWithSpuSceneOp
		: AntObject
	{
		[AntField(0)]
		public IdRefArray<AntObject> CPUGenericList { get; set; } = new();

		[AntField(1)]
		public IdRefArray<AntObject> SPUBoolList { get; set; } = new();

		[AntField(2)]
		public ushort SPUBoolTrueCount { get; set; }

	}
}
