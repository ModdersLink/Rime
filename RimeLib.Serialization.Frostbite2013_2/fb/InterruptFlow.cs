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


namespace fb.UI;

[ContainerType(8, 16)]
public class InterruptFlow
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public UIInterruptID interruptEnum { get; set; } = UIInterruptID.UIInterruptID_None;
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public CtrRef<UIGraphAsset> interruptFlow { get; set; } = new();
	
}

