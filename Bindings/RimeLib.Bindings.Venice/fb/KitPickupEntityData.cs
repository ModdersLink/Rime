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
	public class KitPickupEntityData : 
		PickupEntityData
	{
		[ContainerField(176), LayoutImmutable, Blittable]
		public bool KeepAdditionalWeapons { get; set; } // 0xB0 (176)
		
		[ContainerField(177), LayoutImmutable, Blittable]
		public bool KeepAmmoState { get; set; } // 0xB1 (177)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2585816246:
					KeepAdditionalWeapons = (bool) p_Value;
					break;

				case 2997013959:
					KeepAmmoState = (bool) p_Value;
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
				case 2585816246:
					return KeepAdditionalWeapons;

				case 2997013959:
					return KeepAmmoState;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2585816246:
					return typeof(KitPickupEntityData).GetProperty(nameof(KeepAdditionalWeapons));

				case 2997013959:
					return typeof(KitPickupEntityData).GetProperty(nameof(KeepAmmoState));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
