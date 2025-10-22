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


namespace fb.Core;

[ContainerType(8, 48)]
public class ResourceManagerSettings
	: fb.Core.SystemSettings
{
	public ResourceManagerSettings()
	{
		//SystemSettings
		Name = @"ResourceManager";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int CasBundleReadBufferSizeKb { get; set; } = 256;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public int CasBundleDecompressBufferSizeKb { get; set; } = 128;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public int CasBundleDecompressBufferCount { get; set; } = 4;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public bool BundleProfilingEnable { get; set; } = false;
	
	[ContainerField(0x2d), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
	public bool SPUDecompressEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(CasBundleReadBufferSizeKb);
		p_Writer.Write(CasBundleDecompressBufferSizeKb);
		p_Writer.Write(CasBundleDecompressBufferCount);
		p_Writer.Write(BundleProfilingEnable);
		p_Writer.Write(SPUDecompressEnable);
		p_Writer.WriteNullBytes(2);
	}
}

