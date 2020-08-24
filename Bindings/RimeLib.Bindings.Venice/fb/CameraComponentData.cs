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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class CameraComponentData : 
		ComponentData
	{
		protected Vec3 m_CameraTransitionPos = new Vec3();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(3159565823)]
		public Vec3 CameraTransitionPos { get { return m_CameraTransitionPos; } set { if (OnPropertyChanging("CameraComponentData." + nameof(CameraTransitionPos), this, m_CameraTransitionPos, value)) m_CameraTransitionPos = value; } } // 0x60 (96)
		
		protected float m_FieldOfView = new float();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2227716035)]
		public float FieldOfView { get { return m_FieldOfView; } set { if (OnPropertyChanging("CameraComponentData." + nameof(FieldOfView), this, m_FieldOfView, value)) m_FieldOfView = value; } } // 0x70 (112)
		
		protected float m_ForceFieldOfView = new float();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2191221214)]
		public float ForceFieldOfView { get { return m_ForceFieldOfView; } set { if (OnPropertyChanging("CameraComponentData." + nameof(ForceFieldOfView), this, m_ForceFieldOfView, value)) m_ForceFieldOfView = value; } } // 0x74 (116)
		
		protected CtrRef<TargetCameraData> m_Camera = new CtrRef<TargetCameraData>();
		[ContainerField(120), MemberInfoFlag(53), ContainerFieldNameHash(2716359356), ContainerCtrRef]
		public CtrRef<TargetCameraData> Camera { get { return m_Camera; } set { if (OnPropertyChanging("CameraComponentData." + nameof(Camera), this, m_Camera, value)) m_Camera = value; } } // 0x78 (120)
		
		protected CtrRef<AlternateCameraViewData> m_AlternateView = new CtrRef<AlternateCameraViewData>();
		[ContainerField(124), MemberInfoFlag(53), ContainerFieldNameHash(906681240), ContainerCtrRef]
		public CtrRef<AlternateCameraViewData> AlternateView { get { return m_AlternateView; } set { if (OnPropertyChanging("CameraComponentData." + nameof(AlternateView), this, m_AlternateView, value)) m_AlternateView = value; } } // 0x7C (124)
		
		protected RegularCameraViewData m_RegularView = new RegularCameraViewData();
		[ContainerField(128), MemberInfoFlag(41), ContainerFieldNameHash(653142290)]
		public RegularCameraViewData RegularView { get { return m_RegularView; } set { if (OnPropertyChanging("CameraComponentData." + nameof(RegularView), this, m_RegularView, value)) m_RegularView = value; } } // 0x80 (128)
		
		protected float m_FreezeHeight = new float();
		[ContainerField(176), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3432929233)]
		public float FreezeHeight { get { return m_FreezeHeight; } set { if (OnPropertyChanging("CameraComponentData." + nameof(FreezeHeight), this, m_FreezeHeight, value)) m_FreezeHeight = value; } } // 0xB0 (176)
		
		protected StanceCameraData m_StanceData = new StanceCameraData();
		[ContainerField(180), MemberInfoFlag(41), ContainerFieldNameHash(2329728379)]
		public StanceCameraData StanceData { get { return m_StanceData; } set { if (OnPropertyChanging("CameraComponentData." + nameof(StanceData), this, m_StanceData, value)) m_StanceData = value; } } // 0xB4 (180)
		
		protected CtrRef<CameraComponentSoundData> m_CameraSoundData = new CtrRef<CameraComponentSoundData>();
		[ContainerField(188), MemberInfoFlag(53), ContainerFieldNameHash(3785254511), ContainerCtrRef]
		public CtrRef<CameraComponentSoundData> CameraSoundData { get { return m_CameraSoundData; } set { if (OnPropertyChanging("CameraComponentData." + nameof(CameraSoundData), this, m_CameraSoundData, value)) m_CameraSoundData = value; } } // 0xBC (188)
		
		protected SoldierAnimatedCameraData m_SoldierAnimatedCamera = new SoldierAnimatedCameraData();
		[ContainerField(192), MemberInfoFlag(41), ContainerFieldNameHash(1964549481)]
		public SoldierAnimatedCameraData SoldierAnimatedCamera { get { return m_SoldierAnimatedCamera; } set { if (OnPropertyChanging("CameraComponentData." + nameof(SoldierAnimatedCamera), this, m_SoldierAnimatedCamera, value)) m_SoldierAnimatedCamera = value; } } // 0xC0 (192)
		
		protected float m_CameraTransitionTime = new float();
		[ContainerField(200), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1186593510)]
		public float CameraTransitionTime { get { return m_CameraTransitionTime; } set { if (OnPropertyChanging("CameraComponentData." + nameof(CameraTransitionTime), this, m_CameraTransitionTime, value)) m_CameraTransitionTime = value; } } // 0xC8 (200)
		
		protected uint m_MeshParentComponentNumber = new uint();
		[ContainerField(204), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1500139014)]
		public uint MeshParentComponentNumber { get { return m_MeshParentComponentNumber; } set { if (OnPropertyChanging("CameraComponentData." + nameof(MeshParentComponentNumber), this, m_MeshParentComponentNumber, value)) m_MeshParentComponentNumber = value; } } // 0xCC (204)
		
		protected bool m_EnableCameraMesh = new bool();
		[ContainerField(208), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3311112814)]
		public bool EnableCameraMesh { get { return m_EnableCameraMesh; } set { if (OnPropertyChanging("CameraComponentData." + nameof(EnableCameraMesh), this, m_EnableCameraMesh, value)) m_EnableCameraMesh = value; } } // 0xD0 (208)
		
		protected bool m_ReceiveImpulsesAsThirdPerson = new bool();
		[ContainerField(209), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3555599490)]
		public bool ReceiveImpulsesAsThirdPerson { get { return m_ReceiveImpulsesAsThirdPerson; } set { if (OnPropertyChanging("CameraComponentData." + nameof(ReceiveImpulsesAsThirdPerson), this, m_ReceiveImpulsesAsThirdPerson, value)) m_ReceiveImpulsesAsThirdPerson = value; } } // 0xD1 (209)
		
		protected bool m_UseCameraTransition = new bool();
		[ContainerField(210), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2345252784)]
		public bool UseCameraTransition { get { return m_UseCameraTransition; } set { if (OnPropertyChanging("CameraComponentData." + nameof(UseCameraTransition), this, m_UseCameraTransition, value)) m_UseCameraTransition = value; } } // 0xD2 (210)
		
		protected bool m_AlternateViewEnabled = new bool();
		[ContainerField(211), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(541013693)]
		public bool AlternateViewEnabled { get { return m_AlternateViewEnabled; } set { if (OnPropertyChanging("CameraComponentData." + nameof(AlternateViewEnabled), this, m_AlternateViewEnabled, value)) m_AlternateViewEnabled = value; } } // 0xD3 (211)
		
		protected bool m_IsFirstPerson = new bool();
		[ContainerField(212), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(824639024)]
		public bool IsFirstPerson { get { return m_IsFirstPerson; } set { if (OnPropertyChanging("CameraComponentData." + nameof(IsFirstPerson), this, m_IsFirstPerson, value)) m_IsFirstPerson = value; } } // 0xD4 (212)
		
		protected bool m_IgnoreOwnerOrientation = new bool();
		[ContainerField(213), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1298324842)]
		public bool IgnoreOwnerOrientation { get { return m_IgnoreOwnerOrientation; } set { if (OnPropertyChanging("CameraComponentData." + nameof(IgnoreOwnerOrientation), this, m_IgnoreOwnerOrientation, value)) m_IgnoreOwnerOrientation = value; } } // 0xD5 (213)
		
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
