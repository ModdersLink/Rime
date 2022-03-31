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
	[ContainerType(16, 176)]
	public class SoldierEmoteComponentData : 
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public SoldierEmoteBinding Binding { get; set; } = new();

		[ContainerField(160), JsonProperty(Order = 160)]
		public RefArray<SoldierEmoteNetworkedMessageMapping> NetworkedMessageMappings { get; set; } = new();

	}
}
