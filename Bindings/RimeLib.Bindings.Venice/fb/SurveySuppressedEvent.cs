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
	public class SurveySuppressedEvent : 
		MetricEvent
	{
		protected string m_SuppressReason = new string();
		[ContainerField(16), LayoutImmutable, ContainerFieldNameHash(422620368)]
		public string SuppressReason { get { return m_SuppressReason; } set { if (OnPropertyChanging("SurveySuppressedEvent." + nameof(SuppressReason), this, m_SuppressReason, value)) m_SuppressReason = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 422620368:
					SuppressReason = (string) p_Value;
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
				case 422620368:
					return SuppressReason;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 422620368:
					return typeof(SurveySuppressedEvent).GetProperty(nameof(SuppressReason));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
