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
	public class CustomizedMaterialData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<string> MaterialNames { get; set; } = new List<string>(); // 0x8 (8)
		
		[ContainerField(12)]
		public RefArray<UnlockableColorCollection> ColorParameters { get; set; } = new RefArray<UnlockableColorCollection>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<UnlockableTextureCollection> TextureParameters { get; set; } = new RefArray<UnlockableTextureCollection>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<UnlockableTextureSliceCollection> TextureSliceParameters { get; set; } = new RefArray<UnlockableTextureSliceCollection>(); // 0x14 (20)
		
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
