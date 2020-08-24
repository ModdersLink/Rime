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
	public class SoldierCameraComponentData : 
		ComponentData
	{
		protected float m_ExplosionImpulseMultiplier = new float();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(513000320)]
		public float ExplosionImpulseMultiplier { get { return m_ExplosionImpulseMultiplier; } set { if (OnPropertyChanging("SoldierCameraComponentData." + nameof(ExplosionImpulseMultiplier), this, m_ExplosionImpulseMultiplier, value)) m_ExplosionImpulseMultiplier = value; } } // 0x60 (96)
		
		protected float m_StrafeTiltStrength = new float();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(12216306)]
		public float StrafeTiltStrength { get { return m_StrafeTiltStrength; } set { if (OnPropertyChanging("SoldierCameraComponentData." + nameof(StrafeTiltStrength), this, m_StrafeTiltStrength, value)) m_StrafeTiltStrength = value; } } // 0x64 (100)
		
		protected float m_PitchTiltStrength = new float();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(398108931)]
		public float PitchTiltStrength { get { return m_PitchTiltStrength; } set { if (OnPropertyChanging("SoldierCameraComponentData." + nameof(PitchTiltStrength), this, m_PitchTiltStrength, value)) m_PitchTiltStrength = value; } } // 0x68 (104)
		
		protected RefArray<TargetCameraData> m_Cameras = new RefArray<TargetCameraData>();
		[ContainerField(108), MemberInfoFlag(65), ContainerFieldNameHash(3740512847), ContainerRefArray]
		public RefArray<TargetCameraData> Cameras { get { return m_Cameras; } set { if (OnPropertyChanging("SoldierCameraComponentData." + nameof(Cameras), this, m_Cameras, value)) m_Cameras = value; } } // 0x6C (108)
		
		protected CameraBinding m_CameraBinding = new CameraBinding();
		[ContainerField(112), MemberInfoFlag(41), ContainerFieldNameHash(656489757)]
		public CameraBinding CameraBinding { get { return m_CameraBinding; } set { if (OnPropertyChanging("SoldierCameraComponentData." + nameof(CameraBinding), this, m_CameraBinding, value)) m_CameraBinding = value; } } // 0x70 (112)
		
		protected float m_ForceFieldOfView = new float();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2191221214)]
		public float ForceFieldOfView { get { return m_ForceFieldOfView; } set { if (OnPropertyChanging("SoldierCameraComponentData." + nameof(ForceFieldOfView), this, m_ForceFieldOfView, value)) m_ForceFieldOfView = value; } } // 0x78 (120)
		
		protected bool m_AuthoritativeEyePosition = new bool();
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2287547522)]
		public bool AuthoritativeEyePosition { get { return m_AuthoritativeEyePosition; } set { if (OnPropertyChanging("SoldierCameraComponentData." + nameof(AuthoritativeEyePosition), this, m_AuthoritativeEyePosition, value)) m_AuthoritativeEyePosition = value; } } // 0x7C (124)
		
		protected bool m_DisableAiming = new bool();
		[ContainerField(125), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1555811028)]
		public bool DisableAiming { get { return m_DisableAiming; } set { if (OnPropertyChanging("SoldierCameraComponentData." + nameof(DisableAiming), this, m_DisableAiming, value)) m_DisableAiming = value; } } // 0x7D (125)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 513000320:
					ExplosionImpulseMultiplier = (float) p_Value;
					break;

				case 12216306:
					StrafeTiltStrength = (float) p_Value;
					break;

				case 398108931:
					PitchTiltStrength = (float) p_Value;
					break;

				case 3740512847:
					Cameras = (RefArray<TargetCameraData>) p_Value;
					break;

				case 656489757:
					CameraBinding = (CameraBinding) p_Value;
					break;

				case 2191221214:
					ForceFieldOfView = (float) p_Value;
					break;

				case 2287547522:
					AuthoritativeEyePosition = (bool) p_Value;
					break;

				case 1555811028:
					DisableAiming = (bool) p_Value;
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
				case 513000320:
					return ExplosionImpulseMultiplier;

				case 12216306:
					return StrafeTiltStrength;

				case 398108931:
					return PitchTiltStrength;

				case 3740512847:
					return Cameras;

				case 656489757:
					return CameraBinding;

				case 2191221214:
					return ForceFieldOfView;

				case 2287547522:
					return AuthoritativeEyePosition;

				case 1555811028:
					return DisableAiming;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 513000320:
					return typeof(SoldierCameraComponentData).GetProperty(nameof(ExplosionImpulseMultiplier));

				case 12216306:
					return typeof(SoldierCameraComponentData).GetProperty(nameof(StrafeTiltStrength));

				case 398108931:
					return typeof(SoldierCameraComponentData).GetProperty(nameof(PitchTiltStrength));

				case 3740512847:
					return typeof(SoldierCameraComponentData).GetProperty(nameof(Cameras));

				case 656489757:
					return typeof(SoldierCameraComponentData).GetProperty(nameof(CameraBinding));

				case 2191221214:
					return typeof(SoldierCameraComponentData).GetProperty(nameof(ForceFieldOfView));

				case 2287547522:
					return typeof(SoldierCameraComponentData).GetProperty(nameof(AuthoritativeEyePosition));

				case 1555811028:
					return typeof(SoldierCameraComponentData).GetProperty(nameof(DisableAiming));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
