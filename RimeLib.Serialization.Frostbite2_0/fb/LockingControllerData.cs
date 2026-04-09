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
	[ContainerType(4, 64)]
	public partial class LockingControllerData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private List<ZoomLevelLockData> _ZoomLevelLock = new();

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _LockTime;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _ReleaseTime;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _ReleaseOnNewTargetTime;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _SampleRate;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _HoldStillThreshold;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _RayLength;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _AcceptanceAngle;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _MinimumLockTime;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _Sensitivity;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _AngleConstant;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _DistanceConstant;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private bool _LockOnWorldSpacePos;

		[ObservableProperty]
		[property: ContainerField(57), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
		private bool _LockOnVisibleTargetsOnly;

		[ObservableProperty]
		[property: ContainerField(58), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
		private bool _PositionOnly;

		[ObservableProperty]
		[property: ContainerField(59), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
		private bool _LockOnEmptyVehicles;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private bool _IgnoreHeigthLockDistance;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			(RimeWriter Writer, uint ArrayIndex) s_ZoomLevelLock = p_EbxWriter.GetArrayWriter(ZoomLevelLock.GetType(), ZoomLevelLock.Count);
			p_Writer.Write(s_ZoomLevelLock.ArrayIndex);
			foreach (var s_Entry in ZoomLevelLock)
			{
				s_Entry.Serialize(s_ZoomLevelLock.Writer, p_EbxWriter);
			}
			p_Writer.Write(LockTime);
			p_Writer.Write(ReleaseTime);
			p_Writer.Write(ReleaseOnNewTargetTime);
			p_Writer.Write(SampleRate);
			p_Writer.Write(HoldStillThreshold);
			p_Writer.Write(RayLength);
			p_Writer.Write(AcceptanceAngle);
			p_Writer.Write(MinimumLockTime);
			p_Writer.Write(Sensitivity);
			p_Writer.Write(AngleConstant);
			p_Writer.Write(DistanceConstant);
			p_Writer.Write(LockOnWorldSpacePos);
			p_Writer.Write(LockOnVisibleTargetsOnly);
			p_Writer.Write(PositionOnly);
			p_Writer.Write(LockOnEmptyVehicles);
			p_Writer.Write(IgnoreHeigthLockDistance);
			p_Writer.WriteNullBytes(3);
		}
	}
}
