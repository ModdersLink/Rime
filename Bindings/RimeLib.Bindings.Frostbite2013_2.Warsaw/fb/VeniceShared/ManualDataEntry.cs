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
using fb.Render;

namespace fb.VeniceShared;

[ContainerType(8, 16)]
public class ManualDataEntry
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public GamePlatform Platform { get; set; } = GamePlatform.GamePlatform_Ps3;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public LanguageFormat Language { get; set; } = LanguageFormat.LanguageFormat_English;
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public RefArray<TextureAsset> Textures { get; set; } = new();
	
}

