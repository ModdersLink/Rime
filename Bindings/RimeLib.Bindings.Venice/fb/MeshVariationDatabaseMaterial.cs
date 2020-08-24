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
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class MeshVariationDatabaseMaterial : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<MeshMaterial> Material { get; set; } = new CtrRef<MeshMaterial>(); // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<MeshMaterialVariation> MaterialVariation { get; set; } = new CtrRef<MeshMaterialVariation>(); // 0x4 (4)
		
		[ContainerField(8), MemberInfoFlag(65), ContainerArray]
		public List<TextureShaderParameter> TextureParameters { get; set; } = new List<TextureShaderParameter>(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 845639918:
					Material = (CtrRef<MeshMaterial>) p_Value;
					break;

				case 3711459359:
					MaterialVariation = (CtrRef<MeshMaterialVariation>) p_Value;
					break;

				case 2131743936:
					TextureParameters = (List<TextureShaderParameter>) p_Value;
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
				case 845639918:
					return Material;

				case 3711459359:
					return MaterialVariation;

				case 2131743936:
					return TextureParameters;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 845639918:
					return typeof(MeshVariationDatabaseMaterial).GetProperty(nameof(Material));

				case 3711459359:
					return typeof(MeshVariationDatabaseMaterial).GetProperty(nameof(MaterialVariation));

				case 2131743936:
					return typeof(MeshVariationDatabaseMaterial).GetProperty(nameof(TextureParameters));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
