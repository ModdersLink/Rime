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
	public enum UIWidgetEventID : int
	{
		UIWidgetEventID_None = 0,
		UIWidgetEventID_OnItemSelected = 1,
		UIWidgetEventID_OnItemHighlighted = 2,
		UIWidgetEventID_OnItemReleased = 3,
		UIWidgetEventID_OnItemUnhighlighted = 4,
		UIWidgetEventID_OnItemPressed = 5,
		UIWidgetEventID_OnItemOver = 6,
		UIWidgetEventID_OnItemOut = 7,
		UIWidgetEventID_OnToggle = 8,
		UIWidgetEventID_OnChanged = 9,
		UIWidgetEventID_OnButtonBarChanged = 10,
		UIWidgetEventID_EnterTop = 11,
		UIWidgetEventID_EnterBottom = 12,
		UIWidgetEventID_EnterAny = 13,
		UIWidgetEventID_SetIndex = 14,
		UIWidgetEventID_SetPercentage = 15,
		UIWidgetEventID_OnReachedTop = 16,
		UIWidgetEventID_OnReachedBottom = 17,
		UIWidgetEventID_OnNavigateLeft = 18,
		UIWidgetEventID_OnNavigateRight = 19,
		UIWidgetEventID_Show = 20,
		UIWidgetEventID_Hide = 21,
		UIWidgetEventID_OnShow = 22,
		UIWidgetEventID_OnHide = 23,
		UIWidgetEventID_Toggle = 24,
		UIWidgetEventID_ToggleOn = 25,
		UIWidgetEventID_ToggleOff = 26,
		UIWidgetEventID_ToggledOn = 27,
		UIWidgetEventID_ToggledOff = 28,
		UIWidgetEventID_Update = 29,
		UIWidgetEventID_OnComplete = 30,
		UIWidgetEventID_Focus = 31,
		UIWidgetEventID_OnHeaderChanged = 32,
		UIWidgetEventID_OnDescriptionChanged = 33,
		UIWidgetEventID_OnMapChanged = 34,
		UIWidgetEventID_Clear = 35,
		UIWidgetEventID_Delete = 36,
		UIWidgetEventID_LThumb = 37,
		UIWidgetEventID_RThumb = 38,
		UIWidgetEventID_LTAB = 39,
		UIWidgetEventID_RTAB = 40,
		UIWidgetEventID_OnLarge = 41,
		UIWidgetEventID_OnSmall = 42,
		UIWidgetEventID_TextEntered = 43,
		UIWidgetEventID_PlaySoundNavigate = 44,
		UIWidgetEventID_PlaySoundSelect = 45,
		UIWidgetEventID_PlaySoundPageSwap = 46,
		UIWidgetEventID_OnComPressed = 47,
		UIWidgetEventID_OnComReleased = 48,
		UIWidgetEventID_NumItems = 49
	}

}
