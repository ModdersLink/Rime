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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 64)]
	public class TurbulanceData : 
		ProcessorData
	{
		protected float m_Intensity = new float();
		[ContainerField(Name: "Intensity", Offset: 48, NameHash: 3836394730, Flags: 49469), LayoutImmutable, Blittable]
		public float Intensity { get { return m_Intensity; } set { if (OnPropertyChanging("TurbulanceData." + nameof(Intensity), this, m_Intensity, value)) m_Intensity = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3836394730:
					Intensity = (float) p_Value;
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
				case 3836394730:
					return Intensity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3836394730:
					return typeof(TurbulanceData).GetProperty(nameof(Intensity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
