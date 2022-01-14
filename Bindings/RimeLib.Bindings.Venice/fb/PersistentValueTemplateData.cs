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
	[ContainerType(4, 36)]
	public class PersistentValueTemplateData
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string Name { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		public string DefaultValue { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float DefaultFloatValue { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public int DefaultIntValue { get; set; }
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public PersistentValueType ValueType { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public PersistentValueDataType DataType { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public PersistentValueHistoryType HistoryType { get; set; } = new();
		
		[ContainerField(28), JsonProperty(Order = 28)]
		public AwardGroup Group { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool ClubStat { get; set; }
		
		[ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		public bool ForceIntoTemplate { get; set; }
		
	}
}
