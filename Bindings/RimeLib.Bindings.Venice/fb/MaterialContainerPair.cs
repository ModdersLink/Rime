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
	public class MaterialContainerPair : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint FlagsAndIndex { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public sbyte PhysicsPropertyIndex { get; set; } // 0xC (12)
		
		[ContainerField(13), LayoutImmutable, Blittable]
		public sbyte PhysicsMaterialIndex { get; set; } // 0xD (13)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 948792655:
					FlagsAndIndex = (uint) p_Value;
					break;

				case 2298256471:
					PhysicsPropertyIndex = (sbyte) p_Value;
					break;

				case 2836775707:
					PhysicsMaterialIndex = (sbyte) p_Value;
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
				case 948792655:
					return FlagsAndIndex;

				case 2298256471:
					return PhysicsPropertyIndex;

				case 2836775707:
					return PhysicsMaterialIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 948792655:
					return typeof(MaterialContainerPair).GetProperty(nameof(FlagsAndIndex));

				case 2298256471:
					return typeof(MaterialContainerPair).GetProperty(nameof(PhysicsPropertyIndex));

				case 2836775707:
					return typeof(MaterialContainerPair).GetProperty(nameof(PhysicsMaterialIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
