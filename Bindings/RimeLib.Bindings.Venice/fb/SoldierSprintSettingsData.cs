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
	[ContainerType(4, 40)]
	public class SoldierSprintSettingsData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float Fov { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float FovInDelay { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float FovInTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float FovOutDelay { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float FovOutTime { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float RecoverTime { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float SprintToProneRecoverTime { get; set; }

		[ContainerField(36), JsonProperty(Order = 36)]
		public List<EntryInputActionEnum> InterruptingActions { get; set; } = new();

	}
}
