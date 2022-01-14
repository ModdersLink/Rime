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
	[ContainerType(4, 28)]
	public class MouseInputActionData : 
		AxesInputActionData
	{
		[ContainerField(20), JsonProperty(Order = 20)]
		public InputDeviceMouseButtons Button { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public bool SimulateJoystickAxis { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
		public bool RememberExcessInput { get; set; }

		[ContainerField(26), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
		public bool ScaleScrollWheelAxisInput { get; set; }

	}
}
