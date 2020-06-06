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
	public class AnimatedDriverEntityData : 
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform InputTransform { get; set; } = new LinearTransform(); // 0x60 (96)
		
		[ContainerField(160)]
		public AntRef VehicleBoost { get; set; } = new AntRef(); // 0xA0 (160)
		
		[ContainerField(164)]
		public AntRef VehicleSpeed { get; set; } = new AntRef(); // 0xA4 (164)
		
		[ContainerField(168)]
		public AntRef VehicleMovementState { get; set; } = new AntRef(); // 0xA8 (168)
		
		[ContainerField(172)]
		public AntRef VehicleClutch { get; set; } = new AntRef(); // 0xAC (172)
		
		[ContainerField(176)]
		public AntRef VehicleBrake { get; set; } = new AntRef(); // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public float MovementStateStandThreshold { get; set; } // 0xB4 (180)
		
		[ContainerField(184)]
		public NormalizeSettings Yaw { get; set; } = new NormalizeSettings(); // 0xB8 (184)
		
		[ContainerField(208)]
		public NormalizeSettings Roll { get; set; } = new NormalizeSettings(); // 0xD0 (208)
		
		[ContainerField(232)]
		public NormalizeSettings Pitch { get; set; } = new NormalizeSettings(); // 0xE8 (232)
		
		[ContainerField(256), LayoutImmutable, Blittable]
		public bool DelayAnimationWheelTransform { get; set; } // 0x100 (256)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 674191935:
					InputTransform = (LinearTransform) p_Value;
					break;

				case 519733784:
					VehicleBoost = (AntRef) p_Value;
					break;

				case 503036026:
					VehicleSpeed = (AntRef) p_Value;
					break;

				case 2105315721:
					VehicleMovementState = (AntRef) p_Value;
					break;

				case 13000376:
					VehicleClutch = (AntRef) p_Value;
					break;

				case 519539362:
					VehicleBrake = (AntRef) p_Value;
					break;

				case 1916267914:
					MovementStateStandThreshold = (float) p_Value;
					break;

				case 193468618:
					Yaw = (NormalizeSettings) p_Value;
					break;

				case 2089387576:
					Roll = (NormalizeSettings) p_Value;
					break;

				case 232604323:
					Pitch = (NormalizeSettings) p_Value;
					break;

				case 1883575417:
					DelayAnimationWheelTransform = (bool) p_Value;
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
				case 674191935:
					return InputTransform;

				case 519733784:
					return VehicleBoost;

				case 503036026:
					return VehicleSpeed;

				case 2105315721:
					return VehicleMovementState;

				case 13000376:
					return VehicleClutch;

				case 519539362:
					return VehicleBrake;

				case 1916267914:
					return MovementStateStandThreshold;

				case 193468618:
					return Yaw;

				case 2089387576:
					return Roll;

				case 232604323:
					return Pitch;

				case 1883575417:
					return DelayAnimationWheelTransform;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 674191935:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(InputTransform));

				case 519733784:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(VehicleBoost));

				case 503036026:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(VehicleSpeed));

				case 2105315721:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(VehicleMovementState));

				case 13000376:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(VehicleClutch));

				case 519539362:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(VehicleBrake));

				case 1916267914:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(MovementStateStandThreshold));

				case 193468618:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(Yaw));

				case 2089387576:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(Roll));

				case 232604323:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(Pitch));

				case 1883575417:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(DelayAnimationWheelTransform));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
