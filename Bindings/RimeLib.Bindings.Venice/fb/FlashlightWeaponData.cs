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
	public class FlashlightWeaponData : 
		WeaponData
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public float UpdateFrequency { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Range { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Angle { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 219717232:
					UpdateFrequency = (float) p_Value;
					break;

				case 230112826:
					Range = (float) p_Value;
					break;

				case 205597860:
					Angle = (float) p_Value;
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
				case 219717232:
					return UpdateFrequency;

				case 230112826:
					return Range;

				case 205597860:
					return Angle;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 219717232:
					return typeof(FlashlightWeaponData).GetProperty(nameof(UpdateFrequency));

				case 230112826:
					return typeof(FlashlightWeaponData).GetProperty(nameof(Range));

				case 205597860:
					return typeof(FlashlightWeaponData).GetProperty(nameof(Angle));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
