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

namespace fb.Vegetation;

[ContainerType(8, 104)]
public class VegetationSystemSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float WindVariation { get; set; } = 1.100f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float WindVariationRate { get; set; } = 0.100f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float WindStrength { get; set; } = 2.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float WindMicroVariation { get; set; } = 1.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float MaxActiveDistance { get; set; } = 300.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float MaxEffectDistance { get; set; } = 50.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint MaxActiveBones { get; set; } = 15000;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public uint SimulationMemKbServer { get; set; } = 512;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public uint SimulationMemKbClient { get; set; } = 1024;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public uint MaxPreSimsPerJob { get; set; } = 4;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float MaxWiggleDistance { get; set; } = 100.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public int ForceShadowLod { get; set; } = -1;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float TimeScale { get; set; } = 1.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public uint JobCount { get; set; } = 6;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public int JointTensionLimitIndex { get; set; } = 0;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float JointTensionLimit { get; set; } = 0.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool SimulateServerSide { get; set; } = false;
	
	[ContainerField(0x51), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
	public bool DestructionEnabled { get; set; } = true;
	
	[ContainerField(0x52), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
	public bool SubDestructionEnabled { get; set; } = true;
	
	[ContainerField(0x53), LayoutImmutable, Blittable, JsonProperty(Order = 83)]
	public bool LocalInfluencesEnabled { get; set; } = true;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public bool UseShadowLodOffset { get; set; } = true;
	
	[ContainerField(0x55), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
	public bool ShadowMeshEnable { get; set; } = true;
	
	[ContainerField(0x56), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
	public bool DissolveEnable { get; set; } = false;
	
	[ContainerField(0x57), LayoutImmutable, Blittable, JsonProperty(Order = 87)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public bool EnableJobs { get; set; } = true;
	
	[ContainerField(0x59), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
	public bool DrawNodes { get; set; } = false;
	
	[ContainerField(0x5a), LayoutImmutable, Blittable, JsonProperty(Order = 90)]
	public bool DrawNodeIDs { get; set; } = false;
	
	[ContainerField(0x5b), LayoutImmutable, Blittable, JsonProperty(Order = 91)]
	public bool DrawNodeStiffness { get; set; } = false;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public bool DrawEnable { get; set; } = true;
	
	[ContainerField(0x5d), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
	public bool BatchDrawEnable { get; set; } = true;
	
	[ContainerField(0x5e), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
	public bool DrawNonSimulatedAsRigid { get; set; } = true;
	
	[ContainerField(0x5f), LayoutImmutable, Blittable, JsonProperty(Order = 95)]
	public bool DrawActiveInstanceBoxesEnable { get; set; } = false;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public bool DrawEffectDebugInfoEnable { get; set; } = false;
	
	[ContainerField(0x61), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
	public bool DrawDamageDebugInfoEnable { get; set; } = false;
	
	[ContainerField(0x62), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
	public bool DrawStatsEnable { get; set; } = false;
	
	[ContainerField(0x63), LayoutImmutable, Blittable, JsonProperty(Order = 99)]
	public bool ProceduralAnimationEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(WindVariation);
		p_Writer.Write(WindVariationRate);
		p_Writer.Write(WindStrength);
		p_Writer.Write(WindMicroVariation);
		p_Writer.Write(MaxActiveDistance);
		p_Writer.Write(MaxEffectDistance);
		p_Writer.Write(MaxActiveBones);
		p_Writer.Write(SimulationMemKbServer);
		p_Writer.Write(SimulationMemKbClient);
		p_Writer.Write(MaxPreSimsPerJob);
		p_Writer.Write(MaxWiggleDistance);
		p_Writer.Write(ForceShadowLod);
		p_Writer.Write(TimeScale);
		p_Writer.Write(JobCount);
		p_Writer.Write(JointTensionLimitIndex);
		p_Writer.Write(JointTensionLimit);
		p_Writer.Write(SimulateServerSide);
		p_Writer.Write(DestructionEnabled);
		p_Writer.Write(SubDestructionEnabled);
		p_Writer.Write(LocalInfluencesEnabled);
		p_Writer.Write(UseShadowLodOffset);
		p_Writer.Write(ShadowMeshEnable);
		p_Writer.Write(DissolveEnable);
		p_Writer.Write(Enable);
		p_Writer.Write(EnableJobs);
		p_Writer.Write(DrawNodes);
		p_Writer.Write(DrawNodeIDs);
		p_Writer.Write(DrawNodeStiffness);
		p_Writer.Write(DrawEnable);
		p_Writer.Write(BatchDrawEnable);
		p_Writer.Write(DrawNonSimulatedAsRigid);
		p_Writer.Write(DrawActiveInstanceBoxesEnable);
		p_Writer.Write(DrawEffectDebugInfoEnable);
		p_Writer.Write(DrawDamageDebugInfoEnable);
		p_Writer.Write(DrawStatsEnable);
		p_Writer.Write(ProceduralAnimationEnable);
		p_Writer.WriteNullBytes(4);
	}
}

