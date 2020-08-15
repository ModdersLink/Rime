///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4)]
	public class AntSettings : 
		DataContainer
	{
		protected float m_DetailedCollisionSpeedLimit = new float();
		[ContainerField(8), LayoutImmutable, Blittable, ContainerFieldNameHash(2710356985)]
		public float DetailedCollisionSpeedLimit { get { return m_DetailedCollisionSpeedLimit; } set { if (OnPropertyChanging("AntSettings." + nameof(DetailedCollisionSpeedLimit), this, m_DetailedCollisionSpeedLimit, value)) m_DetailedCollisionSpeedLimit = value; } } // 0x8 (8)
		
		protected float m_LeanSignalScale = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(3002337221)]
		public float LeanSignalScale { get { return m_LeanSignalScale; } set { if (OnPropertyChanging("AntSettings." + nameof(LeanSignalScale), this, m_LeanSignalScale, value)) m_LeanSignalScale = value; } } // 0xC (12)
		
		protected float m_LeanSignalClamp = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(3020854094)]
		public float LeanSignalClamp { get { return m_LeanSignalClamp; } set { if (OnPropertyChanging("AntSettings." + nameof(LeanSignalClamp), this, m_LeanSignalClamp, value)) m_LeanSignalClamp = value; } } // 0x10 (16)
		
		protected int m_MaxInterpolationSlots = new int();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(2610767372)]
		public int MaxInterpolationSlots { get { return m_MaxInterpolationSlots; } set { if (OnPropertyChanging("AntSettings." + nameof(MaxInterpolationSlots), this, m_MaxInterpolationSlots, value)) m_MaxInterpolationSlots = value; } } // 0x14 (20)
		
		protected int m_MaxSingleBoneInterpolationSlots = new int();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(3129484400)]
		public int MaxSingleBoneInterpolationSlots { get { return m_MaxSingleBoneInterpolationSlots; } set { if (OnPropertyChanging("AntSettings." + nameof(MaxSingleBoneInterpolationSlots), this, m_MaxSingleBoneInterpolationSlots, value)) m_MaxSingleBoneInterpolationSlots = value; } } // 0x18 (24)
		
		protected float m_ReducedInterpolationDistance = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(1694794600)]
		public float ReducedInterpolationDistance { get { return m_ReducedInterpolationDistance; } set { if (OnPropertyChanging("AntSettings." + nameof(ReducedInterpolationDistance), this, m_ReducedInterpolationDistance, value)) m_ReducedInterpolationDistance = value; } } // 0x1C (28)
		
		protected float m_TrajectoryInterpolationDistance = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(3252148855)]
		public float TrajectoryInterpolationDistance { get { return m_TrajectoryInterpolationDistance; } set { if (OnPropertyChanging("AntSettings." + nameof(TrajectoryInterpolationDistance), this, m_TrajectoryInterpolationDistance, value)) m_TrajectoryInterpolationDistance = value; } } // 0x20 (32)
		
		protected float m_ForceLodDistance = new float();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(239754652)]
		public float ForceLodDistance { get { return m_ForceLodDistance; } set { if (OnPropertyChanging("AntSettings." + nameof(ForceLodDistance), this, m_ForceLodDistance, value)) m_ForceLodDistance = value; } } // 0x24 (36)
		
		protected int m_MaxAnimatablesPerPoseJob = new int();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(181255807)]
		public int MaxAnimatablesPerPoseJob { get { return m_MaxAnimatablesPerPoseJob; } set { if (OnPropertyChanging("AntSettings." + nameof(MaxAnimatablesPerPoseJob), this, m_MaxAnimatablesPerPoseJob, value)) m_MaxAnimatablesPerPoseJob = value; } } // 0x28 (40)
		
		protected float m_CheckGiantSoldiers = new float();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(3300928495)]
		public float CheckGiantSoldiers { get { return m_CheckGiantSoldiers; } set { if (OnPropertyChanging("AntSettings." + nameof(CheckGiantSoldiers), this, m_CheckGiantSoldiers, value)) m_CheckGiantSoldiers = value; } } // 0x2C (44)
		
		protected bool m_ClientEmulatesServer = new bool();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(1976305899)]
		public bool ClientEmulatesServer { get { return m_ClientEmulatesServer; } set { if (OnPropertyChanging("AntSettings." + nameof(ClientEmulatesServer), this, m_ClientEmulatesServer, value)) m_ClientEmulatesServer = value; } } // 0x30 (48)
		
		protected bool m_UseCameraFov = new bool();
		[ContainerField(49), LayoutImmutable, Blittable, ContainerFieldNameHash(431104480)]
		public bool UseCameraFov { get { return m_UseCameraFov; } set { if (OnPropertyChanging("AntSettings." + nameof(UseCameraFov), this, m_UseCameraFov, value)) m_UseCameraFov = value; } } // 0x31 (49)
		
		protected bool m_UpdateEnable = new bool();
		[ContainerField(50), LayoutImmutable, Blittable, ContainerFieldNameHash(3724816309)]
		public bool UpdateEnable { get { return m_UpdateEnable; } set { if (OnPropertyChanging("AntSettings." + nameof(UpdateEnable), this, m_UpdateEnable, value)) m_UpdateEnable = value; } } // 0x32 (50)
		
		protected bool m_EnablePA = new bool();
		[ContainerField(51), LayoutImmutable, Blittable, ContainerFieldNameHash(87860981)]
		public bool EnablePA { get { return m_EnablePA; } set { if (OnPropertyChanging("AntSettings." + nameof(EnablePA), this, m_EnablePA, value)) m_EnablePA = value; } } // 0x33 (51)
		
		protected bool m_UseWeaponFov = new bool();
		[ContainerField(52), LayoutImmutable, Blittable, ContainerFieldNameHash(3665266683)]
		public bool UseWeaponFov { get { return m_UseWeaponFov; } set { if (OnPropertyChanging("AntSettings." + nameof(UseWeaponFov), this, m_UseWeaponFov, value)) m_UseWeaponFov = value; } } // 0x34 (52)
		
		protected bool m_DisableAnimManagerSceneOps = new bool();
		[ContainerField(53), LayoutImmutable, Blittable, ContainerFieldNameHash(1610827931)]
		public bool DisableAnimManagerSceneOps { get { return m_DisableAnimManagerSceneOps; } set { if (OnPropertyChanging("AntSettings." + nameof(DisableAnimManagerSceneOps), this, m_DisableAnimManagerSceneOps, value)) m_DisableAnimManagerSceneOps = value; } } // 0x35 (53)
		
		protected bool m_DisableAILodFeature = new bool();
		[ContainerField(54), LayoutImmutable, Blittable, ContainerFieldNameHash(3543960618)]
		public bool DisableAILodFeature { get { return m_DisableAILodFeature; } set { if (OnPropertyChanging("AntSettings." + nameof(DisableAILodFeature), this, m_DisableAILodFeature, value)) m_DisableAILodFeature = value; } } // 0x36 (54)
		
		protected bool m_DisableModelAnimationCulling = new bool();
		[ContainerField(55), LayoutImmutable, Blittable, ContainerFieldNameHash(1067364094)]
		public bool DisableModelAnimationCulling { get { return m_DisableModelAnimationCulling; } set { if (OnPropertyChanging("AntSettings." + nameof(DisableModelAnimationCulling), this, m_DisableModelAnimationCulling, value)) m_DisableModelAnimationCulling = value; } } // 0x37 (55)
		
		protected bool m_EnableJobs = new bool();
		[ContainerField(56), LayoutImmutable, Blittable, ContainerFieldNameHash(1190923856)]
		public bool EnableJobs { get { return m_EnableJobs; } set { if (OnPropertyChanging("AntSettings." + nameof(EnableJobs), this, m_EnableJobs, value)) m_EnableJobs = value; } } // 0x38 (56)
		
		protected bool m_ForcePoseUpdate = new bool();
		[ContainerField(57), LayoutImmutable, Blittable, ContainerFieldNameHash(297356768)]
		public bool ForcePoseUpdate { get { return m_ForcePoseUpdate; } set { if (OnPropertyChanging("AntSettings." + nameof(ForcePoseUpdate), this, m_ForcePoseUpdate, value)) m_ForcePoseUpdate = value; } } // 0x39 (57)
		
		protected bool m_RunAsHighPriority = new bool();
		[ContainerField(58), LayoutImmutable, Blittable, ContainerFieldNameHash(1190549698)]
		public bool RunAsHighPriority { get { return m_RunAsHighPriority; } set { if (OnPropertyChanging("AntSettings." + nameof(RunAsHighPriority), this, m_RunAsHighPriority, value)) m_RunAsHighPriority = value; } } // 0x3A (58)
		
		protected bool m_InterpolatePoses = new bool();
		[ContainerField(59), LayoutImmutable, Blittable, ContainerFieldNameHash(3613032856)]
		public bool InterpolatePoses { get { return m_InterpolatePoses; } set { if (OnPropertyChanging("AntSettings." + nameof(InterpolatePoses), this, m_InterpolatePoses, value)) m_InterpolatePoses = value; } } // 0x3B (59)
		
		protected bool m_AllowVariableTickLength = new bool();
		[ContainerField(60), LayoutImmutable, Blittable, ContainerFieldNameHash(3088138035)]
		public bool AllowVariableTickLength { get { return m_AllowVariableTickLength; } set { if (OnPropertyChanging("AntSettings." + nameof(AllowVariableTickLength), this, m_AllowVariableTickLength, value)) m_AllowVariableTickLength = value; } } // 0x3C (60)
		
		protected bool m_EnablePackageCache = new bool();
		[ContainerField(61), LayoutImmutable, Blittable, ContainerFieldNameHash(663355506)]
		public bool EnablePackageCache { get { return m_EnablePackageCache; } set { if (OnPropertyChanging("AntSettings." + nameof(EnablePackageCache), this, m_EnablePackageCache, value)) m_EnablePackageCache = value; } } // 0x3D (61)
		
		protected bool m_UseHIK = new bool();
		[ContainerField(62), LayoutImmutable, Blittable, ContainerFieldNameHash(2934539820)]
		public bool UseHIK { get { return m_UseHIK; } set { if (OnPropertyChanging("AntSettings." + nameof(UseHIK), this, m_UseHIK, value)) m_UseHIK = value; } } // 0x3E (62)
		
		protected bool m_UpdateLoddingEnable = new bool();
		[ContainerField(63), LayoutImmutable, Blittable, ContainerFieldNameHash(40520150)]
		public bool UpdateLoddingEnable { get { return m_UpdateLoddingEnable; } set { if (OnPropertyChanging("AntSettings." + nameof(UpdateLoddingEnable), this, m_UpdateLoddingEnable, value)) m_UpdateLoddingEnable = value; } } // 0x3F (63)
		
		protected bool m_BlockOnJobs = new bool();
		[ContainerField(64), LayoutImmutable, Blittable, ContainerFieldNameHash(2913790905)]
		public bool BlockOnJobs { get { return m_BlockOnJobs; } set { if (OnPropertyChanging("AntSettings." + nameof(BlockOnJobs), this, m_BlockOnJobs, value)) m_BlockOnJobs = value; } } // 0x40 (64)
		
		protected bool m_EnableDebugLogFile = new bool();
		[ContainerField(65), LayoutImmutable, Blittable, ContainerFieldNameHash(1766045655)]
		public bool EnableDebugLogFile { get { return m_EnableDebugLogFile; } set { if (OnPropertyChanging("AntSettings." + nameof(EnableDebugLogFile), this, m_EnableDebugLogFile, value)) m_EnableDebugLogFile = value; } } // 0x41 (65)
		
		protected bool m_EnablePoseJobs = new bool();
		[ContainerField(66), LayoutImmutable, Blittable, ContainerFieldNameHash(1005957081)]
		public bool EnablePoseJobs { get { return m_EnablePoseJobs; } set { if (OnPropertyChanging("AntSettings." + nameof(EnablePoseJobs), this, m_EnablePoseJobs, value)) m_EnablePoseJobs = value; } } // 0x42 (66)
		
		protected bool m_UsePA = new bool();
		[ContainerField(67), LayoutImmutable, Blittable, ContainerFieldNameHash(219076247)]
		public bool UsePA { get { return m_UsePA; } set { if (OnPropertyChanging("AntSettings." + nameof(UsePA), this, m_UsePA, value)) m_UsePA = value; } } // 0x43 (67)
		
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
