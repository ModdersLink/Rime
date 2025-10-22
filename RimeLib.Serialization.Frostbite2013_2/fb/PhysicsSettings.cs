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

namespace fb.Physics;

[ContainerType(8, 80)]
public class PhysicsSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint ClientEffectWorldThreadCount { get; set; } = 3;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public uint ClientClothWorldThreadCount { get; set; } = 6;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public uint ClientWorldThreadCount { get; set; } = 1;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public uint ServerWorldThreadCount { get; set; } = 2;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public uint IntegrateJobCount { get; set; } = 2;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public uint CollideJobCount { get; set; } = 4;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint ClothJobCount { get; set; } = 2;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float WindManagerAwakeningRadius { get; set; } = 20.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public uint ClientWorldWorkerThreadCount { get; set; } = 0;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public uint ServerWorldWorkerThreadCount { get; set; } = 0;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public uint EffectWorldWorkerThreadCount { get; set; } = 4294967295;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x3d), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
	public bool EnableClothInterpolationJobs { get; set; } = true;
	
	[ContainerField(0x3e), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
	public bool EnableClothUpdateJob { get; set; } = true;
	
	[ContainerField(0x3f), LayoutImmutable, Blittable, JsonProperty(Order = 63)]
	public bool EnableAIRigidBody { get; set; } = true;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public bool ForestEnable { get; set; } = true;
	
	[ContainerField(0x41), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
	public bool EnableJobs { get; set; } = true;
	
	[ContainerField(0x42), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
	public bool RemoveRagdollWhenWoken { get; set; } = true;
	
	[ContainerField(0x43), LayoutImmutable, Blittable, JsonProperty(Order = 67)]
	public bool RemoveFromWorldOnCollisionOverflow { get; set; } = true;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public bool SingleStepCharacter { get; set; } = true;
	
	[ContainerField(0x45), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
	public bool ForceSingleStepCharacterInSP { get; set; } = false;
	
	[ContainerField(0x46), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
	public bool EnableFollowWheelRaycasts { get; set; } = false;
	
	[ContainerField(0x47), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
	public bool EnableClientWheelRaycasts { get; set; } = true;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public bool EnableASyncWheelRaycasts { get; set; } = true;
	
	[ContainerField(0x49), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
	public bool UseDelayedWakeUpClient { get; set; } = true;
	
	[ContainerField(0x4a), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
	public bool UseDelayedWakeUpServer { get; set; } = false;
	
	[ContainerField(0x4b), LayoutImmutable, Blittable, JsonProperty(Order = 75)]
	public bool SuppressDebrisSpawnUntilReady { get; set; } = true;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public bool EnablePlayerVSAICollisions { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ClientEffectWorldThreadCount);
		p_Writer.Write(ClientClothWorldThreadCount);
		p_Writer.Write(ClientWorldThreadCount);
		p_Writer.Write(ServerWorldThreadCount);
		p_Writer.Write(IntegrateJobCount);
		p_Writer.Write(CollideJobCount);
		p_Writer.Write(ClothJobCount);
		p_Writer.Write(WindManagerAwakeningRadius);
		p_Writer.Write(ClientWorldWorkerThreadCount);
		p_Writer.Write(ServerWorldWorkerThreadCount);
		p_Writer.Write(EffectWorldWorkerThreadCount);
		p_Writer.Write(Enable);
		p_Writer.Write(EnableClothInterpolationJobs);
		p_Writer.Write(EnableClothUpdateJob);
		p_Writer.Write(EnableAIRigidBody);
		p_Writer.Write(ForestEnable);
		p_Writer.Write(EnableJobs);
		p_Writer.Write(RemoveRagdollWhenWoken);
		p_Writer.Write(RemoveFromWorldOnCollisionOverflow);
		p_Writer.Write(SingleStepCharacter);
		p_Writer.Write(ForceSingleStepCharacterInSP);
		p_Writer.Write(EnableFollowWheelRaycasts);
		p_Writer.Write(EnableClientWheelRaycasts);
		p_Writer.Write(EnableASyncWheelRaycasts);
		p_Writer.Write(UseDelayedWakeUpClient);
		p_Writer.Write(UseDelayedWakeUpServer);
		p_Writer.Write(SuppressDebrisSpawnUntilReady);
		p_Writer.Write(EnablePlayerVSAICollisions);
		p_Writer.WriteNullBytes(3);
	}
}

