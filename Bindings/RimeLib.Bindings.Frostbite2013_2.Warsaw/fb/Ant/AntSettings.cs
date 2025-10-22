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

namespace fb.Ant;

[ContainerType(8, 88)]
public class AntSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float ForceLodDistance { get; set; } = -1.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public int MaxAnimatablesPerPoseJob { get; set; } = -1;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float ReducedInterpolationDistance { get; set; } = 0.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float TrajectoryInterpolationDistance { get; set; } = 0.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int MaxInterpolationSlots { get; set; } = 32;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public int MaxSingleBoneInterpolationSlots { get; set; } = 10;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float CheckGiantSoldiers { get; set; } = 0.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float LeanSignalScale { get; set; } = 0.200f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float LeanSignalClamp { get; set; } = 7.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float DetailedCollisionSpeedLimit { get; set; } = 3.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float MaxInterpolationDistance { get; set; } = 10.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public int MaxInterpolationTicks { get; set; } = 10;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public int AutoCullPixelSize { get; set; } = 0;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public bool UsePA { get; set; } = false;
	
	[ContainerField(0x45), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
	public bool UseHIK { get; set; } = true;
	
	[ContainerField(0x46), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
	public bool BlockOnJobs { get; set; } = true;
	
	[ContainerField(0x47), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
	public bool InterpolatePoses { get; set; } = false;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public bool AllowVariableTickLength { get; set; } = false;
	
	[ContainerField(0x49), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
	public bool UseWeaponFov { get; set; } = false;
	
	[ContainerField(0x4a), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
	public bool ForcePoseUpdate { get; set; } = false;
	
	[ContainerField(0x4b), LayoutImmutable, Blittable, JsonProperty(Order = 75)]
	public bool UseCameraFov { get; set; } = false;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public bool EnablePA { get; set; } = false;
	
	[ContainerField(0x4d), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
	public bool ClientEmulatesServer { get; set; } = false;
	
	[ContainerField(0x4e), LayoutImmutable, Blittable, JsonProperty(Order = 78)]
	public bool UpdateEnable { get; set; } = true;
	
	[ContainerField(0x4f), LayoutImmutable, Blittable, JsonProperty(Order = 79)]
	public bool EnablePackageCache { get; set; } = true;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool EnableDebugLogFile { get; set; } = false;
	
	[ContainerField(0x51), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
	public bool EnablePoseJobs { get; set; } = true;
	
	[ContainerField(0x52), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
	public bool DisableAILodFeature { get; set; } = true;
	
	[ContainerField(0x53), LayoutImmutable, Blittable, JsonProperty(Order = 83)]
	public bool DisableModelAnimationCulling { get; set; } = false;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public bool EnableJobs { get; set; } = false;
	
	[ContainerField(0x55), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
	public bool RunAsHighPriority { get; set; } = true;
	
	[ContainerField(0x56), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
	public bool UpdateLoddingEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ForceLodDistance);
		p_Writer.Write(MaxAnimatablesPerPoseJob);
		p_Writer.Write(ReducedInterpolationDistance);
		p_Writer.Write(TrajectoryInterpolationDistance);
		p_Writer.Write(MaxInterpolationSlots);
		p_Writer.Write(MaxSingleBoneInterpolationSlots);
		p_Writer.Write(CheckGiantSoldiers);
		p_Writer.Write(LeanSignalScale);
		p_Writer.Write(LeanSignalClamp);
		p_Writer.Write(DetailedCollisionSpeedLimit);
		p_Writer.Write(MaxInterpolationDistance);
		p_Writer.Write(MaxInterpolationTicks);
		p_Writer.Write(AutoCullPixelSize);
		p_Writer.Write(UsePA);
		p_Writer.Write(UseHIK);
		p_Writer.Write(BlockOnJobs);
		p_Writer.Write(InterpolatePoses);
		p_Writer.Write(AllowVariableTickLength);
		p_Writer.Write(UseWeaponFov);
		p_Writer.Write(ForcePoseUpdate);
		p_Writer.Write(UseCameraFov);
		p_Writer.Write(EnablePA);
		p_Writer.Write(ClientEmulatesServer);
		p_Writer.Write(UpdateEnable);
		p_Writer.Write(EnablePackageCache);
		p_Writer.Write(EnableDebugLogFile);
		p_Writer.Write(EnablePoseJobs);
		p_Writer.Write(DisableAILodFeature);
		p_Writer.Write(DisableModelAnimationCulling);
		p_Writer.Write(EnableJobs);
		p_Writer.Write(RunAsHighPriority);
		p_Writer.Write(UpdateLoddingEnable);
		p_Writer.WriteNullBytes(1);
	}
}

