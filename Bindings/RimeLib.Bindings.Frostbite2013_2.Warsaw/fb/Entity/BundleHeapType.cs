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


namespace fb.Entity;

[ContainerType(1, 4)]
public enum BundleHeapType : int
{
	BundleHeapType_OwnWithParentSmallblock = 0,
	BundleHeapType_OwnWithSmallblock = 1,
	BundleHeapType_OwnWithoutSmallblock = 2,
	BundleHeapType_Parent = 3,
	BundleHeapType_Level = 4,
	BundleHeapType_Global = 5,
	BundleHeapType_Null = 6,
}

