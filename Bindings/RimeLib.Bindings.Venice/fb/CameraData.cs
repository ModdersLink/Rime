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
	public class CameraData : 
		GameObjectData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 OcclusionRayOffset { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float ShakeFactor { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float PreFadeTime { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float FadeTime { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float FadeWaitTime { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float SoundListenerRadius { get; set; } // 0x30 (48)
		
		[ContainerField(52)]
		public CtrRef<ViewFxData> ViewFx { get; set; } = new CtrRef<ViewFxData>(); // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float NearPlane { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float ShadowViewDistanceScale { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float SoundOcclusion { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public bool StayFadedWhileStreaming { get; set; } // 0x44 (68)
		
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
