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
	public class VehicleWaypointData : 
		WaypointData
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Speed { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float SpeedOverrideMovingTowards { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Angleoffset { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float StopHereRadius { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float StoppingDeceleration { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float MinSlowdownSpeed { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public bool StopHere { get; set; } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 230887042:
					Speed = (float) p_Value;
					break;

				case 4149709546:
					SpeedOverrideMovingTowards = (float) p_Value;
					break;

				case 686454889:
					Angleoffset = (float) p_Value;
					break;

				case 3378547103:
					StopHereRadius = (float) p_Value;
					break;

				case 2524085644:
					StoppingDeceleration = (float) p_Value;
					break;

				case 3207717373:
					MinSlowdownSpeed = (float) p_Value;
					break;

				case 3655484487:
					StopHere = (bool) p_Value;
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
				case 230887042:
					return Speed;

				case 4149709546:
					return SpeedOverrideMovingTowards;

				case 686454889:
					return Angleoffset;

				case 3378547103:
					return StopHereRadius;

				case 2524085644:
					return StoppingDeceleration;

				case 3207717373:
					return MinSlowdownSpeed;

				case 3655484487:
					return StopHere;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 230887042:
					return typeof(VehicleWaypointData).GetProperty(nameof(Speed));

				case 4149709546:
					return typeof(VehicleWaypointData).GetProperty(nameof(SpeedOverrideMovingTowards));

				case 686454889:
					return typeof(VehicleWaypointData).GetProperty(nameof(Angleoffset));

				case 3378547103:
					return typeof(VehicleWaypointData).GetProperty(nameof(StopHereRadius));

				case 2524085644:
					return typeof(VehicleWaypointData).GetProperty(nameof(StoppingDeceleration));

				case 3207717373:
					return typeof(VehicleWaypointData).GetProperty(nameof(MinSlowdownSpeed));

				case 3655484487:
					return typeof(VehicleWaypointData).GetProperty(nameof(StopHere));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
