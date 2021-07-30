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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 96)]
	public class OBBData : 
		BaseShapeData
	{
		protected LinearTransform m_Transform = new LinearTransform();
		[ContainerField(Name: "Transform", Offset: 16, NameHash: 2270319721, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get { return m_Transform; } set { if (OnPropertyChanging("OBBData." + nameof(Transform), this, m_Transform, value)) m_Transform = value; } } // 0x10 (16)
		
		protected Vec3 m_HalfExtents = new Vec3();
		[ContainerField(Name: "HalfExtents", Offset: 80, NameHash: 905253763, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 HalfExtents { get { return m_HalfExtents; } set { if (OnPropertyChanging("OBBData." + nameof(HalfExtents), this, m_HalfExtents, value)) m_HalfExtents = value; } } // 0x50 (80)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2270319721:
					Transform = (LinearTransform) p_Value;
					break;

				case 905253763:
					HalfExtents = (Vec3) p_Value;
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
				case 2270319721:
					return Transform;

				case 905253763:
					return HalfExtents;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2270319721:
					return typeof(OBBData).GetProperty(nameof(Transform));

				case 905253763:
					return typeof(OBBData).GetProperty(nameof(HalfExtents));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
