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
	public enum ForceCondition : int
	{
		FCNever = 0,
		FCNotCriticalDamaged = 1,
		FCCriticalDamaged = 2,
		FCNotOccupied = 3,
		FCOccupied = 4,
		FCAlways = 5
	}

}
