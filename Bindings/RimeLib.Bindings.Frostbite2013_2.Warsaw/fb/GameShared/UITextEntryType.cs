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
public enum UITextEntryType : int
{
	UITextEntryType_Passthrough = 0,
	UITextEntryType_DataKey = 1,
	UITextEntryType_PropertyInt = 2,
	UITextEntryType_PropertyFloat = 3,
	UITextEntryType_PropertyBool = 4,
	UITextEntryType_PropertyString = 5,
	UITextEntryType_PropertyTransform = 6,
	UITextEntryType_PropertyVec3 = 7,
	UITextEntryType_PropertyVec4 = 8,
}

