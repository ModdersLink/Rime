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
	[ContainerType(16, 160)]
	public class RegularSocketObjectData : 
		SocketObjectData
	{
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public LinearTransform Transform { get; set; } = new();

		[ContainerField(144), JsonProperty(Order = 144)]
		public List<LinearTransform> Mesh3pTransforms { get; set; } = new();

	}
}
