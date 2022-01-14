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
	[ContainerType(4, 8)]
	public class UISettingsPage
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string NameSid { get; set; } = string.Empty;
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public List<UISettingsGroup> SettingsGroups { get; set; } = new();
		
	}
}
