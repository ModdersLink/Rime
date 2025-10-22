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

using fb.Entity;
using fb.Render;
using fb.Core;
using fb.Physics;

namespace fb.WaterInteract;

[ContainerType(16, 848)]
public class WaterInteractEntityData
	: fb.Physics.GamePhysicsEntityData
{
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec3 TileOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public AmbientWaveSettings AmbientWaveSettings { get; set; } = new();
	
	[ContainerField(0x1a0), JsonProperty(Order = 416)]
	public AmbientWaveSettings DetailWaveSettings { get; set; } = new();
	
	[ContainerField(0x2a0), JsonProperty(Order = 672)]
	public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new();
	
	[ContainerField(0x2a8), LayoutImmutable, Blittable, JsonProperty(Order = 680)]
	public float ProjectorElevation { get; set; } = 8.000f;
	
	[ContainerField(0x2ac), LayoutImmutable, Blittable, JsonProperty(Order = 684)]
	public float WaveAmplitudeScale { get; set; } = 1.000f;
	
	[ContainerField(0x2b0), LayoutImmutable, Blittable, JsonProperty(Order = 688)]
	public float Choppiness { get; set; } = 1.000f;
	
	[ContainerField(0x2b4), LayoutImmutable, Blittable, JsonProperty(Order = 692)]
	public float TileDimension { get; set; } = 64.000f;
	
	[ContainerField(0x2b8), JsonProperty(Order = 696)]
	public PlatformScalableInt SimulationResolution { get; set; } = new()
	{
		Gen4b = 64,
		Gen4a = 64,
		Ps3 = 32,
		Xenon = 32,
		Default = 64,
	};
	
	[ContainerField(0x2cc), LayoutImmutable, Blittable, JsonProperty(Order = 716)]
	public float DetailTileDimension { get; set; } = 64.000f;
	
	[ContainerField(0x2d0), JsonProperty(Order = 720)]
	public QualityScalableInt DetailSimulationResolution { get; set; } = new()
	{
		Ultra = 64,
		High = 64,
		Medium = 64,
		Low = 32,
	};
	
	[ContainerField(0x2e0), JsonProperty(Order = 736)]
	public CtrRef<WaterEffectSetup> EffectSetup { get; set; } = new();
	
	[ContainerField(0x2e8), LayoutImmutable, Blittable, JsonProperty(Order = 744)]
	public float ShoreWaveAmplitude { get; set; } = 0.300f;
	
	[ContainerField(0x2ec), LayoutImmutable, Blittable, JsonProperty(Order = 748)]
	public float ShoreWaveFrequency { get; set; } = 0.300f;
	
	[ContainerField(0x2f0), LayoutImmutable, Blittable, JsonProperty(Order = 752)]
	public float ShoreWindAngle { get; set; } = 0.000f;
	
	[ContainerField(0x2f4), LayoutImmutable, Blittable, JsonProperty(Order = 756)]
	public float ShoreWindWavelength { get; set; } = 4.000f;
	
	[ContainerField(0x2f8), LayoutImmutable, Blittable, JsonProperty(Order = 760)]
	public float ShoreWavelength { get; set; } = 4.000f;
	
	[ContainerField(0x2fc), LayoutImmutable, Blittable, JsonProperty(Order = 764)]
	public float ShoreDepth { get; set; } = 16.000f;
	
	[ContainerField(0x300), JsonProperty(Order = 768)]
	public MaterialDecl MaterialPair { get; set; } = new();
	
	[ContainerField(0x304), JsonProperty(Order = 772)]
	public QualityScalableInt InteractiveWavesGridCount { get; set; } = new()
	{
		Ultra = 16,
		High = 16,
		Medium = 16,
		Low = 12,
	};
	
	[ContainerField(0x314), JsonProperty(Order = 788)]
	public QualityScalableInt InteractiveWavesCellCount { get; set; } = new()
	{
		Ultra = 256,
		High = 256,
		Medium = 256,
		Low = 256,
	};
	
	[ContainerField(0x324), LayoutImmutable, Blittable, JsonProperty(Order = 804)]
	public float InteractiveWaveDisturbanceScale { get; set; } = 1.000f;
	
	[ContainerField(0x328), JsonProperty(Order = 808)]
	public CtrRef<TextureAsset> InteractiveFoamSplatTexture { get; set; } = new();
	
	[ContainerField(0x330), LayoutImmutable, Blittable, JsonProperty(Order = 816)]
	public float InteractiveFoamHalfLife { get; set; } = 2.000f;
	
	[ContainerField(0x334), LayoutImmutable, Blittable, JsonProperty(Order = 820)]
	public float InteractiveFoamTargetScale { get; set; } = 5.000f;
	
	[ContainerField(0x338), LayoutImmutable, Blittable, JsonProperty(Order = 824)]
	public float InteractiveFoamSplatInterval { get; set; } = 0.100f;
	
	[ContainerField(0x33c), JsonProperty(Order = 828)]
	public WaterEntityClipInfo ClipInfo { get; set; } = new();
	
	[ContainerField(0x341), LayoutImmutable, Blittable, JsonProperty(Order = 833)]
	public bool WaveSimulation { get; set; } = true;
	
	[ContainerField(0x342), LayoutImmutable, Blittable, JsonProperty(Order = 834)]
	public bool Visible { get; set; } = true;
	
	[ContainerField(0x343), JsonProperty(Order = 835)]
	public QualityScalableBool DetailSimulation { get; set; } = new()
	{
		Ultra = true,
		High = true,
		Medium = true,
	};
	
	[ContainerField(0x347), LayoutImmutable, Blittable, JsonProperty(Order = 839)]
	public bool ShorelineEnable { get; set; } = false;
	
	[ContainerField(0x348), JsonProperty(Order = 840)]
	public QualityScalableBool InteractiveWavesEnable { get; set; } = new()
	{
		Ultra = true,
		High = true,
		Medium = true,
		Low = true,
	};
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		TileOffset.Serialize(p_Writer, p_EbxWriter);
		AmbientWaveSettings.Serialize(p_Writer, p_EbxWriter);
		DetailWaveSettings.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Shader));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ProjectorElevation);
		p_Writer.Write(WaveAmplitudeScale);
		p_Writer.Write(Choppiness);
		p_Writer.Write(TileDimension);
		SimulationResolution.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DetailTileDimension);
		DetailSimulationResolution.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(EffectSetup));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ShoreWaveAmplitude);
		p_Writer.Write(ShoreWaveFrequency);
		p_Writer.Write(ShoreWindAngle);
		p_Writer.Write(ShoreWindWavelength);
		p_Writer.Write(ShoreWavelength);
		p_Writer.Write(ShoreDepth);
		MaterialPair.Serialize(p_Writer, p_EbxWriter);
		InteractiveWavesGridCount.Serialize(p_Writer, p_EbxWriter);
		InteractiveWavesCellCount.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(InteractiveWaveDisturbanceScale);
		p_Writer.Write(p_EbxWriter.WriteImport(InteractiveFoamSplatTexture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(InteractiveFoamHalfLife);
		p_Writer.Write(InteractiveFoamTargetScale);
		p_Writer.Write(InteractiveFoamSplatInterval);
		ClipInfo.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(WaveSimulation);
		p_Writer.Write(Visible);
		DetailSimulation.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ShorelineEnable);
		InteractiveWavesEnable.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
	}
}

