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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class UICreditsAsset : 
		Asset
	{
		protected List<UICreditsPage> m_Pages = new List<UICreditsPage>();
		[ContainerField(Name: "Pages", Offset: 12, NameHash: 232331173, Flags: 65)]
		public List<UICreditsPage> Pages { get { return m_Pages; } set { if (OnPropertyChanging("UICreditsAsset." + nameof(Pages), this, m_Pages, value)) m_Pages = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 232331173:
					Pages = (List<UICreditsPage>) p_Value;
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
				case 232331173:
					return Pages;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 232331173:
					return typeof(UICreditsAsset).GetProperty(nameof(Pages));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
