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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum PointCloudAttributeUsage : int
	{
		PointCloudAttributeUsage_Position = 0,
		PointCloudAttributeUsage_Normal = 1,
		PointCloudAttributeUsage_Tangent = 2,
		PointCloudAttributeUsage_Binormal = 3,
		PointCloudAttributeUsage_Count = 4
	}

}
