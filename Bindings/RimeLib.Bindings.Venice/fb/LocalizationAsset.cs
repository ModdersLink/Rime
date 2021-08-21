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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class LocalizationAsset : 
		Asset
	{
		protected RefArray<UITextDatabase> m_LocalizedTexts = new RefArray<UITextDatabase>();
		[ContainerField(Name: "LocalizedTexts", Offset: 12, NameHash: 2715502676, Flags: 65)]
		public RefArray<UITextDatabase> LocalizedTexts { get { return m_LocalizedTexts; } set { if (OnPropertyChanging("LocalizationAsset." + nameof(LocalizedTexts), this, m_LocalizedTexts, value)) m_LocalizedTexts = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2715502676:
					LocalizedTexts = (RefArray<UITextDatabase>) p_Value;
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
				case 2715502676:
					return LocalizedTexts;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2715502676:
					return typeof(LocalizationAsset).GetProperty(nameof(LocalizedTexts));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
