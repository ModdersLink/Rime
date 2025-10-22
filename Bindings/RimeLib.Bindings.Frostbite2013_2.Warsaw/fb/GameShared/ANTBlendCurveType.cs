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


namespace fb.GameShared;

[ContainerType(1, 4)]
public enum ANTBlendCurveType : int
{
	ANTBlendCurveType_SnapIn = 0,
	ANTBlendCurveType_SnapOut = 1,
	ANTBlendCurveType_LinearIn = 2,
	ANTBlendCurveType_LinearOut = 3,
	ANTBlendCurveType_EaseIn = 4,
	ANTBlendCurveType_EaseOut = 5,
}

