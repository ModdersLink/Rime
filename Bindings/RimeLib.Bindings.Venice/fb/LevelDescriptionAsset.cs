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
	public class LevelDescriptionAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string LevelName { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public List<LevelDescriptionInclusionCategory> Categories { get; set; } = new List<LevelDescriptionInclusionCategory>(); // 0x10 (16)
		
		[ContainerField(20)]
		public LevelDescription Description { get; set; } = new LevelDescription(); // 0x14 (20)
		
		[ContainerField(36)]
		public List<string> StartPoints { get; set; } = new List<string>(); // 0x24 (36)
		
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
