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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class UIOnDemandFontComponentData : 
		UIComponentData
	{
		protected RefArray<UIFontCollection> m_FontCollections = new RefArray<UIFontCollection>();
		[ContainerField(Name: "FontCollections", Offset: 28, NameHash: 2744963667, Flags: 65)]
		public RefArray<UIFontCollection> FontCollections { get { return m_FontCollections; } set { if (OnPropertyChanging("UIOnDemandFontComponentData." + nameof(FontCollections), this, m_FontCollections, value)) m_FontCollections = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2744963667:
					FontCollections = (RefArray<UIFontCollection>) p_Value;
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
				case 2744963667:
					return FontCollections;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2744963667:
					return typeof(UIOnDemandFontComponentData).GetProperty(nameof(FontCollections));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
