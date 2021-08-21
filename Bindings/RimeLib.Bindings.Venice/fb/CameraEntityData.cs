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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class CameraEntityData : 
		CameraEntityBaseData
	{
		protected float m_Fov = new float();
		[ContainerField(Name: "Fov", Offset: 96, NameHash: 193443802, Flags: 49469), LayoutImmutable, Blittable]
		public float Fov { get { return m_Fov; } set { if (OnPropertyChanging("CameraEntityData." + nameof(Fov), this, m_Fov, value)) m_Fov = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193443802:
					Fov = (float) p_Value;
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
				case 193443802:
					return Fov;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193443802:
					return typeof(CameraEntityData).GetProperty(nameof(Fov));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
