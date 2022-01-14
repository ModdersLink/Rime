///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum AntCoverEnum : int
	{
		AntCoverEnum_RightCover = 0,
		AntCoverEnum_LeftCover = 1,
		AntCoverEnum_MiddleCover = 2,
		AntCoverEnum_MediumLeftCover = 3,
		AntCoverEnum_MediumRightCover = 4,
		AntCoverEnum_Prone = 5,
		AntCoverEnum_Count = 6
	}

}
