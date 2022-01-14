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
	[ContainerType(4, 12)]
	public class UISettingsItem
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string NameSid { get; set; } = string.Empty;
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public UISettingSymbols StartEndSymbols { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<ProfileOptionData> Setting { get; set; } = new();
		
	}
}
