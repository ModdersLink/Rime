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
	[ContainerType(4, 32)]
	public class UIModDescription : 
		UIItemDescription
	{
		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string Identifier { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string ShortName { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string FullName { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		public string Desc { get; set; } = string.Empty;

	}
}
