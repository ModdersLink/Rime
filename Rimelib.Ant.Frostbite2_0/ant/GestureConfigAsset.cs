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

	[AntBinding(0x9fa8c5ba)]
	public class GestureConfigAsset
		: AntObject
	{
		[AntField(0)]
		public IdRefArray<AntObject> DependsOn { get; set; } = new();

		[AntField(1)]
		public IdRefArray<AntObject> GestureMappings { get; set; } = new();

		[AntField(2)]
		public bool StopAtFirstMatcher { get; set; }

		[AntField(3)]
		public IdRef<AntObject> TriggerReset { get; set; } = new();

	}
}
