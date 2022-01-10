///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum ScoringBucketType : int
	{
		ScoringBucketType_Disabled = 0,
		ScoringBucketType_Normal = 1,
		ScoringBucketType_Vehicle = 2,
		ScoringBucketType_Kit = 3,
		ScoringBucketType_Count = 4
	}

}
