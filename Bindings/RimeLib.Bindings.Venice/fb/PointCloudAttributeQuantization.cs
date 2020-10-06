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
	[MemberInfoFlag(137), ContainerSize(4), ContainerEnum]
	public enum PointCloudAttributeQuantization : int
	{
		PointCloudAttributeQuantization_s5e5 = 0,
		PointCloudAttributeQuantization_s7e5 = 1,
		PointCloudAttributeQuantization_s10e5 = 2,
		PointCloudAttributeQuantization_s16e7 = 3,
		PointCloudAttributeQuantization_None = 4,
		PointCloudAttributeQuantization_Count = 5
	}

}
