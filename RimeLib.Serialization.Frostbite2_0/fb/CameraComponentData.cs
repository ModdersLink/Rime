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
	[ContainerType(16, 224)]
	public partial class CameraComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec3 _CameraTransitionPos = new();

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _FieldOfView;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _ForceFieldOfView;

		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private CtrRef<TargetCameraData> _Camera = new();

		[ObservableProperty]
		[property: ContainerField(124), JsonProperty(Order = 124)]
		private CtrRef<AlternateCameraViewData> _AlternateView = new();

		[ObservableProperty]
		[property: ContainerField(128), JsonProperty(Order = 128)]
		private RegularCameraViewData _RegularView = new();

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _FreezeHeight;

		[ObservableProperty]
		[property: ContainerField(180), JsonProperty(Order = 180)]
		private StanceCameraData _StanceData = new();

		[ObservableProperty]
		[property: ContainerField(188), JsonProperty(Order = 188)]
		private CtrRef<CameraComponentSoundData> _CameraSoundData = new();

		[ObservableProperty]
		[property: ContainerField(192), JsonProperty(Order = 192)]
		private SoldierAnimatedCameraData _SoldierAnimatedCamera = new();

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private float _CameraTransitionTime;

		[ObservableProperty]
		[property: ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		private uint _MeshParentComponentNumber;

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private bool _EnableCameraMesh;

		[ObservableProperty]
		[property: ContainerField(209), LayoutImmutable, Blittable, JsonProperty(Order = 209)]
		private bool _ReceiveImpulsesAsThirdPerson;

		[ObservableProperty]
		[property: ContainerField(210), LayoutImmutable, Blittable, JsonProperty(Order = 210)]
		private bool _UseCameraTransition;

		[ObservableProperty]
		[property: ContainerField(211), LayoutImmutable, Blittable, JsonProperty(Order = 211)]
		private bool _AlternateViewEnabled;

		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		private bool _IsFirstPerson;

		[ObservableProperty]
		[property: ContainerField(213), LayoutImmutable, Blittable, JsonProperty(Order = 213)]
		private bool _IgnoreOwnerOrientation;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			CameraTransitionPos.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FieldOfView);
			p_Writer.Write(ForceFieldOfView);
			p_Writer.Write(p_EbxWriter.WriteImport(Camera));
			p_Writer.Write(p_EbxWriter.WriteImport(AlternateView));
			RegularView.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FreezeHeight);
			StanceData.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(CameraSoundData));
			SoldierAnimatedCamera.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(CameraTransitionTime);
			p_Writer.Write(MeshParentComponentNumber);
			p_Writer.Write(EnableCameraMesh);
			p_Writer.Write(ReceiveImpulsesAsThirdPerson);
			p_Writer.Write(UseCameraTransition);
			p_Writer.Write(AlternateViewEnabled);
			p_Writer.Write(IsFirstPerson);
			p_Writer.Write(IgnoreOwnerOrientation);
			p_Writer.WriteNullBytes(10);
		}
	}
}
