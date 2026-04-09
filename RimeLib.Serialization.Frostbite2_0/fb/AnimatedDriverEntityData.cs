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
	[ContainerType(16, 272)]
	public partial class AnimatedDriverEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private LinearTransform _InputTransform = new();

		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private AntRef _VehicleBoost = new();

		[ObservableProperty]
		[property: ContainerField(164), JsonProperty(Order = 164)]
		private AntRef _VehicleSpeed = new();

		[ObservableProperty]
		[property: ContainerField(168), JsonProperty(Order = 168)]
		private AntRef _VehicleMovementState = new();

		[ObservableProperty]
		[property: ContainerField(172), JsonProperty(Order = 172)]
		private AntRef _VehicleClutch = new();

		[ObservableProperty]
		[property: ContainerField(176), JsonProperty(Order = 176)]
		private AntRef _VehicleBrake = new();

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private float _MovementStateStandThreshold;

		[ObservableProperty]
		[property: ContainerField(184), JsonProperty(Order = 184)]
		private NormalizeSettings _Yaw = new();

		[ObservableProperty]
		[property: ContainerField(208), JsonProperty(Order = 208)]
		private NormalizeSettings _Roll = new();

		[ObservableProperty]
		[property: ContainerField(232), JsonProperty(Order = 232)]
		private NormalizeSettings _Pitch = new();

		[ObservableProperty]
		[property: ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		private bool _DelayAnimationWheelTransform;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			InputTransform.Serialize(p_Writer, p_EbxWriter);
			VehicleBoost.Serialize(p_Writer, p_EbxWriter);
			VehicleSpeed.Serialize(p_Writer, p_EbxWriter);
			VehicleMovementState.Serialize(p_Writer, p_EbxWriter);
			VehicleClutch.Serialize(p_Writer, p_EbxWriter);
			VehicleBrake.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MovementStateStandThreshold);
			Yaw.Serialize(p_Writer, p_EbxWriter);
			Roll.Serialize(p_Writer, p_EbxWriter);
			Pitch.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(DelayAnimationWheelTransform);
			p_Writer.WriteNullBytes(15);
		}
	}
}
