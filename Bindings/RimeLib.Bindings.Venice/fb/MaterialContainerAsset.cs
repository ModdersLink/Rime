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
	public class MaterialContainerAsset : 
		Asset
	{
		[ContainerField(12)]
		public RefArray<MaterialContainerPair> MaterialPairs { get; set; } = new RefArray<MaterialContainerPair>(); // 0xC (12)
		
		[ContainerField(16)]
		public List<string> MaterialNames { get; set; } = new List<string>(); // 0x10 (16)
		
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
