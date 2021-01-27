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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class WeaponRegularSocketObjectData : 
		WeaponSocketObjectData
	{
		protected LinearTransform m_Transform = new LinearTransform();
		[ContainerField(Name: "Transform", Offset: 32, NameHash: 2270319721, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get { return m_Transform; } set { if (OnPropertyChanging("WeaponRegularSocketObjectData." + nameof(Transform), this, m_Transform, value)) m_Transform = value; } } // 0x20 (32)
		
		protected List<LinearTransform> m_Mesh3pTransforms = new List<LinearTransform>();
		[ContainerField(Name: "Mesh3pTransforms", Offset: 96, NameHash: 1625436330, Flags: 65)]
		public List<LinearTransform> Mesh3pTransforms { get { return m_Mesh3pTransforms; } set { if (OnPropertyChanging("WeaponRegularSocketObjectData." + nameof(Mesh3pTransforms), this, m_Mesh3pTransforms, value)) m_Mesh3pTransforms = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2270319721:
					Transform = (LinearTransform) p_Value;
					break;

				case 1625436330:
					Mesh3pTransforms = (List<LinearTransform>) p_Value;
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

				case 1625436330:
					return Mesh3pTransforms;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2270319721:
					return typeof(WeaponRegularSocketObjectData).GetProperty(nameof(Transform));

				case 1625436330:
					return typeof(WeaponRegularSocketObjectData).GetProperty(nameof(Mesh3pTransforms));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
