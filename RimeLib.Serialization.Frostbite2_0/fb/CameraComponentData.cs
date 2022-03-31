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
	[ContainerType(16, 224)]
	public class CameraComponentData :
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec3 CameraTransitionPos { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float FieldOfView { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float ForceFieldOfView { get; set; }

		[ContainerField(120), JsonProperty(Order = 120)]
		public CtrRef<TargetCameraData> Camera { get; set; } = new();

		[ContainerField(124), JsonProperty(Order = 124)]
		public CtrRef<AlternateCameraViewData> AlternateView { get; set; } = new();

		[ContainerField(128), JsonProperty(Order = 128)]
		public RegularCameraViewData RegularView { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float FreezeHeight { get; set; }

		[ContainerField(180), JsonProperty(Order = 180)]
		public StanceCameraData StanceData { get; set; } = new();

		[ContainerField(188), JsonProperty(Order = 188)]
		public CtrRef<CameraComponentSoundData> CameraSoundData { get; set; } = new();

		[ContainerField(192), JsonProperty(Order = 192)]
		public SoldierAnimatedCameraData SoldierAnimatedCamera { get; set; } = new();

		[ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		public float CameraTransitionTime { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		public uint MeshParentComponentNumber { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public bool EnableCameraMesh { get; set; }

		[ContainerField(209), LayoutImmutable, Blittable, JsonProperty(Order = 209)]
		public bool ReceiveImpulsesAsThirdPerson { get; set; }

		[ContainerField(210), LayoutImmutable, Blittable, JsonProperty(Order = 210)]
		public bool UseCameraTransition { get; set; }

		[ContainerField(211), LayoutImmutable, Blittable, JsonProperty(Order = 211)]
		public bool AlternateViewEnabled { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		public bool IsFirstPerson { get; set; }

		[ContainerField(213), LayoutImmutable, Blittable, JsonProperty(Order = 213)]
		public bool IgnoreOwnerOrientation { get; set; }

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
