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
	public class GravityData : 
		ProcessorData
	{
		protected float m_Gravity = new float();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(3295092963)]
		public float Gravity { get { return m_Gravity; } set { if (OnPropertyChanging("GravityData." + nameof(Gravity), this, m_Gravity, value)) m_Gravity = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3295092963:
					Gravity = (float) p_Value;
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
				case 3295092963:
					return Gravity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3295092963:
					return typeof(GravityData).GetProperty(nameof(Gravity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
