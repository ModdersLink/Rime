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
	public enum SpecialMovesPoseType : int
	{
		SpecialMovesPoseType_None = -1,
		SpecialMovesPoseType_Stand = 0,
		SpecialMovesPoseType_Crouch = 1,
		SpecialMovesPoseType_Prone = 2
	}

}
