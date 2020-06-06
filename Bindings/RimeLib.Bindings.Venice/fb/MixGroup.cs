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
	public class MixGroup : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public ushort GroupIndex { get; set; } // 0xC (12)
		
		[ContainerField(14), LayoutImmutable, Blittable]
		public ushort ParentGroupIndex { get; set; } // 0xE (14)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 1804853668:
					GroupIndex = (ushort) p_Value;
					break;

				case 1896210840:
					ParentGroupIndex = (ushort) p_Value;
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
				case 2088949890:
					return Name;

				case 1804853668:
					return GroupIndex;

				case 1896210840:
					return ParentGroupIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(MixGroup).GetProperty(nameof(Name));

				case 1804853668:
					return typeof(MixGroup).GetProperty(nameof(GroupIndex));

				case 1896210840:
					return typeof(MixGroup).GetProperty(nameof(ParentGroupIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
