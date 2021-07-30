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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class CustomizedMeshMaterialsData : FrostbiteContainer
	{
		[ContainerField(Name: "MeshBlueprint", Offset: 0, NameHash: 1662348825, Flags: 53)]
		public CtrRef<ObjectBlueprint> MeshBlueprint { get; set; } = new CtrRef<ObjectBlueprint>(); // 0x0 (0)
		
		[ContainerField(Name: "MaterialNames", Offset: 4, NameHash: 990812474, Flags: 65)]
		public List<string> MaterialNames { get; set; } = new List<string>(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1662348825:
					MeshBlueprint = (CtrRef<ObjectBlueprint>) p_Value;
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
				case 1662348825:
					return MeshBlueprint;

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
				case 1662348825:
					return typeof(CustomizedMeshMaterialsData).GetProperty(nameof(MeshBlueprint));

				case 990812474:
					return typeof(CustomizedMeshMaterialsData).GetProperty(nameof(MaterialNames));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
