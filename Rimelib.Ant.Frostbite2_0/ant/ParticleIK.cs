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

	[AntBinding(0x3b76abac)]
	public class ParticleIK
		: AntObject
	{
		[AntField(0)]
		public int SolverStepsKey { get; set; }

		[AntField(1)]
		public bool DiagnosticsEnableKey { get; set; }

		[AntField(2)]
		public string DiagnosticsCommandKey { get; set; } = string.Empty;

	}
}
