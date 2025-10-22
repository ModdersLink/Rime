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
using fb.Entity;
using fb.Render;

namespace fb.GameShared;

[ContainerType(16, 304)]
public class AlternateCameraViewData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float FieldOfView { get; set; } = 20.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float FovTransitionTime { get; set; } = 0.100f;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 MeshOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 MeshScale { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public LinearTransform TransformModifier { get; set; } = new()
	{
		trans = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 0.000f,
		},
		up = new()
		{
			z = 0.000f,
			y = 1.000f,
			x = 0.000f,
		},
		forward = new()
		{
			z = 1.000f,
			y = 0.000f,
			x = 0.000f,
		},
		right = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 1.000f,
		},
	};
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float WorldSpaceLockEfficiency { get; set; } = 0.000f;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<RigidMeshAsset> Mesh { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<ObjectBlueprint> MaskMeshBlueprint { get; set; } = new();
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public HudData Hud { get; set; } = new();
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public float FadeInDuration { get; set; } = 0.100f;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public float FadeOutDuration { get; set; } = 0.100f;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public float BlackDuration { get; set; } = 0.100f;
	
	[ContainerField(0x118), JsonProperty(Order = 280)]
	public InputSuppressionData InputSuppression { get; set; } = new();
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public float ScreenExposureAreaScale { get; set; } = 1.000f;
	
	[ContainerField(0x124), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
	public bool AllowFieldOfViewScaling { get; set; } = false;
	
	[ContainerField(0x125), LayoutImmutable, Blittable, JsonProperty(Order = 293)]
	public bool LockMeshToRenderView { get; set; } = false;
	
	[ContainerField(0x126), LayoutImmutable, Blittable, JsonProperty(Order = 294)]
	public bool FadeToBlack { get; set; } = false;
	
	[ContainerField(0x127), LayoutImmutable, Blittable, JsonProperty(Order = 295)]
	public bool ToggleViewChange { get; set; } = true;
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public bool UseProfileOptionForToggleViewChange { get; set; } = false;
	
	[ContainerField(0x129), LayoutImmutable, Blittable, JsonProperty(Order = 297)]
	public bool FLIREnabled { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FieldOfView);
		p_Writer.Write(FovTransitionTime);
		p_Writer.WriteNullBytes(8);
		MeshOffset.Serialize(p_Writer, p_EbxWriter);
		MeshScale.Serialize(p_Writer, p_EbxWriter);
		TransformModifier.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(WorldSpaceLockEfficiency);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(MaskMeshBlueprint));
		p_Writer.WriteNullBytes(4);
		Hud.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FadeInDuration);
		p_Writer.Write(FadeOutDuration);
		p_Writer.Write(BlackDuration);
		p_Writer.WriteNullBytes(4);
		InputSuppression.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ScreenExposureAreaScale);
		p_Writer.Write(AllowFieldOfViewScaling);
		p_Writer.Write(LockMeshToRenderView);
		p_Writer.Write(FadeToBlack);
		p_Writer.Write(ToggleViewChange);
		p_Writer.Write(UseProfileOptionForToggleViewChange);
		p_Writer.Write(FLIREnabled);
		p_Writer.WriteNullBytes(6);
	}
}

