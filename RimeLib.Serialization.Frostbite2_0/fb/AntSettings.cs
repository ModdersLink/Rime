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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 68)]
	public partial class AntSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _DetailedCollisionSpeedLimit;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _LeanSignalScale;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _LeanSignalClamp;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private int _MaxInterpolationSlots;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private int _MaxSingleBoneInterpolationSlots;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _ReducedInterpolationDistance;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _TrajectoryInterpolationDistance;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _ForceLodDistance;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private int _MaxAnimatablesPerPoseJob;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _CheckGiantSoldiers;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private bool _ClientEmulatesServer;

		[ObservableProperty]
		[property: ContainerField(49), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
		private bool _UseCameraFov;

		[ObservableProperty]
		[property: ContainerField(50), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
		private bool _UpdateEnable;

		[ObservableProperty]
		[property: ContainerField(51), LayoutImmutable, Blittable, JsonProperty(Order = 51)]
		private bool _EnablePA;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private bool _UseWeaponFov;

		[ObservableProperty]
		[property: ContainerField(53), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
		private bool _DisableAnimManagerSceneOps;

		[ObservableProperty]
		[property: ContainerField(54), LayoutImmutable, Blittable, JsonProperty(Order = 54)]
		private bool _DisableAILodFeature;

		[ObservableProperty]
		[property: ContainerField(55), LayoutImmutable, Blittable, JsonProperty(Order = 55)]
		private bool _DisableModelAnimationCulling;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private bool _EnableJobs;

		[ObservableProperty]
		[property: ContainerField(57), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
		private bool _ForcePoseUpdate;

		[ObservableProperty]
		[property: ContainerField(58), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
		private bool _RunAsHighPriority;

		[ObservableProperty]
		[property: ContainerField(59), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
		private bool _InterpolatePoses;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private bool _AllowVariableTickLength;

		[ObservableProperty]
		[property: ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		private bool _EnablePackageCache;

		[ObservableProperty]
		[property: ContainerField(62), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
		private bool _UseHIK;

		[ObservableProperty]
		[property: ContainerField(63), LayoutImmutable, Blittable, JsonProperty(Order = 63)]
		private bool _UpdateLoddingEnable;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private bool _BlockOnJobs;

		[ObservableProperty]
		[property: ContainerField(65), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
		private bool _EnableDebugLogFile;

		[ObservableProperty]
		[property: ContainerField(66), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
		private bool _EnablePoseJobs;

		[ObservableProperty]
		[property: ContainerField(67), LayoutImmutable, Blittable, JsonProperty(Order = 67)]
		private bool _UsePA;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
