///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class RawFileDataAsset : 
		RawFileAsset
	{
		[ContainerField(12)]
		public List<byte> RawData { get; set; } = new List<byte>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint Size { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1456371441:
					RawData = (List<byte>) p_Value;
					break;

				case 2089429248:
					Size = (uint) p_Value;
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
				case 1456371441:
					return RawData;

				case 2089429248:
					return Size;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1456371441:
					return typeof(RawFileDataAsset).GetProperty(nameof(RawData));

				case 2089429248:
					return typeof(RawFileDataAsset).GetProperty(nameof(Size));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
