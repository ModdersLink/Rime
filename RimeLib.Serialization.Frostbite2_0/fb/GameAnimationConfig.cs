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
	[ContainerType(4, 16)]
	public class GameAnimationConfig : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public bool ServerEnable { get; set; }

		[ContainerField(13), LayoutImmutable, Blittable, JsonProperty(Order = 13)]
		public bool ClientEnable { get; set; }

		[ContainerField(14), LayoutImmutable, Blittable, JsonProperty(Order = 14)]
		public bool UseRawGamepadInput { get; set; }

	}
}
