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
	[ContainerType(16, 256)]
	public partial class VehicleCameraData :
		TargetCameraData
	{
		[ObservableProperty]
		[property: ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private Vec3 _MoveToPosition = new();

		[ObservableProperty]
		[property: ContainerField(176), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private Vec3 _MoveToPositionSlopeFactor = new();

		[ObservableProperty]
		[property: ContainerField(192), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private Vec3 _TargetOffset = new();

		[ObservableProperty]
		[property: ContainerField(208), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private Vec3 _TargetOffsetSlopeFactor = new();

		[ObservableProperty]
		[property: ContainerField(224), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		private Vec3 _RotationFactor = new();

		[ObservableProperty]
		[property: ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		private float _PositionFactor;

		[ObservableProperty]
		[property: ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		private float _ResetDistance;

		[ObservableProperty]
		[property: ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		private bool _FixedPosition;

		[ObservableProperty]
		[property: ContainerField(249), LayoutImmutable, Blittable, JsonProperty(Order = 249)]
		private bool _FixedAngleZ;

		[ObservableProperty]
		[property: ContainerField(250), LayoutImmutable, Blittable, JsonProperty(Order = 250)]
		private bool _UseTerrainAdjustment;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			MoveToPosition.Serialize(p_Writer, p_EbxWriter);
			MoveToPositionSlopeFactor.Serialize(p_Writer, p_EbxWriter);
			TargetOffset.Serialize(p_Writer, p_EbxWriter);
			TargetOffsetSlopeFactor.Serialize(p_Writer, p_EbxWriter);
			RotationFactor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(PositionFactor);
			p_Writer.Write(ResetDistance);
			p_Writer.Write(FixedPosition);
			p_Writer.Write(FixedAngleZ);
			p_Writer.Write(UseTerrainAdjustment);
			p_Writer.WriteNullBytes(5);
		}
	}
}
