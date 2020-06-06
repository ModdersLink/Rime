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
	public class UICustomizationCompData : 
		UIComponentData
	{
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SoldierOffset { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SoldierRotation { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 VehicleRotation { get; set; } = new Vec3(); // 0x40 (64)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float NetworkThrottleTimer { get; set; } // 0x50 (80)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1109239746:
					SoldierOffset = (Vec3) p_Value;
					break;

				case 853309051:
					SoldierRotation = (Vec3) p_Value;
					break;

				case 7325673:
					VehicleRotation = (Vec3) p_Value;
					break;

				case 441904308:
					NetworkThrottleTimer = (float) p_Value;
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
				case 1109239746:
					return SoldierOffset;

				case 853309051:
					return SoldierRotation;

				case 7325673:
					return VehicleRotation;

				case 441904308:
					return NetworkThrottleTimer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1109239746:
					return typeof(UICustomizationCompData).GetProperty(nameof(SoldierOffset));

				case 853309051:
					return typeof(UICustomizationCompData).GetProperty(nameof(SoldierRotation));

				case 7325673:
					return typeof(UICustomizationCompData).GetProperty(nameof(VehicleRotation));

				case 441904308:
					return typeof(UICustomizationCompData).GetProperty(nameof(NetworkThrottleTimer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
