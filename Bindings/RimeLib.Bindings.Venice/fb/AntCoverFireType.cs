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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	public enum AntCoverFireType : int
	{
		AntCoverFireType_PeekFire = 0,
		AntCoverFireType_FireStepOut = 1,
		AntCoverFireType_FireOver = 2,
		AntCoverFireType_BlindFireAround = 3,
		AntCoverFireType_BlindFireOver = 4,
		AntCoverFireType_FlankedWhileFiring = 8,
		AntCoverFireType_FireStepOutSlow = 10,
		AntCoverFireType_FireStepOutUrgent = 11,
		AntCoverFireType_FireStepOut_Crouched = 12,
		AntCoverFireType_FireLmg = 13,
		AntCoverFireType_FireFromHipStepOut = 14
	}

}
