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
using fb.Entity;

namespace fb.GameCommon;

[ContainerType(8, 32)]
public class SubLevelBundleInfo
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public int CompartmentIndex { get; set; } = 0;
	
	[ContainerField(0x4), JsonProperty(Order = 4)]
	public BundleHeapInfo HeapInfo { get; set; } = new();
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string Name { get; set; } = string.Empty;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public ushort SubLevelNameInx { get; set; } = 0;
	
	[ContainerField(0x1a), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
	public ushort SubLevelId { get; set; } = 0;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public ushort ParentSubLevelId { get; set; } = 0;
	
	[ContainerField(0x1e), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
	public byte Priority { get; set; } = 0;
	
	[ContainerField(0x1f), LayoutImmutable, Blittable, JsonProperty(Order = 31)]
	public bool IsBlueprintBundle { get; set; } = false;
	
}

