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
	public class SubWorldInclusionSetting : 
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<SubWorldInclusionCriterion> Criterion { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public List<string> EnabledOptions { get; set; } = new();

	}
}
