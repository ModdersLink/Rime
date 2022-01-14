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

namespace fb
{
	[ContainerType(4, 56)]
	public class PlayerOrderTrackerData : 
		HudTrackerData
	{
		[ContainerField(44), JsonProperty(Order = 44)]
		public UIHudIcon AttackIcon { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public UIHudIcon DefendIcon { get; set; } = new();

		[ContainerField(52), JsonProperty(Order = 52)]
		public UIHudIcon MoveToIcon { get; set; } = new();

	}
}
