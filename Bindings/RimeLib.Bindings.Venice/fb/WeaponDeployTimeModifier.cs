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
	public class WeaponDeployTimeModifier : 
		WeaponModifierBase
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float DeployTime { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float DisableZoomOnDeployTime { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float AltDeployTime { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public int AltDeployId { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2275884507:
					DeployTime = (float) p_Value;
					break;

				case 3731232633:
					DisableZoomOnDeployTime = (float) p_Value;
					break;

				case 1924470306:
					AltDeployTime = (float) p_Value;
					break;

				case 1819931514:
					AltDeployId = (int) p_Value;
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
				case 2275884507:
					return DeployTime;

				case 3731232633:
					return DisableZoomOnDeployTime;

				case 1924470306:
					return AltDeployTime;

				case 1819931514:
					return AltDeployId;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2275884507:
					return typeof(WeaponDeployTimeModifier).GetProperty(nameof(DeployTime));

				case 3731232633:
					return typeof(WeaponDeployTimeModifier).GetProperty(nameof(DisableZoomOnDeployTime));

				case 1924470306:
					return typeof(WeaponDeployTimeModifier).GetProperty(nameof(AltDeployTime));

				case 1819931514:
					return typeof(WeaponDeployTimeModifier).GetProperty(nameof(AltDeployId));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
