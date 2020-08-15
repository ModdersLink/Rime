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
	[ContainerType(16)]
	public class RegularSocketObjectData : 
		SocketObjectData
	{
		protected LinearTransform m_Transform = new LinearTransform();
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2270319721)]
		public LinearTransform Transform { get { return m_Transform; } set { if (OnPropertyChanging("RegularSocketObjectData." + nameof(Transform), this, m_Transform, value)) m_Transform = value; } } // 0x50 (80)
		
		protected List<LinearTransform> m_Mesh3pTransforms = new List<LinearTransform>();
		[ContainerField(144), ContainerFieldNameHash(1625436330)]
		public List<LinearTransform> Mesh3pTransforms { get { return m_Mesh3pTransforms; } set { if (OnPropertyChanging("RegularSocketObjectData." + nameof(Mesh3pTransforms), this, m_Mesh3pTransforms, value)) m_Mesh3pTransforms = value; } } // 0x90 (144)
		
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
					return typeof(RegularSocketObjectData).GetProperty(nameof(Transform));

				case 1625436330:
					return typeof(RegularSocketObjectData).GetProperty(nameof(Mesh3pTransforms));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
