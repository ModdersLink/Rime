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
	[ContainerType(4)]
	public class ShaderCustomizationUnlockPartCollection : 
		DataContainer
	{
		protected RefArray<ObjectBlueprint> m_MeshBlueprints = new RefArray<ObjectBlueprint>();
		[ContainerField(8), ContainerFieldNameHash(3317903690)]
		public RefArray<ObjectBlueprint> MeshBlueprints { get { return m_MeshBlueprints; } set { if (OnPropertyChanging("ShaderCustomizationUnlockPartCollection." + nameof(MeshBlueprints), this, m_MeshBlueprints, value)) m_MeshBlueprints = value; } } // 0x8 (8)
		
		protected string m_ShaderNodeName = string.Empty;
		[ContainerField(12), LayoutImmutable, ContainerFieldNameHash(4213969131)]
		public string ShaderNodeName { get { return m_ShaderNodeName; } set { if (OnPropertyChanging("ShaderCustomizationUnlockPartCollection." + nameof(ShaderNodeName), this, m_ShaderNodeName, value)) m_ShaderNodeName = value; } } // 0xC (12)
		
		protected List<CustomizedMeshMaterialsData> m_MeshMaterials = new List<CustomizedMeshMaterialsData>();
		[ContainerField(16), ContainerFieldNameHash(3833968526)]
		public List<CustomizedMeshMaterialsData> MeshMaterials { get { return m_MeshMaterials; } set { if (OnPropertyChanging("ShaderCustomizationUnlockPartCollection." + nameof(MeshMaterials), this, m_MeshMaterials, value)) m_MeshMaterials = value; } } // 0x10 (16)
		
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
