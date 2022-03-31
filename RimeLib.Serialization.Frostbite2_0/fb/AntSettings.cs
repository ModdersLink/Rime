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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 68)]
	public class AntSettings :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float DetailedCollisionSpeedLimit { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float LeanSignalScale { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float LeanSignalClamp { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public int MaxInterpolationSlots { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public int MaxSingleBoneInterpolationSlots { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float ReducedInterpolationDistance { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float TrajectoryInterpolationDistance { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float ForceLodDistance { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public int MaxAnimatablesPerPoseJob { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float CheckGiantSoldiers { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public bool ClientEmulatesServer { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
		public bool UseCameraFov { get; set; }

		[ContainerField(50), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
		public bool UpdateEnable { get; set; }

		[ContainerField(51), LayoutImmutable, Blittable, JsonProperty(Order = 51)]
		public bool EnablePA { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public bool UseWeaponFov { get; set; }

		[ContainerField(53), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
		public bool DisableAnimManagerSceneOps { get; set; }

		[ContainerField(54), LayoutImmutable, Blittable, JsonProperty(Order = 54)]
		public bool DisableAILodFeature { get; set; }

		[ContainerField(55), LayoutImmutable, Blittable, JsonProperty(Order = 55)]
		public bool DisableModelAnimationCulling { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public bool EnableJobs { get; set; }

		[ContainerField(57), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
		public bool ForcePoseUpdate { get; set; }

		[ContainerField(58), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
		public bool RunAsHighPriority { get; set; }

		[ContainerField(59), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
		public bool InterpolatePoses { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public bool AllowVariableTickLength { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		public bool EnablePackageCache { get; set; }

		[ContainerField(62), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
		public bool UseHIK { get; set; }

		[ContainerField(63), LayoutImmutable, Blittable, JsonProperty(Order = 63)]
		public bool UpdateLoddingEnable { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public bool BlockOnJobs { get; set; }

		[ContainerField(65), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
		public bool EnableDebugLogFile { get; set; }

		[ContainerField(66), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
		public bool EnablePoseJobs { get; set; }

		[ContainerField(67), LayoutImmutable, Blittable, JsonProperty(Order = 67)]
		public bool UsePA { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(DetailedCollisionSpeedLimit);
			p_Writer.Write(LeanSignalScale);
			p_Writer.Write(LeanSignalClamp);
			p_Writer.Write(MaxInterpolationSlots);
			p_Writer.Write(MaxSingleBoneInterpolationSlots);
			p_Writer.Write(ReducedInterpolationDistance);
			p_Writer.Write(TrajectoryInterpolationDistance);
			p_Writer.Write(ForceLodDistance);
			p_Writer.Write(MaxAnimatablesPerPoseJob);
			p_Writer.Write(CheckGiantSoldiers);
			p_Writer.Write(ClientEmulatesServer);
			p_Writer.Write(UseCameraFov);
			p_Writer.Write(UpdateEnable);
			p_Writer.Write(EnablePA);
			p_Writer.Write(UseWeaponFov);
			p_Writer.Write(DisableAnimManagerSceneOps);
			p_Writer.Write(DisableAILodFeature);
			p_Writer.Write(DisableModelAnimationCulling);
			p_Writer.Write(EnableJobs);
			p_Writer.Write(ForcePoseUpdate);
			p_Writer.Write(RunAsHighPriority);
			p_Writer.Write(InterpolatePoses);
			p_Writer.Write(AllowVariableTickLength);
			p_Writer.Write(EnablePackageCache);
			p_Writer.Write(UseHIK);
			p_Writer.Write(UpdateLoddingEnable);
			p_Writer.Write(BlockOnJobs);
			p_Writer.Write(EnableDebugLogFile);
			p_Writer.Write(EnablePoseJobs);
			p_Writer.Write(UsePA);
		}
	}
}
