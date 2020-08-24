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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class OrderSettings : 
		Asset
	{
		protected RefArray<OrderReadiness> m_Orders = new RefArray<OrderReadiness>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(2885972376), ContainerRefArray]
		public RefArray<OrderReadiness> Orders { get { return m_Orders; } set { if (OnPropertyChanging("OrderSettings." + nameof(Orders), this, m_Orders, value)) m_Orders = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2885972376:
					Orders = (RefArray<OrderReadiness>) p_Value;
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
				case 2885972376:
					return Orders;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2885972376:
					return typeof(OrderSettings).GetProperty(nameof(Orders));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
