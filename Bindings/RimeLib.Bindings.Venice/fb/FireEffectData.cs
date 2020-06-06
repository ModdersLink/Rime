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
	public class FireEffectData : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Rotation { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Offset { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ZoomRotation { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ZoomOffset { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64)]
		public CtrRef<EffectBlueprint> Effect { get; set; } = new CtrRef<EffectBlueprint>(); // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public bool UseZoomOffset { get; set; } // 0x44 (68)
		
		[ContainerField(69), LayoutImmutable, Blittable]
		public bool UseZoomRotation { get; set; } // 0x45 (69)
		
		[ContainerField(70), LayoutImmutable, Blittable]
		public bool DisableDuringZoom { get; set; } // 0x46 (70)
		
		[ContainerField(71), LayoutImmutable, Blittable]
		public bool UpdateTransform { get; set; } // 0x47 (71)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public bool StopLoopingEffects { get; set; } // 0x48 (72)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 48673745:
					Rotation = (Vec3) p_Value;
					break;

				case 2871410728:
					Offset = (Vec3) p_Value;
					break;

				case 3320560134:
					ZoomRotation = (Vec3) p_Value;
					break;

				case 4245097407:
					ZoomOffset = (Vec3) p_Value;
					break;

				case 2332983090:
					Effect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 3904716028:
					UseZoomOffset = (bool) p_Value;
					break;

				case 3031914373:
					UseZoomRotation = (bool) p_Value;
					break;

				case 3735365637:
					DisableDuringZoom = (bool) p_Value;
					break;

				case 2409007832:
					UpdateTransform = (bool) p_Value;
					break;

				case 3709447781:
					StopLoopingEffects = (bool) p_Value;
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
				case 48673745:
					return Rotation;

				case 2871410728:
					return Offset;

				case 3320560134:
					return ZoomRotation;

				case 4245097407:
					return ZoomOffset;

				case 2332983090:
					return Effect;

				case 3904716028:
					return UseZoomOffset;

				case 3031914373:
					return UseZoomRotation;

				case 3735365637:
					return DisableDuringZoom;

				case 2409007832:
					return UpdateTransform;

				case 3709447781:
					return StopLoopingEffects;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 48673745:
					return typeof(FireEffectData).GetProperty(nameof(Rotation));

				case 2871410728:
					return typeof(FireEffectData).GetProperty(nameof(Offset));

				case 3320560134:
					return typeof(FireEffectData).GetProperty(nameof(ZoomRotation));

				case 4245097407:
					return typeof(FireEffectData).GetProperty(nameof(ZoomOffset));

				case 2332983090:
					return typeof(FireEffectData).GetProperty(nameof(Effect));

				case 3904716028:
					return typeof(FireEffectData).GetProperty(nameof(UseZoomOffset));

				case 3031914373:
					return typeof(FireEffectData).GetProperty(nameof(UseZoomRotation));

				case 3735365637:
					return typeof(FireEffectData).GetProperty(nameof(DisableDuringZoom));

				case 2409007832:
					return typeof(FireEffectData).GetProperty(nameof(UpdateTransform));

				case 3709447781:
					return typeof(FireEffectData).GetProperty(nameof(StopLoopingEffects));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
