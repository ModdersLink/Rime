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

namespace fb.GameShared;

[ContainerType(4, 12)]
public class LockingAndHomingData
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public WarnTarget WarnLock { get; set; } = WarnTarget.wtWarnNone;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public bool IsHoming { get; set; } = true;
	
	[ContainerField(0x5), LayoutImmutable, Blittable, JsonProperty(Order = 5)]
	public bool IsGuided { get; set; } = false;
	
	[ContainerField(0x6), LayoutImmutable, Blittable, JsonProperty(Order = 6)]
	public bool IsGuidedWhenZoomed { get; set; } = false;
	
	[ContainerField(0x7), LayoutImmutable, Blittable, JsonProperty(Order = 7)]
	public bool IsGuidedHoming { get; set; } = false;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public bool FireOnlyWhenLockedOn { get; set; } = false;
	
}

