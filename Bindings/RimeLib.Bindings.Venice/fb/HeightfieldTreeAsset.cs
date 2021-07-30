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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class HeightfieldTreeAsset : 
		RasterTreeAsset
	{
		protected float m_MinHeightWidth = new float();
		[ContainerField(Name: "MinHeightWidth", Offset: 8, NameHash: 1959332726, Flags: 49469), LayoutImmutable, Blittable]
		public float MinHeightWidth { get { return m_MinHeightWidth; } set { if (OnPropertyChanging("HeightfieldTreeAsset." + nameof(MinHeightWidth), this, m_MinHeightWidth, value)) m_MinHeightWidth = value; } } // 0x8 (8)
		
		protected int m_MinHeightSamplesPerSide = new int();
		[ContainerField(Name: "MinHeightSamplesPerSide", Offset: 12, NameHash: 4074360025, Flags: 49405), LayoutImmutable, Blittable]
		public int MinHeightSamplesPerSide { get { return m_MinHeightSamplesPerSide; } set { if (OnPropertyChanging("HeightfieldTreeAsset." + nameof(MinHeightSamplesPerSide), this, m_MinHeightSamplesPerSide, value)) m_MinHeightSamplesPerSide = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1959332726:
					MinHeightWidth = (float) p_Value;
					break;

				case 4074360025:
					MinHeightSamplesPerSide = (int) p_Value;
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
				case 1959332726:
					return MinHeightWidth;

				case 4074360025:
					return MinHeightSamplesPerSide;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1959332726:
					return typeof(HeightfieldTreeAsset).GetProperty(nameof(MinHeightWidth));

				case 4074360025:
					return typeof(HeightfieldTreeAsset).GetProperty(nameof(MinHeightSamplesPerSide));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
