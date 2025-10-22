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

using fb.Core;

namespace fb.Entity;

[ContainerType(8, 32)]
public class EventConnection
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public CtrRef<DataContainer> Source { get; set; } = new();
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public CtrRef<DataContainer> Target { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public EventSpec SourceEvent { get; set; } = new();
	
	[ContainerField(0x14), JsonProperty(Order = 20)]
	public EventSpec TargetEvent { get; set; } = new();
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public EventConnectionTargetType TargetType { get; set; } = EventConnectionTargetType.EventConnectionTargetType_Invalid;
	
}

