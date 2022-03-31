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
	[ContainerType(4, 64)]
	public class LockingControllerData :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public List<ZoomLevelLockData> ZoomLevelLock { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float LockTime { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float ReleaseTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float ReleaseOnNewTargetTime { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float SampleRate { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float HoldStillThreshold { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float RayLength { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float AcceptanceAngle { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float MinimumLockTime { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float Sensitivity { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float AngleConstant { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float DistanceConstant { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public bool LockOnWorldSpacePos { get; set; }

		[ContainerField(57), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
		public bool LockOnVisibleTargetsOnly { get; set; }

		[ContainerField(58), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
		public bool PositionOnly { get; set; }

		[ContainerField(59), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
		public bool LockOnEmptyVehicles { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public bool IgnoreHeigthLockDistance { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
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
