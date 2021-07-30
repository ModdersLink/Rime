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
	public enum VehicleMode : int
	{
		VmIdle = 0,
		VmEntering = 1,
		VmEntered = 2,
		VmStarting = 3,
		VmStarted = 4,
		VmStopping = 5,
		VmLeaving = 6
	}

}
