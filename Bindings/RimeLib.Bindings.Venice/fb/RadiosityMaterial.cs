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
	public class RadiosityMaterial : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Color { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable]
		public string Name { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool Emissive { get; set; } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 212387320:
					Color = (Vec3) p_Value;
					break;

				case 2088949890:
					Name = (string) p_Value;
					break;

				case 782359646:
					Emissive = (bool) p_Value;
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
				case 212387320:
					return Color;

				case 2088949890:
					return Name;

				case 782359646:
					return Emissive;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 212387320:
					return typeof(RadiosityMaterial).GetProperty(nameof(Color));

				case 2088949890:
					return typeof(RadiosityMaterial).GetProperty(nameof(Name));

				case 782359646:
					return typeof(RadiosityMaterial).GetProperty(nameof(Emissive));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
