///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class ClimbingStateData : 
		CharacterStateData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float LateralInputScale { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float DownAngleLimit { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float DropOffAngle { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float AttractionVelocity { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float PushAwayVelocity { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float ClimbHeightOffset { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float ClimbOffVerticalDistance { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float ClimbOffVerticalTime { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float ClimbOffHorizontalDistance { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float ClimbOffHorizontalTime { get; set; } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2743831048:
					LateralInputScale = (float) p_Value;
					break;

				case 3644023203:
					DownAngleLimit = (float) p_Value;
					break;

				case 3349590818:
					DropOffAngle = (float) p_Value;
					break;

				case 2980040799:
					AttractionVelocity = (float) p_Value;
					break;

				case 751756002:
					PushAwayVelocity = (float) p_Value;
					break;

				case 3576433790:
					ClimbHeightOffset = (float) p_Value;
					break;

				case 1127208370:
					ClimbOffVerticalDistance = (float) p_Value;
					break;

				case 985548708:
					ClimbOffVerticalTime = (float) p_Value;
					break;

				case 1672476894:
					ClimbOffHorizontalDistance = (float) p_Value;
					break;

				case 3744214728:
					ClimbOffHorizontalTime = (float) p_Value;
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
				case 2743831048:
					return LateralInputScale;

				case 3644023203:
					return DownAngleLimit;

				case 3349590818:
					return DropOffAngle;

				case 2980040799:
					return AttractionVelocity;

				case 751756002:
					return PushAwayVelocity;

				case 3576433790:
					return ClimbHeightOffset;

				case 1127208370:
					return ClimbOffVerticalDistance;

				case 985548708:
					return ClimbOffVerticalTime;

				case 1672476894:
					return ClimbOffHorizontalDistance;

				case 3744214728:
					return ClimbOffHorizontalTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2743831048:
					return typeof(ClimbingStateData).GetProperty(nameof(LateralInputScale));

				case 3644023203:
					return typeof(ClimbingStateData).GetProperty(nameof(DownAngleLimit));

				case 3349590818:
					return typeof(ClimbingStateData).GetProperty(nameof(DropOffAngle));

				case 2980040799:
					return typeof(ClimbingStateData).GetProperty(nameof(AttractionVelocity));

				case 751756002:
					return typeof(ClimbingStateData).GetProperty(nameof(PushAwayVelocity));

				case 3576433790:
					return typeof(ClimbingStateData).GetProperty(nameof(ClimbHeightOffset));

				case 1127208370:
					return typeof(ClimbingStateData).GetProperty(nameof(ClimbOffVerticalDistance));

				case 985548708:
					return typeof(ClimbingStateData).GetProperty(nameof(ClimbOffVerticalTime));

				case 1672476894:
					return typeof(ClimbingStateData).GetProperty(nameof(ClimbOffHorizontalDistance));

				case 3744214728:
					return typeof(ClimbingStateData).GetProperty(nameof(ClimbOffHorizontalTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
