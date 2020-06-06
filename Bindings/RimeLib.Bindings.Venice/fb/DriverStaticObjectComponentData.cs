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
	public class DriverStaticObjectComponentData : 
		DriverComponentData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public float Acceleration { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float Deceleration { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float TurningRadius { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public bool TurnWhileStill { get; set; } // 0x7C (124)
		
		[ContainerField(125), LayoutImmutable, Blittable]
		public bool AlignWithGroundNormal { get; set; } // 0x7D (125)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 62601415:
					Acceleration = (float) p_Value;
					break;

				case 8356516:
					Deceleration = (float) p_Value;
					break;

				case 4134465344:
					TurningRadius = (float) p_Value;
					break;

				case 2034681993:
					TurnWhileStill = (bool) p_Value;
					break;

				case 387843516:
					AlignWithGroundNormal = (bool) p_Value;
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
				case 62601415:
					return Acceleration;

				case 8356516:
					return Deceleration;

				case 4134465344:
					return TurningRadius;

				case 2034681993:
					return TurnWhileStill;

				case 387843516:
					return AlignWithGroundNormal;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 62601415:
					return typeof(DriverStaticObjectComponentData).GetProperty(nameof(Acceleration));

				case 8356516:
					return typeof(DriverStaticObjectComponentData).GetProperty(nameof(Deceleration));

				case 4134465344:
					return typeof(DriverStaticObjectComponentData).GetProperty(nameof(TurningRadius));

				case 2034681993:
					return typeof(DriverStaticObjectComponentData).GetProperty(nameof(TurnWhileStill));

				case 387843516:
					return typeof(DriverStaticObjectComponentData).GetProperty(nameof(AlignWithGroundNormal));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
