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
	public enum UIInputAction : int
	{
		UIInputAction_NavigateUp = 0,
		UIInputAction_NavigateDown = 1,
		UIInputAction_NavigateLeft = 2,
		UIInputAction_NavigateRight = 3,
		UIInputAction_TabLeft = 4,
		UIInputAction_TabRight = 5,
		UIInputAction_Activate = 6,
		UIInputAction_Deactivate = 7,
		UIInputAction_Menu = 8,
		UIInputAction_Cancel = 9,
		UIInputAction_OK = 10,
		UIInputAction_Back = 11,
		UIInputAction_Tab = 12,
		UIInputAction_Edit = 13,
		UIInputAction_View = 14,
		UIInputAction_LThumb = 15,
		UIInputAction_RThumb = 16,
		UIInputAction_MapZoom = 17,
		UIInputAction_MapSize = 18,
		UIInputAction_SayAllChat = 19,
		UIInputAction_TeamChat = 20,
		UIInputAction_SquadChat = 21,
		UIInputAction_CommoRose = 22,
		UIInputAction_ToggleChat = 23,
		UIInputAction_ToggleMinimapType = 24,
		UIInputAction_Size = 25,
		UIInputAction_None = 26
	}

}
