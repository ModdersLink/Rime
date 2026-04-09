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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 4)]
	public enum CoverExitStyle : int
	{
		CoverExitStyle_ExitCover = 0,
		CoverExitStyle_VaultFromCrouchCover = 1,
		CoverExitStyle_StrafeFire = 2,
		CoverExitStyle_Surprised = 3,
		CoverExitStyle_Sprint = 4
	}

}
