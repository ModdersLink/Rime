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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class UIPartPropertyList : 
		DataContainer
	{
		protected List<UIPartProperties> m_HudPropertyList = new List<UIPartProperties>();
		[ContainerField(Name: "HudPropertyList", Offset: 8, NameHash: 3433890873, Flags: 65)]
		public List<UIPartProperties> HudPropertyList { get { return m_HudPropertyList; } set { if (OnPropertyChanging("UIPartPropertyList." + nameof(HudPropertyList), this, m_HudPropertyList, value)) m_HudPropertyList = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3433890873:
					HudPropertyList = (List<UIPartProperties>) p_Value;
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
				case 3433890873:
					return HudPropertyList;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3433890873:
					return typeof(UIPartPropertyList).GetProperty(nameof(HudPropertyList));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
