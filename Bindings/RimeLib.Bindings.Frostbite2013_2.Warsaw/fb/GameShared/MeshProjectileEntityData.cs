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
using fb.Entity;
using fb.Physics;

namespace fb.GameShared;

[ContainerType(16, 288)]
public class MeshProjectileEntityData
	: fb.GameShared.ProjectileEntityData
{
	[ContainerField(0xe0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public Vec3 InitialAngularVelocity { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public CtrRef<MeshAsset> Mesh { get; set; } = new();
	
	[ContainerField(0xf8), JsonProperty(Order = 248)]
	public CtrRef<EffectBlueprint> TrailEffect { get; set; } = new();
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public float InstantAttachableTestDistance { get; set; } = 3.000f;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public float InstantAttachableVisualConvergenceDelay { get; set; } = -1.000f;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public float InstantAttachableVisualConvergenceDuration { get; set; } = -1.000f;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public float MaxAttachableInclination { get; set; } = 45.000f;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public float UnspawnAfterDetonationDelay { get; set; } = 0.000f;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public bool IsAttachable { get; set; } = false;
	
	[ContainerField(0x115), LayoutImmutable, Blittable, JsonProperty(Order = 277)]
	public bool InstantAttachableTestUnderReticule { get; set; } = true;
	
	[ContainerField(0x116), LayoutImmutable, Blittable, JsonProperty(Order = 278)]
	public bool ExtraDamping { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		InitialAngularVelocity.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(TrailEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(InstantAttachableTestDistance);
		p_Writer.Write(InstantAttachableVisualConvergenceDelay);
		p_Writer.Write(InstantAttachableVisualConvergenceDuration);
		p_Writer.Write(MaxAttachableInclination);
		p_Writer.Write(UnspawnAfterDetonationDelay);
		p_Writer.Write(IsAttachable);
		p_Writer.Write(InstantAttachableTestUnderReticule);
		p_Writer.Write(ExtraDamping);
		p_Writer.WriteNullBytes(9);
	}
}

