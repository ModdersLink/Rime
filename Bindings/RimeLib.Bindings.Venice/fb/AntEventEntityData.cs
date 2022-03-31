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
	[ContainerType(16, 112)]
	public class AntEventEntityData : 
		GameEntityData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public List<AntEventData> OnEnterEvents { get; set; } = new();

		[ContainerField(100), JsonProperty(Order = 100)]
		public List<AntEventData> OnUpdateEvents { get; set; } = new();

		[ContainerField(104), JsonProperty(Order = 104)]
		public List<AntEventData> OnLeaveEvents { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public bool SendAsPlayerEvent { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
		public bool AutoActivate { get; set; }

	}
}
