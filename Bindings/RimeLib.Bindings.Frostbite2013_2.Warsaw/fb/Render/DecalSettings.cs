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

namespace fb.Render;

[ContainerType(8, 56)]
public class DecalSettings
	: fb.Core.SystemSettings
{
	public DecalSettings()
	{
		//SystemSettings
		Name = @"Decal";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public uint DecalImpactLifetimeMs { get; set; } = 200;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public uint DecalImpactPoolSize { get; set; } = 512;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint StaticBufferMaxVertexCount { get; set; } = 16384;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public uint RingBufferMaxVertexCount { get; set; } = 16384;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x31), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
	public bool DrawEnable { get; set; } = true;
	
	[ContainerField(0x32), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
	public bool SystemEnable { get; set; } = true;
	
	[ContainerField(0x33), LayoutImmutable, Blittable, JsonProperty(Order = 51)]
	public bool SystemEnable2 { get; set; } = true;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public bool DrawDecalReflectionOnBreakableModelEnable { get; set; } = false;
	
	[ContainerField(0x35), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
	public bool DebugMemUsageEnable { get; set; } = false;
	
	[ContainerField(0x36), LayoutImmutable, Blittable, JsonProperty(Order = 54)]
	public bool DebugWarningsEnable { get; set; } = false;
	
	[ContainerField(0x37), LayoutImmutable, Blittable, JsonProperty(Order = 55)]
	public bool NvidiaStreamOutputWorkaroundEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DecalImpactLifetimeMs);
		p_Writer.Write(DecalImpactPoolSize);
		p_Writer.Write(StaticBufferMaxVertexCount);
		p_Writer.Write(RingBufferMaxVertexCount);
		p_Writer.Write(Enable);
		p_Writer.Write(DrawEnable);
		p_Writer.Write(SystemEnable);
		p_Writer.Write(SystemEnable2);
		p_Writer.Write(DrawDecalReflectionOnBreakableModelEnable);
		p_Writer.Write(DebugMemUsageEnable);
		p_Writer.Write(DebugWarningsEnable);
		p_Writer.Write(NvidiaStreamOutputWorkaroundEnable);
	}
}

