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
	public class UIEventAsset : 
		Asset
	{
		protected string m_Category = string.Empty;
		[ContainerField(12), LayoutImmutable, ContainerFieldNameHash(3455858997)]
		public string Category { get { return m_Category; } set { if (OnPropertyChanging("UIEventAsset." + nameof(Category), this, m_Category, value)) m_Category = value; } } // 0xC (12)
		
		protected List<string> m_EventList = new List<string>();
		[ContainerField(16), ContainerFieldNameHash(4132327979)]
		public List<string> EventList { get { return m_EventList; } set { if (OnPropertyChanging("UIEventAsset." + nameof(EventList), this, m_EventList, value)) m_EventList = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3455858997:
					Category = (string) p_Value;
					break;

				case 4132327979:
					EventList = (List<string>) p_Value;
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
				case 3455858997:
					return Category;

				case 4132327979:
					return EventList;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3455858997:
					return typeof(UIEventAsset).GetProperty(nameof(Category));

				case 4132327979:
					return typeof(UIEventAsset).GetProperty(nameof(EventList));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
