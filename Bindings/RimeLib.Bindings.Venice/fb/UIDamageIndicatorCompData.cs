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
	[ContainerType(4)]
	public class UIDamageIndicatorCompData : 
		UIComponentData
	{
		protected float m_MaxUpdateTime = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(940836245)]
		public float MaxUpdateTime { get { return m_MaxUpdateTime; } set { if (OnPropertyChanging("UIDamageIndicatorCompData." + nameof(MaxUpdateTime), this, m_MaxUpdateTime, value)) m_MaxUpdateTime = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 940836245:
					MaxUpdateTime = (float) p_Value;
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
				case 940836245:
					return MaxUpdateTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 940836245:
					return typeof(UIDamageIndicatorCompData).GetProperty(nameof(MaxUpdateTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
