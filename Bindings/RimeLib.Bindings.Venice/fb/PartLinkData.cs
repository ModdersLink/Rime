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
	public class PartLinkData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint PartComponentIndex1 { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint PartComponentIndex2 { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 830683346:
					PartComponentIndex1 = (uint) p_Value;
					break;

				case 830683345:
					PartComponentIndex2 = (uint) p_Value;
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
				case 830683346:
					return PartComponentIndex1;

				case 830683345:
					return PartComponentIndex2;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 830683346:
					return typeof(PartLinkData).GetProperty(nameof(PartComponentIndex1));

				case 830683345:
					return typeof(PartLinkData).GetProperty(nameof(PartComponentIndex2));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
