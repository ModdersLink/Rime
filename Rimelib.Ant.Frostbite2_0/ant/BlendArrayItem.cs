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

	[AntBinding(0xf9b2f60b)]
	public class BlendArrayItem
		: AntObject
	{
		[AntField(0)]
		public IdRef<AntObject> Clip { get; set; } = new();

		[AntField(1)]
		public IdRef<AntObject> Tag { get; set; } = new();

		[AntField(2)]
		public float X { get; set; }

		[AntField(3)]
		public float EndTime { get; set; }

	}
}
