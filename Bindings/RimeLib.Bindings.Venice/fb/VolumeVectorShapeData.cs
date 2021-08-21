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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class VolumeVectorShapeData : 
		VectorShapeData
	{
		protected float m_Height = new float();
		[ContainerField(Name: "Height", Offset: 28, NameHash: 3054065626, Flags: 49469), LayoutImmutable, Blittable]
		public float Height { get { return m_Height; } set { if (OnPropertyChanging("VolumeVectorShapeData." + nameof(Height), this, m_Height, value)) m_Height = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3054065626:
					Height = (float) p_Value;
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
				case 3054065626:
					return Height;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3054065626:
					return typeof(VolumeVectorShapeData).GetProperty(nameof(Height));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
