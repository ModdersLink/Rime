///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class OrderReadiness : 
		UrgencyUserData
	{
		[ContainerField(20), LayoutImmutable]
		public string OrderType { get; set; } // 0x14 (20)
		
		[ContainerField(24)]
		public ReadinessState MinimumReadiness { get; set; } = new ReadinessState(); // 0x18 (24)
		
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
