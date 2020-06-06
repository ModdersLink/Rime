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
	public class VehicleExitPointComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Impulse { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float TerrainHeight { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public int Ordinal { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float Velocity { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public bool InheritCameraDirection { get; set; } // 0x7C (124)
		
		[ContainerField(125), LayoutImmutable, Blittable]
		public bool CheckForVehicleOverrun { get; set; } // 0x7D (125)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1723395486:
					Impulse = (Vec3) p_Value;
					break;

				case 3163704045:
					TerrainHeight = (float) p_Value;
					break;

				case 747685430:
					Ordinal = (int) p_Value;
					break;

				case 3860766482:
					Velocity = (float) p_Value;
					break;

				case 1304457244:
					InheritCameraDirection = (bool) p_Value;
					break;

				case 587298343:
					CheckForVehicleOverrun = (bool) p_Value;
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
				case 1723395486:
					return Impulse;

				case 3163704045:
					return TerrainHeight;

				case 747685430:
					return Ordinal;

				case 3860766482:
					return Velocity;

				case 1304457244:
					return InheritCameraDirection;

				case 587298343:
					return CheckForVehicleOverrun;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1723395486:
					return typeof(VehicleExitPointComponentData).GetProperty(nameof(Impulse));

				case 3163704045:
					return typeof(VehicleExitPointComponentData).GetProperty(nameof(TerrainHeight));

				case 747685430:
					return typeof(VehicleExitPointComponentData).GetProperty(nameof(Ordinal));

				case 3860766482:
					return typeof(VehicleExitPointComponentData).GetProperty(nameof(Velocity));

				case 1304457244:
					return typeof(VehicleExitPointComponentData).GetProperty(nameof(InheritCameraDirection));

				case 587298343:
					return typeof(VehicleExitPointComponentData).GetProperty(nameof(CheckForVehicleOverrun));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
