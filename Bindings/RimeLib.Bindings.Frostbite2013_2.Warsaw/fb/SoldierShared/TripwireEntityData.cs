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
using fb.Audio;
using fb.Entity;

namespace fb.SoldierShared;

[ContainerType(16, 256)]
public class TripwireEntityData
	: fb.Entity.GameComponentEntityData
{
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec3 WireMeshScale { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec3 WireOriginOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<ObjectBlueprint> WireMesh { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public MaterialDecl WireImpactMaterial { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public CtrRef<SoundAsset> DeploySoundEffect { get; set; } = new();
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public CtrRef<SoundAsset> TripSoundEffect { get; set; } = new();
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public int MaxWireCount { get; set; } = 6;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float WireMaxLength { get; set; } = 10.000f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float WireMinLength { get; set; } = 1.000f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float WireMin2DLength { get; set; } = 0.400f;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float WireMinVerticalOffset { get; set; } = 0.000f;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public float MinYaw { get; set; } = -150.000f;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public float MaxYaw { get; set; } = 150.000f;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public float MinPitch { get; set; } = 30.000f;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public float MaxPitch { get; set; } = 85.000f;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public uint DensityAngle { get; set; } = 30;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public float WireDeploySpeed { get; set; } = 36.000f;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public bool AttachWiresToNeutralVehicles { get; set; } = true;
	
	[ContainerField(0xed), LayoutImmutable, Blittable, JsonProperty(Order = 237)]
	public bool AttachWiresToHostileVehicles { get; set; } = true;
	
	[ContainerField(0xee), LayoutImmutable, Blittable, JsonProperty(Order = 238)]
	public bool AttachWiresToFriendlyVehicles { get; set; } = false;
	
	[ContainerField(0xef), LayoutImmutable, Blittable, JsonProperty(Order = 239)]
	public bool ForceTripByFriendlyVehicles { get; set; } = false;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public bool ForceTripByFriendlySoldiers { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		WireMeshScale.Serialize(p_Writer, p_EbxWriter);
		WireOriginOffset.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(WireMesh));
		p_Writer.WriteNullBytes(4);
		WireImpactMaterial.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DeploySoundEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(TripSoundEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MaxWireCount);
		p_Writer.Write(WireMaxLength);
		p_Writer.Write(WireMinLength);
		p_Writer.Write(WireMin2DLength);
		p_Writer.Write(WireMinVerticalOffset);
		p_Writer.Write(MinYaw);
		p_Writer.Write(MaxYaw);
		p_Writer.Write(MinPitch);
		p_Writer.Write(MaxPitch);
		p_Writer.Write(DensityAngle);
		p_Writer.Write(WireDeploySpeed);
		p_Writer.Write(AttachWiresToNeutralVehicles);
		p_Writer.Write(AttachWiresToHostileVehicles);
		p_Writer.Write(AttachWiresToFriendlyVehicles);
		p_Writer.Write(ForceTripByFriendlyVehicles);
		p_Writer.Write(ForceTripByFriendlySoldiers);
		p_Writer.WriteNullBytes(15);
	}
}

