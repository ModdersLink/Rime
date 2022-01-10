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
	[ContainerType(16, 224)]
	public class CameraComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CameraTransitionPos { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable]
		public float FieldOfView { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float ForceFieldOfView { get; set; }

		[ContainerField(120)]
		public CtrRef<TargetCameraData> Camera { get; set; } = new();

		[ContainerField(124)]
		public CtrRef<AlternateCameraViewData> AlternateView { get; set; } = new();

		[ContainerField(128)]
		public RegularCameraViewData RegularView { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable]
		public float FreezeHeight { get; set; }

		[ContainerField(180)]
		public StanceCameraData StanceData { get; set; } = new();

		[ContainerField(188)]
		public CtrRef<CameraComponentSoundData> CameraSoundData { get; set; } = new();

		[ContainerField(192)]
		public SoldierAnimatedCameraData SoldierAnimatedCamera { get; set; } = new();

		[ContainerField(200), LayoutImmutable, Blittable]
		public float CameraTransitionTime { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public uint MeshParentComponentNumber { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable]
		public bool EnableCameraMesh { get; set; }

		[ContainerField(209), LayoutImmutable, Blittable]
		public bool ReceiveImpulsesAsThirdPerson { get; set; }

		[ContainerField(210), LayoutImmutable, Blittable]
		public bool UseCameraTransition { get; set; }

		[ContainerField(211), LayoutImmutable, Blittable]
		public bool AlternateViewEnabled { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable]
		public bool IsFirstPerson { get; set; }

		[ContainerField(213), LayoutImmutable, Blittable]
		public bool IgnoreOwnerOrientation { get; set; }

		public static void Deserialize(CameraComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.CameraTransitionPos, p_Reader, p_Parser);
			p_Instance.FieldOfView = p_Reader.ReadSingle();
			p_Instance.ForceFieldOfView = p_Reader.ReadSingle();
			p_Instance.Camera.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.AlternateView.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			fb.RegularCameraViewData.Deserialize(p_Instance.RegularView, p_Reader, p_Parser);
			p_Instance.FreezeHeight = p_Reader.ReadSingle();
			fb.StanceCameraData.Deserialize(p_Instance.StanceData, p_Reader, p_Parser);
			p_Instance.CameraSoundData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			fb.SoldierAnimatedCameraData.Deserialize(p_Instance.SoldierAnimatedCamera, p_Reader, p_Parser);
			p_Instance.CameraTransitionTime = p_Reader.ReadSingle();
			p_Instance.MeshParentComponentNumber = p_Reader.ReadUInt32();
			p_Instance.EnableCameraMesh = p_Reader.ReadBool();
			p_Instance.ReceiveImpulsesAsThirdPerson = p_Reader.ReadBool();
			p_Instance.UseCameraTransition = p_Reader.ReadBool();
			p_Instance.AlternateViewEnabled = p_Reader.ReadBool();
			p_Instance.IsFirstPerson = p_Reader.ReadBool();
			p_Instance.IgnoreOwnerOrientation = p_Reader.ReadBool();
			p_Reader.Seek(10, SeekOrigin.Current);
		}

	}
}
