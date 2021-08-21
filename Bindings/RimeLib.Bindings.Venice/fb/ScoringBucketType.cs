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
	public enum ScoringBucketType : int
	{
		ScoringBucketType_Disabled = 0,
		ScoringBucketType_Normal = 1,
		ScoringBucketType_Vehicle = 2,
		ScoringBucketType_Kit = 3,
		ScoringBucketType_Count = 4
	}

}
