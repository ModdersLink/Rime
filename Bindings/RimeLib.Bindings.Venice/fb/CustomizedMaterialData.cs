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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class CustomizedMaterialData : 
		DataContainer
	{
		protected List<string> m_MaterialNames = new List<string>();
		[ContainerField(Name: "MaterialNames", Offset: 8, NameHash: 990812474, Flags: 65)]
		public List<string> MaterialNames { get { return m_MaterialNames; } set { if (OnPropertyChanging("CustomizedMaterialData." + nameof(MaterialNames), this, m_MaterialNames, value)) m_MaterialNames = value; } } // 0x8 (8)
		
		protected RefArray<UnlockableColorCollection> m_ColorParameters = new RefArray<UnlockableColorCollection>();
		[ContainerField(Name: "ColorParameters", Offset: 12, NameHash: 3601242530, Flags: 65)]
		public RefArray<UnlockableColorCollection> ColorParameters { get { return m_ColorParameters; } set { if (OnPropertyChanging("CustomizedMaterialData." + nameof(ColorParameters), this, m_ColorParameters, value)) m_ColorParameters = value; } } // 0xC (12)
		
		protected RefArray<UnlockableTextureCollection> m_TextureParameters = new RefArray<UnlockableTextureCollection>();
		[ContainerField(Name: "TextureParameters", Offset: 16, NameHash: 2131743936, Flags: 65)]
		public RefArray<UnlockableTextureCollection> TextureParameters { get { return m_TextureParameters; } set { if (OnPropertyChanging("CustomizedMaterialData." + nameof(TextureParameters), this, m_TextureParameters, value)) m_TextureParameters = value; } } // 0x10 (16)
		
		protected RefArray<UnlockableTextureSliceCollection> m_TextureSliceParameters = new RefArray<UnlockableTextureSliceCollection>();
		[ContainerField(Name: "TextureSliceParameters", Offset: 20, NameHash: 2207841840, Flags: 65)]
		public RefArray<UnlockableTextureSliceCollection> TextureSliceParameters { get { return m_TextureSliceParameters; } set { if (OnPropertyChanging("CustomizedMaterialData." + nameof(TextureSliceParameters), this, m_TextureSliceParameters, value)) m_TextureSliceParameters = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 990812474:
					MaterialNames = (List<string>) p_Value;
					break;

				case 3601242530:
					ColorParameters = (RefArray<UnlockableColorCollection>) p_Value;
					break;

				case 2131743936:
					TextureParameters = (RefArray<UnlockableTextureCollection>) p_Value;
					break;

				case 2207841840:
					TextureSliceParameters = (RefArray<UnlockableTextureSliceCollection>) p_Value;
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
				case 990812474:
					return MaterialNames;

				case 3601242530:
					return ColorParameters;

				case 2131743936:
					return TextureParameters;

				case 2207841840:
					return TextureSliceParameters;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 990812474:
					return typeof(CustomizedMaterialData).GetProperty(nameof(MaterialNames));

				case 3601242530:
					return typeof(CustomizedMaterialData).GetProperty(nameof(ColorParameters));

				case 2131743936:
					return typeof(CustomizedMaterialData).GetProperty(nameof(TextureParameters));

				case 2207841840:
					return typeof(CustomizedMaterialData).GetProperty(nameof(TextureSliceParameters));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
