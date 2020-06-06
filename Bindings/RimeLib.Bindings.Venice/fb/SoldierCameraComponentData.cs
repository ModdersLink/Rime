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
	public class SoldierCameraComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float ExplosionImpulseMultiplier { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float StrafeTiltStrength { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float PitchTiltStrength { get; set; } // 0x68 (104)
		
		[ContainerField(108)]
		public RefArray<TargetCameraData> Cameras { get; set; } = new RefArray<TargetCameraData>(); // 0x6C (108)
		
		[ContainerField(112)]
		public CameraBinding CameraBinding { get; set; } = new CameraBinding(); // 0x70 (112)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float ForceFieldOfView { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public bool AuthoritativeEyePosition { get; set; } // 0x7C (124)
		
		[ContainerField(125), LayoutImmutable, Blittable]
		public bool DisableAiming { get; set; } // 0x7D (125)
		
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
