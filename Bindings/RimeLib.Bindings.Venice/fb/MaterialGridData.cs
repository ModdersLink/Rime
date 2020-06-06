///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MaterialGridData : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<MaterialContainerPair> DefaultMaterial { get; set; } = new CtrRef<MaterialContainerPair>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<MaterialContainerPair> MaterialPairs { get; set; } = new RefArray<MaterialContainerPair>(); // 0x10 (16)
		
		[ContainerField(20)]
		public List<uint> MaterialIndexMap { get; set; } = new List<uint>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint DefaultMaterialIndex { get; set; } // 0x18 (24)
		
		[ContainerField(28)]
		public List<MaterialRelationPropertyPair> MaterialProperties { get; set; } = new List<MaterialRelationPropertyPair>(); // 0x1C (28)
		
		[ContainerField(32)]
		public List<MaterialInteractionGridRow> InteractionGrid { get; set; } = new List<MaterialInteractionGridRow>(); // 0x20 (32)
		
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
