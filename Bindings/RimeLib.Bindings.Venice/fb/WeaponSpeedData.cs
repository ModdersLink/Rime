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
	public class WeaponSpeedData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float ZoomOutSpeed { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float ZoomInSpeed { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float UnDeploySpeed { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float DeploySpeed { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2275851931:
					ZoomOutSpeed = (float) p_Value;
					break;

				case 638313682:
					ZoomInSpeed = (float) p_Value;
					break;

				case 3170443666:
					UnDeploySpeed = (float) p_Value;
					break;

				case 2095054953:
					DeploySpeed = (float) p_Value;
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
				case 2275851931:
					return ZoomOutSpeed;

				case 638313682:
					return ZoomInSpeed;

				case 3170443666:
					return UnDeploySpeed;

				case 2095054953:
					return DeploySpeed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2275851931:
					return typeof(WeaponSpeedData).GetProperty(nameof(ZoomOutSpeed));

				case 638313682:
					return typeof(WeaponSpeedData).GetProperty(nameof(ZoomInSpeed));

				case 3170443666:
					return typeof(WeaponSpeedData).GetProperty(nameof(UnDeploySpeed));

				case 2095054953:
					return typeof(WeaponSpeedData).GetProperty(nameof(DeploySpeed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
