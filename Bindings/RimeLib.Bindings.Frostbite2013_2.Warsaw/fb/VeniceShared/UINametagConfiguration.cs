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
using fb.GameShared;

namespace fb.VeniceShared;

[ContainerType(8, 336)]
public class UINametagConfiguration
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float VerticalSoldierOffset { get; set; } = 0.000f;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<UIElementFontStyle> NameFont { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public int VerticalNameOffset { get; set; } = -40;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<UIElementFontStyle> DistanceFont { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public int VerticalDistanceOffset { get; set; } = -20;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float HealthBarWidth { get; set; } = 74.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public int HealthBarVerticalOffset { get; set; } = -20;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float HealthBarBgOpacity { get; set; } = 0.250f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public uint HealthBarBgLineWidth { get; set; } = 8;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public uint HealthBarLineWidth { get; set; } = 6;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float LookAtObjectRadiusMultiplier { get; set; } = 0.800f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float MinObjectLookAtRadius { get; set; } = 25.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float HudElementLookAtRadius { get; set; } = 30.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float SpottedBlinkRate { get; set; } = 0.200f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float SpottedMinAlpha { get; set; } = 0.300f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public uint IconScalingStartDistance { get; set; } = 30;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public uint IconScalingStopDistance { get; set; } = 150;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float IconMinScale { get; set; } = 0.500f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float MapIconMinHeightThreshold { get; set; } = 5.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float MapIconMaxHeightThreshold { get; set; } = 10.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float MapIconMinScale { get; set; } = 0.750f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float MapIconMinOpacity { get; set; } = 0.650f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float MapIconMaxScale { get; set; } = 1.200f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float IconSpacingMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public UINametagBehavior SquadBehavior { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public UINametagBehavior FriendlyBehavior { get; set; } = new();
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public UINametagBehavior ImportantFriendlyBehavior { get; set; } = new();
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public UINametagBehavior FriendlyGadgetBehavior { get; set; } = new();
	
	[ContainerField(0xe8), JsonProperty(Order = 232)]
	public UINametagBehavior NeutralBehavior { get; set; } = new();
	
	[ContainerField(0x100), JsonProperty(Order = 256)]
	public UINametagBehavior EnemyBehavior { get; set; } = new();
	
	[ContainerField(0x118), JsonProperty(Order = 280)]
	public UINametagBehavior SpottedEnemyBehavior { get; set; } = new();
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public float ActiveBlinkRate { get; set; } = 0.100f;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public float FadeInTime { get; set; } = 0.200f;
	
	[ContainerField(0x138), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
	public float FadeOutTime { get; set; } = 0.200f;
	
	[ContainerField(0x13c), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
	public float PotentialTargetOpacity { get; set; } = 0.500f;
	
	[ContainerField(0x140), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
	public float RepairIconScale { get; set; } = 1.000f;
	
	[ContainerField(0x144), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
	public float RepairDirectionOffset { get; set; } = 22.000f;
	
	[ContainerField(0x148), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
	public bool DimIconsAbove { get; set; } = false;
	
	[ContainerField(0x149), LayoutImmutable, Blittable, JsonProperty(Order = 329)]
	public bool DimIconsBelow { get; set; } = true;
	
	[ContainerField(0x14a), LayoutImmutable, Blittable, JsonProperty(Order = 330)]
	public bool ScaleUpIconsAbove { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(VerticalSoldierOffset);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(NameFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(VerticalNameOffset);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DistanceFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(VerticalDistanceOffset);
		p_Writer.Write(HealthBarWidth);
		p_Writer.Write(HealthBarVerticalOffset);
		p_Writer.Write(HealthBarBgOpacity);
		p_Writer.Write(HealthBarBgLineWidth);
		p_Writer.Write(HealthBarLineWidth);
		p_Writer.Write(LookAtObjectRadiusMultiplier);
		p_Writer.Write(MinObjectLookAtRadius);
		p_Writer.Write(HudElementLookAtRadius);
		p_Writer.Write(SpottedBlinkRate);
		p_Writer.Write(SpottedMinAlpha);
		p_Writer.Write(IconScalingStartDistance);
		p_Writer.Write(IconScalingStopDistance);
		p_Writer.Write(IconMinScale);
		p_Writer.Write(MapIconMinHeightThreshold);
		p_Writer.Write(MapIconMaxHeightThreshold);
		p_Writer.Write(MapIconMinScale);
		p_Writer.Write(MapIconMinOpacity);
		p_Writer.Write(MapIconMaxScale);
		p_Writer.Write(IconSpacingMultiplier);
		SquadBehavior.Serialize(p_Writer, p_EbxWriter);
		FriendlyBehavior.Serialize(p_Writer, p_EbxWriter);
		ImportantFriendlyBehavior.Serialize(p_Writer, p_EbxWriter);
		FriendlyGadgetBehavior.Serialize(p_Writer, p_EbxWriter);
		NeutralBehavior.Serialize(p_Writer, p_EbxWriter);
		EnemyBehavior.Serialize(p_Writer, p_EbxWriter);
		SpottedEnemyBehavior.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ActiveBlinkRate);
		p_Writer.Write(FadeInTime);
		p_Writer.Write(FadeOutTime);
		p_Writer.Write(PotentialTargetOpacity);
		p_Writer.Write(RepairIconScale);
		p_Writer.Write(RepairDirectionOffset);
		p_Writer.Write(DimIconsAbove);
		p_Writer.Write(DimIconsBelow);
		p_Writer.Write(ScaleUpIconsAbove);
		p_Writer.WriteNullBytes(5);
	}
}

