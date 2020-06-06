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
	public class VehicleSpawnStateEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialVelocity { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float StartupDelayModifier { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float InitialThrottle { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public uint EngineIndex { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float InitialRpmModifier { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float HeightOffset { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float Radius { get; set; } // 0x34 (52)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3508499596:
					InitialVelocity = (Vec3) p_Value;
					break;

				case 3073501154:
					StartupDelayModifier = (float) p_Value;
					break;

				case 3556007987:
					InitialThrottle = (float) p_Value;
					break;

				case 1485813685:
					EngineIndex = (uint) p_Value;
					break;

				case 304191363:
					InitialRpmModifier = (float) p_Value;
					break;

				case 1929779127:
					HeightOffset = (float) p_Value;
					break;

				case 3298407133:
					Radius = (float) p_Value;
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
				case 3508499596:
					return InitialVelocity;

				case 3073501154:
					return StartupDelayModifier;

				case 3556007987:
					return InitialThrottle;

				case 1485813685:
					return EngineIndex;

				case 304191363:
					return InitialRpmModifier;

				case 1929779127:
					return HeightOffset;

				case 3298407133:
					return Radius;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3508499596:
					return typeof(VehicleSpawnStateEntityData).GetProperty(nameof(InitialVelocity));

				case 3073501154:
					return typeof(VehicleSpawnStateEntityData).GetProperty(nameof(StartupDelayModifier));

				case 3556007987:
					return typeof(VehicleSpawnStateEntityData).GetProperty(nameof(InitialThrottle));

				case 1485813685:
					return typeof(VehicleSpawnStateEntityData).GetProperty(nameof(EngineIndex));

				case 304191363:
					return typeof(VehicleSpawnStateEntityData).GetProperty(nameof(InitialRpmModifier));

				case 1929779127:
					return typeof(VehicleSpawnStateEntityData).GetProperty(nameof(HeightOffset));

				case 3298407133:
					return typeof(VehicleSpawnStateEntityData).GetProperty(nameof(Radius));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
