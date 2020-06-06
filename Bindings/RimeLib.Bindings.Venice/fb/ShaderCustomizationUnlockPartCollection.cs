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
	public class ShaderCustomizationUnlockPartCollection : 
		DataContainer
	{
		[ContainerField(8)]
		public RefArray<ObjectBlueprint> MeshBlueprints { get; set; } = new RefArray<ObjectBlueprint>(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable]
		public string ShaderNodeName { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public List<CustomizedMeshMaterialsData> MeshMaterials { get; set; } = new List<CustomizedMeshMaterialsData>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3317903690:
					MeshBlueprints = (RefArray<ObjectBlueprint>) p_Value;
					break;

				case 4213969131:
					ShaderNodeName = (string) p_Value;
					break;

				case 3833968526:
					MeshMaterials = (List<CustomizedMeshMaterialsData>) p_Value;
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
				case 3317903690:
					return MeshBlueprints;

				case 4213969131:
					return ShaderNodeName;

				case 3833968526:
					return MeshMaterials;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3317903690:
					return typeof(ShaderCustomizationUnlockPartCollection).GetProperty(nameof(MeshBlueprints));

				case 4213969131:
					return typeof(ShaderCustomizationUnlockPartCollection).GetProperty(nameof(ShaderNodeName));

				case 3833968526:
					return typeof(ShaderCustomizationUnlockPartCollection).GetProperty(nameof(MeshMaterials));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
