///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class RawFileDataAsset : 
		RawFileAsset
	{
		protected List<byte> m_RawData = new List<byte>();
		[ContainerField(Name: "RawData", Offset: 12, NameHash: 1456371441, Flags: 65)]
		public List<byte> RawData { get { return m_RawData; } set { if (OnPropertyChanging("RawFileDataAsset." + nameof(RawData), this, m_RawData, value)) m_RawData = value; } } // 0xC (12)
		
		protected uint m_Size = new uint();
		[ContainerField(Name: "Size", Offset: 16, NameHash: 2089429248, Flags: 49421), LayoutImmutable, Blittable]
		public uint Size { get { return m_Size; } set { if (OnPropertyChanging("RawFileDataAsset." + nameof(Size), this, m_Size, value)) m_Size = value; } } // 0x10 (16)
		
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
