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
	public enum ResourceBundleKind : int
	{
		ResourceBundleKind_AlwaysLoaded = 0,
		ResourceBundleKind_GlobalPackage = 1,
		ResourceBundleKind_AssetPackage = 2,
		ResourceBundleKind_SubLevelPackage = 3,
		ResourceBundleKind_BlueprintBundle = 4
	}

}
