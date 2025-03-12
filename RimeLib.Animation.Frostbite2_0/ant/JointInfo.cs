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

	[AntBinding(0x4e369eac)]
	public class JointInfo
		: AntObject
	{
		[AntField(0)]
		public string JointName { get; set; } = string.Empty;

		[AntField(1)]
		public int ParentIndex { get; set; }

		[AntField(2)]
		public int JointType { get; set; }

	}
}
