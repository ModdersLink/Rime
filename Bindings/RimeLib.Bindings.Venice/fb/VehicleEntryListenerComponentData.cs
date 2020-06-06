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
	public class VehicleEntryListenerComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public VehicleEntryListenerBinding VehicleEntryListener { get; set; } = new VehicleEntryListenerBinding(); // 0x60 (96)
		
		[ContainerField(156)]
		public VehicleCameraControlBinding VehicleCameraControl { get; set; } = new VehicleCameraControlBinding(); // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float AnimationWheelTransformDelay { get; set; } // 0xA4 (164)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1646308695:
					VehicleEntryListener = (VehicleEntryListenerBinding) p_Value;
					break;

				case 478775939:
					VehicleCameraControl = (VehicleCameraControlBinding) p_Value;
					break;

				case 4041607518:
					AnimationEntitySpacePriority = (int) p_Value;
					break;

				case 2638640185:
					AnimationWheelTransformDelay = (float) p_Value;
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
				case 1646308695:
					return VehicleEntryListener;

				case 478775939:
					return VehicleCameraControl;

				case 4041607518:
					return AnimationEntitySpacePriority;

				case 2638640185:
					return AnimationWheelTransformDelay;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1646308695:
					return typeof(VehicleEntryListenerComponentData).GetProperty(nameof(VehicleEntryListener));

				case 478775939:
					return typeof(VehicleEntryListenerComponentData).GetProperty(nameof(VehicleCameraControl));

				case 4041607518:
					return typeof(VehicleEntryListenerComponentData).GetProperty(nameof(AnimationEntitySpacePriority));

				case 2638640185:
					return typeof(VehicleEntryListenerComponentData).GetProperty(nameof(AnimationWheelTransformDelay));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
