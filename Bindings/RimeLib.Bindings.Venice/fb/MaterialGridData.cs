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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 36)]
	public class MaterialGridData : 
		Asset
	{
		protected CtrRef<MaterialContainerPair> m_DefaultMaterial = new CtrRef<MaterialContainerPair>();
		[ContainerField(Name: "DefaultMaterial", Offset: 12, NameHash: 1956671429, Flags: 53)]
		public CtrRef<MaterialContainerPair> DefaultMaterial { get { return m_DefaultMaterial; } set { if (OnPropertyChanging("MaterialGridData." + nameof(DefaultMaterial), this, m_DefaultMaterial, value)) m_DefaultMaterial = value; } } // 0xC (12)
		
		protected RefArray<MaterialContainerPair> m_MaterialPairs = new RefArray<MaterialContainerPair>();
		[ContainerField(Name: "MaterialPairs", Offset: 16, NameHash: 1030971927, Flags: 65)]
		public RefArray<MaterialContainerPair> MaterialPairs { get { return m_MaterialPairs; } set { if (OnPropertyChanging("MaterialGridData." + nameof(MaterialPairs), this, m_MaterialPairs, value)) m_MaterialPairs = value; } } // 0x10 (16)
		
		protected List<uint> m_MaterialIndexMap = new List<uint>();
		[ContainerField(Name: "MaterialIndexMap", Offset: 20, NameHash: 3087328300, Flags: 65)]
		public List<uint> MaterialIndexMap { get { return m_MaterialIndexMap; } set { if (OnPropertyChanging("MaterialGridData." + nameof(MaterialIndexMap), this, m_MaterialIndexMap, value)) m_MaterialIndexMap = value; } } // 0x14 (20)
		
		protected uint m_DefaultMaterialIndex = new uint();
		[ContainerField(Name: "DefaultMaterialIndex", Offset: 24, NameHash: 214719451, Flags: 49421), LayoutImmutable, Blittable]
		public uint DefaultMaterialIndex { get { return m_DefaultMaterialIndex; } set { if (OnPropertyChanging("MaterialGridData." + nameof(DefaultMaterialIndex), this, m_DefaultMaterialIndex, value)) m_DefaultMaterialIndex = value; } } // 0x18 (24)
		
		protected List<MaterialRelationPropertyPair> m_MaterialProperties = new List<MaterialRelationPropertyPair>();
		[ContainerField(Name: "MaterialProperties", Offset: 28, NameHash: 1479818927, Flags: 65)]
		public List<MaterialRelationPropertyPair> MaterialProperties { get { return m_MaterialProperties; } set { if (OnPropertyChanging("MaterialGridData." + nameof(MaterialProperties), this, m_MaterialProperties, value)) m_MaterialProperties = value; } } // 0x1C (28)
		
		protected List<MaterialInteractionGridRow> m_InteractionGrid = new List<MaterialInteractionGridRow>();
		[ContainerField(Name: "InteractionGrid", Offset: 32, NameHash: 691097959, Flags: 65)]
		public List<MaterialInteractionGridRow> InteractionGrid { get { return m_InteractionGrid; } set { if (OnPropertyChanging("MaterialGridData." + nameof(InteractionGrid), this, m_InteractionGrid, value)) m_InteractionGrid = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1956671429:
					DefaultMaterial = (CtrRef<MaterialContainerPair>) p_Value;
					break;

				case 1030971927:
					MaterialPairs = (RefArray<MaterialContainerPair>) p_Value;
					break;

				case 3087328300:
					MaterialIndexMap = (List<uint>) p_Value;
					break;

				case 214719451:
					DefaultMaterialIndex = (uint) p_Value;
					break;

				case 1479818927:
					MaterialProperties = (List<MaterialRelationPropertyPair>) p_Value;
					break;

				case 691097959:
					InteractionGrid = (List<MaterialInteractionGridRow>) p_Value;
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
				case 1956671429:
					return DefaultMaterial;

				case 1030971927:
					return MaterialPairs;

				case 3087328300:
					return MaterialIndexMap;

				case 214719451:
					return DefaultMaterialIndex;

				case 1479818927:
					return MaterialProperties;

				case 691097959:
					return InteractionGrid;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1956671429:
					return typeof(MaterialGridData).GetProperty(nameof(DefaultMaterial));

				case 1030971927:
					return typeof(MaterialGridData).GetProperty(nameof(MaterialPairs));

				case 3087328300:
					return typeof(MaterialGridData).GetProperty(nameof(MaterialIndexMap));

				case 214719451:
					return typeof(MaterialGridData).GetProperty(nameof(DefaultMaterialIndex));

				case 1479818927:
					return typeof(MaterialGridData).GetProperty(nameof(MaterialProperties));

				case 691097959:
					return typeof(MaterialGridData).GetProperty(nameof(InteractionGrid));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
