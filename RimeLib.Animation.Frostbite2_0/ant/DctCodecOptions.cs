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

	[AntBinding(0xd66e0c0f)]
	public class DctCodecOptions
		: AntObject
	{
		[AntField(0)]
		public ushort QuantizeMult_Block { get; set; }

		[AntField(1)]
		public byte QuantizeMult_Subblock_InTenths { get; set; }

	}
}
