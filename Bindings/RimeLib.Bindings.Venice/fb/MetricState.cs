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
	[ContainerType(8)]
	public class MetricState : 
		MetricEvent
	{
		protected bool m_IsSet = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(215495965)]
		public bool IsSet { get { return m_IsSet; } set { if (OnPropertyChanging("MetricState." + nameof(IsSet), this, m_IsSet, value)) m_IsSet = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 215495965:
					IsSet = (bool) p_Value;
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
				case 215495965:
					return IsSet;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 215495965:
					return typeof(MetricState).GetProperty(nameof(IsSet));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
