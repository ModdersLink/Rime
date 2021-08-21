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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 40)]
	public class LevelDescriptionAsset : 
		Asset
	{
		protected string m_LevelName = string.Empty;
		[ContainerField(Name: "LevelName", Offset: 12, NameHash: 1599082292, Flags: 16509), LayoutImmutable]
		public string LevelName { get { return m_LevelName; } set { if (OnPropertyChanging("LevelDescriptionAsset." + nameof(LevelName), this, m_LevelName, value)) m_LevelName = value; } } // 0xC (12)
		
		protected List<LevelDescriptionInclusionCategory> m_Categories = new List<LevelDescriptionInclusionCategory>();
		[ContainerField(Name: "Categories", Offset: 16, NameHash: 1039077843, Flags: 65)]
		public List<LevelDescriptionInclusionCategory> Categories { get { return m_Categories; } set { if (OnPropertyChanging("LevelDescriptionAsset." + nameof(Categories), this, m_Categories, value)) m_Categories = value; } } // 0x10 (16)
		
		protected LevelDescription m_Description = new LevelDescription();
		[ContainerField(Name: "Description", Offset: 20, NameHash: 1636673251, Flags: 41)]
		public LevelDescription Description { get { return m_Description; } set { if (OnPropertyChanging("LevelDescriptionAsset." + nameof(Description), this, m_Description, value)) m_Description = value; } } // 0x14 (20)
		
		protected List<string> m_StartPoints = new List<string>();
		[ContainerField(Name: "StartPoints", Offset: 36, NameHash: 748137786, Flags: 65)]
		public List<string> StartPoints { get { return m_StartPoints; } set { if (OnPropertyChanging("LevelDescriptionAsset." + nameof(StartPoints), this, m_StartPoints, value)) m_StartPoints = value; } } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1599082292:
					LevelName = (string) p_Value;
					break;

				case 1039077843:
					Categories = (List<LevelDescriptionInclusionCategory>) p_Value;
					break;

				case 1636673251:
					Description = (LevelDescription) p_Value;
					break;

				case 748137786:
					StartPoints = (List<string>) p_Value;
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
				case 1599082292:
					return LevelName;

				case 1039077843:
					return Categories;

				case 1636673251:
					return Description;

				case 748137786:
					return StartPoints;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1599082292:
					return typeof(LevelDescriptionAsset).GetProperty(nameof(LevelName));

				case 1039077843:
					return typeof(LevelDescriptionAsset).GetProperty(nameof(Categories));

				case 1636673251:
					return typeof(LevelDescriptionAsset).GetProperty(nameof(Description));

				case 748137786:
					return typeof(LevelDescriptionAsset).GetProperty(nameof(StartPoints));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
