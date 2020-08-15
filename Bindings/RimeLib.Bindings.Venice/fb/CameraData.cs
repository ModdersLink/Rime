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
	[ContainerType(16)]
	public class CameraData : 
		GameObjectData
	{
		protected Vec3 m_OcclusionRayOffset = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2352466319)]
		public Vec3 OcclusionRayOffset { get { return m_OcclusionRayOffset; } set { if (OnPropertyChanging("CameraData." + nameof(OcclusionRayOffset), this, m_OcclusionRayOffset, value)) m_OcclusionRayOffset = value; } } // 0x10 (16)
		
		protected float m_ShakeFactor = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(1800518652)]
		public float ShakeFactor { get { return m_ShakeFactor; } set { if (OnPropertyChanging("CameraData." + nameof(ShakeFactor), this, m_ShakeFactor, value)) m_ShakeFactor = value; } } // 0x20 (32)
		
		protected float m_PreFadeTime = new float();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(3677592337)]
		public float PreFadeTime { get { return m_PreFadeTime; } set { if (OnPropertyChanging("CameraData." + nameof(PreFadeTime), this, m_PreFadeTime, value)) m_PreFadeTime = value; } } // 0x24 (36)
		
		protected float m_FadeTime = new float();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(4001222838)]
		public float FadeTime { get { return m_FadeTime; } set { if (OnPropertyChanging("CameraData." + nameof(FadeTime), this, m_FadeTime, value)) m_FadeTime = value; } } // 0x28 (40)
		
		protected float m_FadeWaitTime = new float();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(3603496477)]
		public float FadeWaitTime { get { return m_FadeWaitTime; } set { if (OnPropertyChanging("CameraData." + nameof(FadeWaitTime), this, m_FadeWaitTime, value)) m_FadeWaitTime = value; } } // 0x2C (44)
		
		protected float m_SoundListenerRadius = new float();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(3076143232)]
		public float SoundListenerRadius { get { return m_SoundListenerRadius; } set { if (OnPropertyChanging("CameraData." + nameof(SoundListenerRadius), this, m_SoundListenerRadius, value)) m_SoundListenerRadius = value; } } // 0x30 (48)
		
		protected CtrRef<ViewFxData> m_ViewFx = new CtrRef<ViewFxData>();
		[ContainerField(52), ContainerFieldNameHash(3151571446)]
		public CtrRef<ViewFxData> ViewFx { get { return m_ViewFx; } set { if (OnPropertyChanging("CameraData." + nameof(ViewFx), this, m_ViewFx, value)) m_ViewFx = value; } } // 0x34 (52)
		
		protected float m_NearPlane = new float();
		[ContainerField(56), LayoutImmutable, Blittable, ContainerFieldNameHash(3156145579)]
		public float NearPlane { get { return m_NearPlane; } set { if (OnPropertyChanging("CameraData." + nameof(NearPlane), this, m_NearPlane, value)) m_NearPlane = value; } } // 0x38 (56)
		
		protected float m_ShadowViewDistanceScale = new float();
		[ContainerField(60), LayoutImmutable, Blittable, ContainerFieldNameHash(2622540501)]
		public float ShadowViewDistanceScale { get { return m_ShadowViewDistanceScale; } set { if (OnPropertyChanging("CameraData." + nameof(ShadowViewDistanceScale), this, m_ShadowViewDistanceScale, value)) m_ShadowViewDistanceScale = value; } } // 0x3C (60)
		
		protected float m_SoundOcclusion = new float();
		[ContainerField(64), LayoutImmutable, Blittable, ContainerFieldNameHash(3140497259)]
		public float SoundOcclusion { get { return m_SoundOcclusion; } set { if (OnPropertyChanging("CameraData." + nameof(SoundOcclusion), this, m_SoundOcclusion, value)) m_SoundOcclusion = value; } } // 0x40 (64)
		
		protected bool m_StayFadedWhileStreaming = new bool();
		[ContainerField(68), LayoutImmutable, Blittable, ContainerFieldNameHash(4069555099)]
		public bool StayFadedWhileStreaming { get { return m_StayFadedWhileStreaming; } set { if (OnPropertyChanging("CameraData." + nameof(StayFadedWhileStreaming), this, m_StayFadedWhileStreaming, value)) m_StayFadedWhileStreaming = value; } } // 0x44 (68)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2352466319:
					OcclusionRayOffset = (Vec3) p_Value;
					break;

				case 1800518652:
					ShakeFactor = (float) p_Value;
					break;

				case 3677592337:
					PreFadeTime = (float) p_Value;
					break;

				case 4001222838:
					FadeTime = (float) p_Value;
					break;

				case 3603496477:
					FadeWaitTime = (float) p_Value;
					break;

				case 3076143232:
					SoundListenerRadius = (float) p_Value;
					break;

				case 3151571446:
					ViewFx = (CtrRef<ViewFxData>) p_Value;
					break;

				case 3156145579:
					NearPlane = (float) p_Value;
					break;

				case 2622540501:
					ShadowViewDistanceScale = (float) p_Value;
					break;

				case 3140497259:
					SoundOcclusion = (float) p_Value;
					break;

				case 4069555099:
					StayFadedWhileStreaming = (bool) p_Value;
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
				case 2352466319:
					return OcclusionRayOffset;

				case 1800518652:
					return ShakeFactor;

				case 3677592337:
					return PreFadeTime;

				case 4001222838:
					return FadeTime;

				case 3603496477:
					return FadeWaitTime;

				case 3076143232:
					return SoundListenerRadius;

				case 3151571446:
					return ViewFx;

				case 3156145579:
					return NearPlane;

				case 2622540501:
					return ShadowViewDistanceScale;

				case 3140497259:
					return SoundOcclusion;

				case 4069555099:
					return StayFadedWhileStreaming;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2352466319:
					return typeof(CameraData).GetProperty(nameof(OcclusionRayOffset));

				case 1800518652:
					return typeof(CameraData).GetProperty(nameof(ShakeFactor));

				case 3677592337:
					return typeof(CameraData).GetProperty(nameof(PreFadeTime));

				case 4001222838:
					return typeof(CameraData).GetProperty(nameof(FadeTime));

				case 3603496477:
					return typeof(CameraData).GetProperty(nameof(FadeWaitTime));

				case 3076143232:
					return typeof(CameraData).GetProperty(nameof(SoundListenerRadius));

				case 3151571446:
					return typeof(CameraData).GetProperty(nameof(ViewFx));

				case 3156145579:
					return typeof(CameraData).GetProperty(nameof(NearPlane));

				case 2622540501:
					return typeof(CameraData).GetProperty(nameof(ShadowViewDistanceScale));

				case 3140497259:
					return typeof(CameraData).GetProperty(nameof(SoundOcclusion));

				case 4069555099:
					return typeof(CameraData).GetProperty(nameof(StayFadedWhileStreaming));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
