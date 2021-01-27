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
	[ContainerType(Flags: 137, Size: 4  )]
	public enum FireLogicType : int
	{
		fltSingleFire = 0,
		fltSingleFireWithBoltAction = 1,
		fltAutomaticFire = 2,
		fltBurstFire = 3,
		fltHoldAndRelease = 4,
		fltDetonatedFiring = 5,
		fltCount = 6
	}

}
