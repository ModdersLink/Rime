///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 68)]
	public class AntSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float DetailedCollisionSpeedLimit { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float LeanSignalScale { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float LeanSignalClamp { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public int MaxInterpolationSlots { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public int MaxSingleBoneInterpolationSlots { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float ReducedInterpolationDistance { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float TrajectoryInterpolationDistance { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float ForceLodDistance { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public int MaxAnimatablesPerPoseJob { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float CheckGiantSoldiers { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public bool ClientEmulatesServer { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable]
		public bool UseCameraFov { get; set; }

		[ContainerField(50), LayoutImmutable, Blittable]
		public bool UpdateEnable { get; set; }

		[ContainerField(51), LayoutImmutable, Blittable]
		public bool EnablePA { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public bool UseWeaponFov { get; set; }

		[ContainerField(53), LayoutImmutable, Blittable]
		public bool DisableAnimManagerSceneOps { get; set; }

		[ContainerField(54), LayoutImmutable, Blittable]
		public bool DisableAILodFeature { get; set; }

		[ContainerField(55), LayoutImmutable, Blittable]
		public bool DisableModelAnimationCulling { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public bool EnableJobs { get; set; }

		[ContainerField(57), LayoutImmutable, Blittable]
		public bool ForcePoseUpdate { get; set; }

		[ContainerField(58), LayoutImmutable, Blittable]
		public bool RunAsHighPriority { get; set; }

		[ContainerField(59), LayoutImmutable, Blittable]
		public bool InterpolatePoses { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public bool AllowVariableTickLength { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable]
		public bool EnablePackageCache { get; set; }

		[ContainerField(62), LayoutImmutable, Blittable]
		public bool UseHIK { get; set; }

		[ContainerField(63), LayoutImmutable, Blittable]
		public bool UpdateLoddingEnable { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public bool BlockOnJobs { get; set; }

		[ContainerField(65), LayoutImmutable, Blittable]
		public bool EnableDebugLogFile { get; set; }

		[ContainerField(66), LayoutImmutable, Blittable]
		public bool EnablePoseJobs { get; set; }

		[ContainerField(67), LayoutImmutable, Blittable]
		public bool UsePA { get; set; }

		public static void Deserialize(AntSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DetailedCollisionSpeedLimit = p_Reader.ReadSingle();
			p_Instance.LeanSignalScale = p_Reader.ReadSingle();
			p_Instance.LeanSignalClamp = p_Reader.ReadSingle();
			p_Instance.MaxInterpolationSlots = p_Reader.ReadInt32();
			p_Instance.MaxSingleBoneInterpolationSlots = p_Reader.ReadInt32();
			p_Instance.ReducedInterpolationDistance = p_Reader.ReadSingle();
			p_Instance.TrajectoryInterpolationDistance = p_Reader.ReadSingle();
			p_Instance.ForceLodDistance = p_Reader.ReadSingle();
			p_Instance.MaxAnimatablesPerPoseJob = p_Reader.ReadInt32();
			p_Instance.CheckGiantSoldiers = p_Reader.ReadSingle();
			p_Instance.ClientEmulatesServer = p_Reader.ReadBool();
			p_Instance.UseCameraFov = p_Reader.ReadBool();
			p_Instance.UpdateEnable = p_Reader.ReadBool();
			p_Instance.EnablePA = p_Reader.ReadBool();
			p_Instance.UseWeaponFov = p_Reader.ReadBool();
			p_Instance.DisableAnimManagerSceneOps = p_Reader.ReadBool();
			p_Instance.DisableAILodFeature = p_Reader.ReadBool();
			p_Instance.DisableModelAnimationCulling = p_Reader.ReadBool();
			p_Instance.EnableJobs = p_Reader.ReadBool();
			p_Instance.ForcePoseUpdate = p_Reader.ReadBool();
			p_Instance.RunAsHighPriority = p_Reader.ReadBool();
			p_Instance.InterpolatePoses = p_Reader.ReadBool();
			p_Instance.AllowVariableTickLength = p_Reader.ReadBool();
			p_Instance.EnablePackageCache = p_Reader.ReadBool();
			p_Instance.UseHIK = p_Reader.ReadBool();
			p_Instance.UpdateLoddingEnable = p_Reader.ReadBool();
			p_Instance.BlockOnJobs = p_Reader.ReadBool();
			p_Instance.EnableDebugLogFile = p_Reader.ReadBool();
			p_Instance.EnablePoseJobs = p_Reader.ReadBool();
			p_Instance.UsePA = p_Reader.ReadBool();
		}

	}
}
