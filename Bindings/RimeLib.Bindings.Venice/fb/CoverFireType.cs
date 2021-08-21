///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Flags: 137, Size: 4  )]
	public enum CoverFireType : int
	{
		CoverFireType_Peek = 0,
		CoverFireType_Out = 1,
		CoverFireType_Over = 2,
		CoverFireType_BlindOut = 3,
		CoverFireType_BlindOver = 4,
		CoverFireType_GrenadeOut = 5,
		CoverFireType_GrenadeBlindOver = 6,
		CoverFireType_NoFire = 7,
		CoverFireType_Flanked = 8,
		CoverFireType_OutSlow = 10,
		CoverFireType_OutUrgent = 11,
		CoverFireType_OutStandToCrouch = 12,
		CoverFireType_Lmg = 13,
		CoverFireType_OutFireFromHip = 14,
		CoverFireType_FlankedSurprised = 15
	}

}
