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
	[ContainerType(4, 60)]
	public class DialogNode : 
		StateNode
	{
		[ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		public string DialogTitle { get; set; } = string.Empty;

		[ContainerField(52), LayoutImmutable, JsonProperty(Order = 52)]
		public string DialogText { get; set; } = string.Empty;

		[ContainerField(56), JsonProperty(Order = 56)]
		public List<UIPopupButton> Buttons { get; set; } = new();

	}
}
