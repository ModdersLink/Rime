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
	public enum UISettingType : int
	{
		UISettingType_Slider = 0,
		UISettingType_TickerUpDown = 1,
		UISettingType_Droplist = 2,
		UISettingType_Checkbox = 3,
		UISettingType_Text = 4,
		UISettingType_NotSet = 5
	}

}
