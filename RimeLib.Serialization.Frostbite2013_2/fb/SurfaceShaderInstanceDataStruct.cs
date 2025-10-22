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


namespace fb.Render;

[ContainerType(8, 40)]
public class SurfaceShaderInstanceDataStruct
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new();
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public List<BoolShaderParameter> BoolParameters { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<VectorShaderParameter> VectorParameters { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<VectorArrayShaderParameter> VectorArrayParameters { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<TextureShaderParameter> TextureParameters { get; set; } = new();
	
}

