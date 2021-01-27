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
	[ContainerType(Alignment: 8,  Flags: 53, Size: 32)]
	public class KitState : 
		MetricState
	{
		protected string m_Kit = string.Empty;
		[ContainerField(Name: "Kit", Offset: 24, NameHash: 193457363, Flags: 16509), LayoutImmutable]
		public string Kit { get { return m_Kit; } set { if (OnPropertyChanging("KitState." + nameof(Kit), this, m_Kit, value)) m_Kit = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193457363:
					Kit = (string) p_Value;
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
				case 193457363:
					return Kit;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193457363:
					return typeof(KitState).GetProperty(nameof(Kit));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
