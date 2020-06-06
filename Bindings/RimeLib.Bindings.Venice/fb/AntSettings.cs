///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class AntSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float DetailedCollisionSpeedLimit { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float LeanSignalScale { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float LeanSignalClamp { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public int MaxInterpolationSlots { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int MaxSingleBoneInterpolationSlots { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ReducedInterpolationDistance { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float TrajectoryInterpolationDistance { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float ForceLodDistance { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public int MaxAnimatablesPerPoseJob { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float CheckGiantSoldiers { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public bool ClientEmulatesServer { get; set; } // 0x30 (48)
		
		[ContainerField(49), LayoutImmutable, Blittable]
		public bool UseCameraFov { get; set; } // 0x31 (49)
		
		[ContainerField(50), LayoutImmutable, Blittable]
		public bool UpdateEnable { get; set; } // 0x32 (50)
		
		[ContainerField(51), LayoutImmutable, Blittable]
		public bool EnablePA { get; set; } // 0x33 (51)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public bool UseWeaponFov { get; set; } // 0x34 (52)
		
		[ContainerField(53), LayoutImmutable, Blittable]
		public bool DisableAnimManagerSceneOps { get; set; } // 0x35 (53)
		
		[ContainerField(54), LayoutImmutable, Blittable]
		public bool DisableAILodFeature { get; set; } // 0x36 (54)
		
		[ContainerField(55), LayoutImmutable, Blittable]
		public bool DisableModelAnimationCulling { get; set; } // 0x37 (55)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public bool EnableJobs { get; set; } // 0x38 (56)
		
		[ContainerField(57), LayoutImmutable, Blittable]
		public bool ForcePoseUpdate { get; set; } // 0x39 (57)
		
		[ContainerField(58), LayoutImmutable, Blittable]
		public bool RunAsHighPriority { get; set; } // 0x3A (58)
		
		[ContainerField(59), LayoutImmutable, Blittable]
		public bool InterpolatePoses { get; set; } // 0x3B (59)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public bool AllowVariableTickLength { get; set; } // 0x3C (60)
		
		[ContainerField(61), LayoutImmutable, Blittable]
		public bool EnablePackageCache { get; set; } // 0x3D (61)
		
		[ContainerField(62), LayoutImmutable, Blittable]
		public bool UseHIK { get; set; } // 0x3E (62)
		
		[ContainerField(63), LayoutImmutable, Blittable]
		public bool UpdateLoddingEnable { get; set; } // 0x3F (63)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public bool BlockOnJobs { get; set; } // 0x40 (64)
		
		[ContainerField(65), LayoutImmutable, Blittable]
		public bool EnableDebugLogFile { get; set; } // 0x41 (65)
		
		[ContainerField(66), LayoutImmutable, Blittable]
		public bool EnablePoseJobs { get; set; } // 0x42 (66)
		
		[ContainerField(67), LayoutImmutable, Blittable]
		public bool UsePA { get; set; } // 0x43 (67)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2710356985:
					DetailedCollisionSpeedLimit = (float) p_Value;
					break;

				case 3002337221:
					LeanSignalScale = (float) p_Value;
					break;

				case 3020854094:
					LeanSignalClamp = (float) p_Value;
					break;

				case 2610767372:
					MaxInterpolationSlots = (int) p_Value;
					break;

				case 3129484400:
					MaxSingleBoneInterpolationSlots = (int) p_Value;
					break;

				case 1694794600:
					ReducedInterpolationDistance = (float) p_Value;
					break;

				case 3252148855:
					TrajectoryInterpolationDistance = (float) p_Value;
					break;

				case 239754652:
					ForceLodDistance = (float) p_Value;
					break;

				case 181255807:
					MaxAnimatablesPerPoseJob = (int) p_Value;
					break;

				case 3300928495:
					CheckGiantSoldiers = (float) p_Value;
					break;

				case 1976305899:
					ClientEmulatesServer = (bool) p_Value;
					break;

				case 431104480:
					UseCameraFov = (bool) p_Value;
					break;

				case 3724816309:
					UpdateEnable = (bool) p_Value;
					break;

				case 87860981:
					EnablePA = (bool) p_Value;
					break;

				case 3665266683:
					UseWeaponFov = (bool) p_Value;
					break;

				case 1610827931:
					DisableAnimManagerSceneOps = (bool) p_Value;
					break;

				case 3543960618:
					DisableAILodFeature = (bool) p_Value;
					break;

				case 1067364094:
					DisableModelAnimationCulling = (bool) p_Value;
					break;

				case 1190923856:
					EnableJobs = (bool) p_Value;
					break;

				case 297356768:
					ForcePoseUpdate = (bool) p_Value;
					break;

				case 1190549698:
					RunAsHighPriority = (bool) p_Value;
					break;

				case 3613032856:
					InterpolatePoses = (bool) p_Value;
					break;

				case 3088138035:
					AllowVariableTickLength = (bool) p_Value;
					break;

				case 663355506:
					EnablePackageCache = (bool) p_Value;
					break;

				case 2934539820:
					UseHIK = (bool) p_Value;
					break;

				case 40520150:
					UpdateLoddingEnable = (bool) p_Value;
					break;

				case 2913790905:
					BlockOnJobs = (bool) p_Value;
					break;

				case 1766045655:
					EnableDebugLogFile = (bool) p_Value;
					break;

				case 1005957081:
					EnablePoseJobs = (bool) p_Value;
					break;

				case 219076247:
					UsePA = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2710356985:
					return DetailedCollisionSpeedLimit;

				case 3002337221:
					return LeanSignalScale;

				case 3020854094:
					return LeanSignalClamp;

				case 2610767372:
					return MaxInterpolationSlots;

				case 3129484400:
					return MaxSingleBoneInterpolationSlots;

				case 1694794600:
					return ReducedInterpolationDistance;

				case 3252148855:
					return TrajectoryInterpolationDistance;

				case 239754652:
					return ForceLodDistance;

				case 181255807:
					return MaxAnimatablesPerPoseJob;

				case 3300928495:
					return CheckGiantSoldiers;

				case 1976305899:
					return ClientEmulatesServer;

				case 431104480:
					return UseCameraFov;

				case 3724816309:
					return UpdateEnable;

				case 87860981:
					return EnablePA;

				case 3665266683:
					return UseWeaponFov;

				case 1610827931:
					return DisableAnimManagerSceneOps;

				case 3543960618:
					return DisableAILodFeature;

				case 1067364094:
					return DisableModelAnimationCulling;

				case 1190923856:
					return EnableJobs;

				case 297356768:
					return ForcePoseUpdate;

				case 1190549698:
					return RunAsHighPriority;

				case 3613032856:
					return InterpolatePoses;

				case 3088138035:
					return AllowVariableTickLength;

				case 663355506:
					return EnablePackageCache;

				case 2934539820:
					return UseHIK;

				case 40520150:
					return UpdateLoddingEnable;

				case 2913790905:
					return BlockOnJobs;

				case 1766045655:
					return EnableDebugLogFile;

				case 1005957081:
					return EnablePoseJobs;

				case 219076247:
					return UsePA;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2710356985:
					return typeof(AntSettings).GetProperty(nameof(DetailedCollisionSpeedLimit));

				case 3002337221:
					return typeof(AntSettings).GetProperty(nameof(LeanSignalScale));

				case 3020854094:
					return typeof(AntSettings).GetProperty(nameof(LeanSignalClamp));

				case 2610767372:
					return typeof(AntSettings).GetProperty(nameof(MaxInterpolationSlots));

				case 3129484400:
					return typeof(AntSettings).GetProperty(nameof(MaxSingleBoneInterpolationSlots));

				case 1694794600:
					return typeof(AntSettings).GetProperty(nameof(ReducedInterpolationDistance));

				case 3252148855:
					return typeof(AntSettings).GetProperty(nameof(TrajectoryInterpolationDistance));

				case 239754652:
					return typeof(AntSettings).GetProperty(nameof(ForceLodDistance));

				case 181255807:
					return typeof(AntSettings).GetProperty(nameof(MaxAnimatablesPerPoseJob));

				case 3300928495:
					return typeof(AntSettings).GetProperty(nameof(CheckGiantSoldiers));

				case 1976305899:
					return typeof(AntSettings).GetProperty(nameof(ClientEmulatesServer));

				case 431104480:
					return typeof(AntSettings).GetProperty(nameof(UseCameraFov));

				case 3724816309:
					return typeof(AntSettings).GetProperty(nameof(UpdateEnable));

				case 87860981:
					return typeof(AntSettings).GetProperty(nameof(EnablePA));

				case 3665266683:
					return typeof(AntSettings).GetProperty(nameof(UseWeaponFov));

				case 1610827931:
					return typeof(AntSettings).GetProperty(nameof(DisableAnimManagerSceneOps));

				case 3543960618:
					return typeof(AntSettings).GetProperty(nameof(DisableAILodFeature));

				case 1067364094:
					return typeof(AntSettings).GetProperty(nameof(DisableModelAnimationCulling));

				case 1190923856:
					return typeof(AntSettings).GetProperty(nameof(EnableJobs));

				case 297356768:
					return typeof(AntSettings).GetProperty(nameof(ForcePoseUpdate));

				case 1190549698:
					return typeof(AntSettings).GetProperty(nameof(RunAsHighPriority));

				case 3613032856:
					return typeof(AntSettings).GetProperty(nameof(InterpolatePoses));

				case 3088138035:
					return typeof(AntSettings).GetProperty(nameof(AllowVariableTickLength));

				case 663355506:
					return typeof(AntSettings).GetProperty(nameof(EnablePackageCache));

				case 2934539820:
					return typeof(AntSettings).GetProperty(nameof(UseHIK));

				case 40520150:
					return typeof(AntSettings).GetProperty(nameof(UpdateLoddingEnable));

				case 2913790905:
					return typeof(AntSettings).GetProperty(nameof(BlockOnJobs));

				case 1766045655:
					return typeof(AntSettings).GetProperty(nameof(EnableDebugLogFile));

				case 1005957081:
					return typeof(AntSettings).GetProperty(nameof(EnablePoseJobs));

				case 219076247:
					return typeof(AntSettings).GetProperty(nameof(UsePA));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
