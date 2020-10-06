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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(176), ContainerClass]
	public class FenceModelEntityData : 
		StaticModelEntityData
	{
		protected float m_Width = new float();
		[ContainerField(160), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(226981187)]
		public float Width { get { return m_Width; } set { if (OnPropertyChanging("FenceModelEntityData." + nameof(Width), this, m_Width, value)) m_Width = value; } } // 0xA0 (160)
		
		protected float m_Angle = new float();
		[ContainerField(164), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(205597860)]
		public float Angle { get { return m_Angle; } set { if (OnPropertyChanging("FenceModelEntityData." + nameof(Angle), this, m_Angle, value)) m_Angle = value; } } // 0xA4 (164)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 226981187:
					Width = (float) p_Value;
					break;

				case 205597860:
					Angle = (float) p_Value;
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
				case 226981187:
					return Width;

				case 205597860:
					return Angle;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 226981187:
					return typeof(FenceModelEntityData).GetProperty(nameof(Width));

				case 205597860:
					return typeof(FenceModelEntityData).GetProperty(nameof(Angle));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
