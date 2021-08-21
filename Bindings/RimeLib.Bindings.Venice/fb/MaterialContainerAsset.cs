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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class MaterialContainerAsset : 
		Asset
	{
		protected RefArray<MaterialContainerPair> m_MaterialPairs = new RefArray<MaterialContainerPair>();
		[ContainerField(Name: "MaterialPairs", Offset: 12, NameHash: 1030971927, Flags: 65)]
		public RefArray<MaterialContainerPair> MaterialPairs { get { return m_MaterialPairs; } set { if (OnPropertyChanging("MaterialContainerAsset." + nameof(MaterialPairs), this, m_MaterialPairs, value)) m_MaterialPairs = value; } } // 0xC (12)
		
		protected List<string> m_MaterialNames = new List<string>();
		[ContainerField(Name: "MaterialNames", Offset: 16, NameHash: 990812474, Flags: 65)]
		public List<string> MaterialNames { get { return m_MaterialNames; } set { if (OnPropertyChanging("MaterialContainerAsset." + nameof(MaterialNames), this, m_MaterialNames, value)) m_MaterialNames = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1030971927:
					MaterialPairs = (RefArray<MaterialContainerPair>) p_Value;
					break;

				case 990812474:
					MaterialNames = (List<string>) p_Value;
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
				case 1030971927:
					return MaterialPairs;

				case 990812474:
					return MaterialNames;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1030971927:
					return typeof(MaterialContainerAsset).GetProperty(nameof(MaterialPairs));

				case 990812474:
					return typeof(MaterialContainerAsset).GetProperty(nameof(MaterialNames));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
