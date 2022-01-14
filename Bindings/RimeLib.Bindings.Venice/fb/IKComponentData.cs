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
	[ContainerType(16, 128)]
	public class IKComponentData : 
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public IKEffectorEnum IKEffector { get; set; } = new();

		[ContainerField(100), JsonProperty(Order = 100)]
		public HIKData IKData { get; set; } = new();

	}
}
