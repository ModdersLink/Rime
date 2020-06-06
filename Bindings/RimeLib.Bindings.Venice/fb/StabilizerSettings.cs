///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class StabilizerSettings : FrostbiteContainer
	{
		[ContainerField(0)]
		public StabilizerProperty Property { get; set; } = new StabilizerProperty(); // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float Strength { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public bool Advanced { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3010621090:
						Property = (StabilizerProperty) Enum.ToObject(typeof(StabilizerProperty), p_Value);
					break;

				case 3531643328:
					Strength = (float) p_Value;
					break;

				case 2748179067:
					Advanced = (bool) p_Value;
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
				case 3010621090:
					return Property;

				case 3531643328:
					return Strength;

				case 2748179067:
					return Advanced;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3010621090:
					return typeof(StabilizerSettings).GetProperty(nameof(Property));

				case 3531643328:
					return typeof(StabilizerSettings).GetProperty(nameof(Strength));

				case 2748179067:
					return typeof(StabilizerSettings).GetProperty(nameof(Advanced));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
