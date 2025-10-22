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

namespace fb.Debris;

[ContainerType(8, 56)]
public class DebrisSystemSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float TimeScale { get; set; } = 1.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public uint DrawStats { get; set; } = 0;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float MeshCullingDistance { get; set; } = 150.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public uint MeshBatchCountLimit { get; set; } = 512;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public uint DebrisPoolSize { get; set; } = 512;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public uint MeshDrawCountLimit { get; set; } = 2000;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float MeshStreamingPriorityMultiplier { get; set; } = 4.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x2d), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
	public bool EnableJobs { get; set; } = true;
	
	[ContainerField(0x2e), LayoutImmutable, Blittable, JsonProperty(Order = 46)]
	public bool DrawEnable { get; set; } = true;
	
	[ContainerField(0x2f), LayoutImmutable, Blittable, JsonProperty(Order = 47)]
	public bool MeshHavokRenderingEnable { get; set; } = true;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool MeshDrawTransforms { get; set; } = false;
	
	[ContainerField(0x31), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
	public bool MeshDrawBoundingBoxes { get; set; } = false;
	
	[ContainerField(0x32), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
	public bool MeshShadowEnable { get; set; } = true;
	
	[ContainerField(0x33), LayoutImmutable, Blittable, JsonProperty(Order = 51)]
	public bool MeshViewCullingEnable { get; set; } = true;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public bool MeshDrawCullStats { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TimeScale);
		p_Writer.Write(DrawStats);
		p_Writer.Write(MeshCullingDistance);
		p_Writer.Write(MeshBatchCountLimit);
		p_Writer.Write(DebrisPoolSize);
		p_Writer.Write(MeshDrawCountLimit);
		p_Writer.Write(MeshStreamingPriorityMultiplier);
		p_Writer.Write(Enable);
		p_Writer.Write(EnableJobs);
		p_Writer.Write(DrawEnable);
		p_Writer.Write(MeshHavokRenderingEnable);
		p_Writer.Write(MeshDrawTransforms);
		p_Writer.Write(MeshDrawBoundingBoxes);
		p_Writer.Write(MeshShadowEnable);
		p_Writer.Write(MeshViewCullingEnable);
		p_Writer.Write(MeshDrawCullStats);
		p_Writer.WriteNullBytes(3);
	}
}

