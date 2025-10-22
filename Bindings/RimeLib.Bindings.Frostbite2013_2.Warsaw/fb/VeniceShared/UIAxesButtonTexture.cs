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

using fb.GameShared;

namespace fb.VeniceShared;

[ContainerType(4, 20)]
public class UIAxesButtonTexture
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public InputDeviceAxes Axis { get; set; } = InputDeviceAxes.IDA_Axis0X;
	
	[ContainerField(0x4), JsonProperty(Order = 4)]
	public UITextureAtlasInfo AtlasInfo { get; set; } = new();
	
}

