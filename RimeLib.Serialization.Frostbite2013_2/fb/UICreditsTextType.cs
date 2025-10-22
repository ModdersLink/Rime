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


namespace fb.VeniceShared;

[ContainerType(1, 4)]
public enum UICreditsTextType : int
{
	UICreditsTextType_Header = 0,
	UICreditsTextType_Title = 1,
	UICreditsTextType_Name = 2,
	UICreditsTextType_LeadsName = 3,
	UICreditsTextType_Image = 4,
}

