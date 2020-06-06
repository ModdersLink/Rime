///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class CameraComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CameraTransitionPos { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float FieldOfView { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float ForceFieldOfView { get; set; } // 0x74 (116)
		
		[ContainerField(120)]
		public CtrRef<TargetCameraData> Camera { get; set; } = new CtrRef<TargetCameraData>(); // 0x78 (120)
		
		[ContainerField(124)]
		public CtrRef<AlternateCameraViewData> AlternateView { get; set; } = new CtrRef<AlternateCameraViewData>(); // 0x7C (124)
		
		[ContainerField(128)]
		public RegularCameraViewData RegularView { get; set; } = new RegularCameraViewData(); // 0x80 (128)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float FreezeHeight { get; set; } // 0xB0 (176)
		
		[ContainerField(180)]
		public StanceCameraData StanceData { get; set; } = new StanceCameraData(); // 0xB4 (180)
		
		[ContainerField(188)]
		public CtrRef<CameraComponentSoundData> CameraSoundData { get; set; } = new CtrRef<CameraComponentSoundData>(); // 0xBC (188)
		
		[ContainerField(192)]
		public SoldierAnimatedCameraData SoldierAnimatedCamera { get; set; } = new SoldierAnimatedCameraData(); // 0xC0 (192)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public float CameraTransitionTime { get; set; } // 0xC8 (200)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public uint MeshParentComponentNumber { get; set; } // 0xCC (204)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public bool EnableCameraMesh { get; set; } // 0xD0 (208)
		
		[ContainerField(209), LayoutImmutable, Blittable]
		public bool ReceiveImpulsesAsThirdPerson { get; set; } // 0xD1 (209)
		
		[ContainerField(210), LayoutImmutable, Blittable]
		public bool UseCameraTransition { get; set; } // 0xD2 (210)
		
		[ContainerField(211), LayoutImmutable, Blittable]
		public bool AlternateViewEnabled { get; set; } // 0xD3 (211)
		
		[ContainerField(212), LayoutImmutable, Blittable]
		public bool IsFirstPerson { get; set; } // 0xD4 (212)
		
		[ContainerField(213), LayoutImmutable, Blittable]
		public bool IgnoreOwnerOrientation { get; set; } // 0xD5 (213)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3159565823:
					CameraTransitionPos = (Vec3) p_Value;
					break;

				case 2227716035:
					FieldOfView = (float) p_Value;
					break;

				case 2191221214:
					ForceFieldOfView = (float) p_Value;
					break;

				case 2716359356:
					Camera = (CtrRef<TargetCameraData>) p_Value;
					break;

				case 906681240:
					AlternateView = (CtrRef<AlternateCameraViewData>) p_Value;
					break;

				case 653142290:
					RegularView = (RegularCameraViewData) p_Value;
					break;

				case 3432929233:
					FreezeHeight = (float) p_Value;
					break;

				case 2329728379:
					StanceData = (StanceCameraData) p_Value;
					break;

				case 3785254511:
					CameraSoundData = (CtrRef<CameraComponentSoundData>) p_Value;
					break;

				case 1964549481:
					SoldierAnimatedCamera = (SoldierAnimatedCameraData) p_Value;
					break;

				case 1186593510:
					CameraTransitionTime = (float) p_Value;
					break;

				case 1500139014:
					MeshParentComponentNumber = (uint) p_Value;
					break;

				case 3311112814:
					EnableCameraMesh = (bool) p_Value;
					break;

				case 3555599490:
					ReceiveImpulsesAsThirdPerson = (bool) p_Value;
					break;

				case 2345252784:
					UseCameraTransition = (bool) p_Value;
					break;

				case 541013693:
					AlternateViewEnabled = (bool) p_Value;
					break;

				case 824639024:
					IsFirstPerson = (bool) p_Value;
					break;

				case 1298324842:
					IgnoreOwnerOrientation = (bool) p_Value;
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
				case 3159565823:
					return CameraTransitionPos;

				case 2227716035:
					return FieldOfView;

				case 2191221214:
					return ForceFieldOfView;

				case 2716359356:
					return Camera;

				case 906681240:
					return AlternateView;

				case 653142290:
					return RegularView;

				case 3432929233:
					return FreezeHeight;

				case 2329728379:
					return StanceData;

				case 3785254511:
					return CameraSoundData;

				case 1964549481:
					return SoldierAnimatedCamera;

				case 1186593510:
					return CameraTransitionTime;

				case 1500139014:
					return MeshParentComponentNumber;

				case 3311112814:
					return EnableCameraMesh;

				case 3555599490:
					return ReceiveImpulsesAsThirdPerson;

				case 2345252784:
					return UseCameraTransition;

				case 541013693:
					return AlternateViewEnabled;

				case 824639024:
					return IsFirstPerson;

				case 1298324842:
					return IgnoreOwnerOrientation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3159565823:
					return typeof(CameraComponentData).GetProperty(nameof(CameraTransitionPos));

				case 2227716035:
					return typeof(CameraComponentData).GetProperty(nameof(FieldOfView));

				case 2191221214:
					return typeof(CameraComponentData).GetProperty(nameof(ForceFieldOfView));

				case 2716359356:
					return typeof(CameraComponentData).GetProperty(nameof(Camera));

				case 906681240:
					return typeof(CameraComponentData).GetProperty(nameof(AlternateView));

				case 653142290:
					return typeof(CameraComponentData).GetProperty(nameof(RegularView));

				case 3432929233:
					return typeof(CameraComponentData).GetProperty(nameof(FreezeHeight));

				case 2329728379:
					return typeof(CameraComponentData).GetProperty(nameof(StanceData));

				case 3785254511:
					return typeof(CameraComponentData).GetProperty(nameof(CameraSoundData));

				case 1964549481:
					return typeof(CameraComponentData).GetProperty(nameof(SoldierAnimatedCamera));

				case 1186593510:
					return typeof(CameraComponentData).GetProperty(nameof(CameraTransitionTime));

				case 1500139014:
					return typeof(CameraComponentData).GetProperty(nameof(MeshParentComponentNumber));

				case 3311112814:
					return typeof(CameraComponentData).GetProperty(nameof(EnableCameraMesh));

				case 3555599490:
					return typeof(CameraComponentData).GetProperty(nameof(ReceiveImpulsesAsThirdPerson));

				case 2345252784:
					return typeof(CameraComponentData).GetProperty(nameof(UseCameraTransition));

				case 541013693:
					return typeof(CameraComponentData).GetProperty(nameof(AlternateViewEnabled));

				case 824639024:
					return typeof(CameraComponentData).GetProperty(nameof(IsFirstPerson));

				case 1298324842:
					return typeof(CameraComponentData).GetProperty(nameof(IgnoreOwnerOrientation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
