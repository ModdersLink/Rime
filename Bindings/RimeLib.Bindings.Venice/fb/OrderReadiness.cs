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
	public class OrderReadiness : 
		UrgencyUserData
	{
		protected string m_OrderType = new string();
		[ContainerField(20), LayoutImmutable, ContainerFieldNameHash(2615460339)]
		public string OrderType { get { return m_OrderType; } set { if (OnPropertyChanging("OrderReadiness." + nameof(OrderType), this, m_OrderType, value)) m_OrderType = value; } } // 0x14 (20)
		
		protected ReadinessState m_MinimumReadiness = new ReadinessState();
		[ContainerField(24), ContainerFieldNameHash(3511254371)]
		public ReadinessState MinimumReadiness { get { return m_MinimumReadiness; } set { if (OnPropertyChanging("OrderReadiness." + nameof(MinimumReadiness), this, m_MinimumReadiness, value)) m_MinimumReadiness = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2615460339:
					OrderType = (string) p_Value;
					break;

				case 3511254371:
					MinimumReadiness = (ReadinessState) Enum.ToObject(typeof(ReadinessState), p_Value);
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
				case 2615460339:
					return OrderType;

				case 3511254371:
					return MinimumReadiness;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2615460339:
					return typeof(OrderReadiness).GetProperty(nameof(OrderType));

				case 3511254371:
					return typeof(OrderReadiness).GetProperty(nameof(MinimumReadiness));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
