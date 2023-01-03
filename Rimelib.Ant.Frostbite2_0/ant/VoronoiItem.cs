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

	[AntBinding(0x9e6ccca)]
	public class VoronoiItem
		: AntObject
	{
		[AntField(0)]
		public AntVector2 Position { get; set; } = new();

		[AntField(1)]
		public bool XAxis { get; set; }

		[AntField(2)]
		public IdRef<ClipControllerAsset> BlendAsset { get; set; } = new();

		[AntField(3)]
		public bool Snap { get; set; }

	}
}
