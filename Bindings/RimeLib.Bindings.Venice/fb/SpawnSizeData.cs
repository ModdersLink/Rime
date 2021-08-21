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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 64)]
	public class SpawnSizeData : 
		ProcessorData
	{
		protected float m_Size = new float();
		[ContainerField(Name: "Size", Offset: 48, NameHash: 2089429248, Flags: 49469), LayoutImmutable, Blittable]
		public float Size { get { return m_Size; } set { if (OnPropertyChanging("SpawnSizeData." + nameof(Size), this, m_Size, value)) m_Size = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089429248:
					Size = (float) p_Value;
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
				case 2089429248:
					return typeof(SpawnSizeData).GetProperty(nameof(Size));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
