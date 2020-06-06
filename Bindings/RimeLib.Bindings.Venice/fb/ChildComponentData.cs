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
	public class ChildComponentData : 
		PartComponentData
	{
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform AlignTransform { get; set; } = new LinearTransform(); // 0x70 (112)
		
		[ContainerField(176)]
		public CtrRef<MovingBodyData> MovingBody { get; set; } = new CtrRef<MovingBodyData>(); // 0xB0 (176)
		
		[ContainerField(180)]
		public VehicleHealthZoneData HealthZone { get; set; } = new VehicleHealthZoneData(); // 0xB4 (180)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public float SoundEffectStartRpm { get; set; } // 0xC8 (200)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public float SoundEffectStopRpm { get; set; } // 0xCC (204)
		
		[ContainerField(208)]
		public CtrRef<AlignmentData> AlignmentSettings { get; set; } = new CtrRef<AlignmentData>(); // 0xD0 (208)
		
		[ContainerField(212)]
		public CtrRef<SoundAsset> SoundEffect { get; set; } = new CtrRef<SoundAsset>(); // 0xD4 (212)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public bool EnableAlignToCamera { get; set; } // 0xD8 (216)
		
		[ContainerField(217), LayoutImmutable, Blittable]
		public bool WorldSpacePositionLock { get; set; } // 0xD9 (217)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4277081604:
					AlignTransform = (LinearTransform) p_Value;
					break;

				case 654150049:
					MovingBody = (CtrRef<MovingBodyData>) p_Value;
					break;

				case 3196619047:
					HealthZone = (VehicleHealthZoneData) p_Value;
					break;

				case 2939554110:
					SoundEffectStartRpm = (float) p_Value;
					break;

				case 1267382822:
					SoundEffectStopRpm = (float) p_Value;
					break;

				case 870827711:
					AlignmentSettings = (CtrRef<AlignmentData>) p_Value;
					break;

				case 3556609201:
					SoundEffect = (CtrRef<SoundAsset>) p_Value;
					break;

				case 2538251595:
					EnableAlignToCamera = (bool) p_Value;
					break;

				case 3785410993:
					WorldSpacePositionLock = (bool) p_Value;
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
				case 4277081604:
					return AlignTransform;

				case 654150049:
					return MovingBody;

				case 3196619047:
					return HealthZone;

				case 2939554110:
					return SoundEffectStartRpm;

				case 1267382822:
					return SoundEffectStopRpm;

				case 870827711:
					return AlignmentSettings;

				case 3556609201:
					return SoundEffect;

				case 2538251595:
					return EnableAlignToCamera;

				case 3785410993:
					return WorldSpacePositionLock;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4277081604:
					return typeof(ChildComponentData).GetProperty(nameof(AlignTransform));

				case 654150049:
					return typeof(ChildComponentData).GetProperty(nameof(MovingBody));

				case 3196619047:
					return typeof(ChildComponentData).GetProperty(nameof(HealthZone));

				case 2939554110:
					return typeof(ChildComponentData).GetProperty(nameof(SoundEffectStartRpm));

				case 1267382822:
					return typeof(ChildComponentData).GetProperty(nameof(SoundEffectStopRpm));

				case 870827711:
					return typeof(ChildComponentData).GetProperty(nameof(AlignmentSettings));

				case 3556609201:
					return typeof(ChildComponentData).GetProperty(nameof(SoundEffect));

				case 2538251595:
					return typeof(ChildComponentData).GetProperty(nameof(EnableAlignToCamera));

				case 3785410993:
					return typeof(ChildComponentData).GetProperty(nameof(WorldSpacePositionLock));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
