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
	public class FloatPhysicsData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Density { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float FilledDensity { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4008572221:
					Density = (float) p_Value;
					break;

				case 1851378675:
					FilledDensity = (float) p_Value;
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
				case 4008572221:
					return Density;

				case 1851378675:
					return FilledDensity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4008572221:
					return typeof(FloatPhysicsData).GetProperty(nameof(Density));

				case 1851378675:
					return typeof(FloatPhysicsData).GetProperty(nameof(FilledDensity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
