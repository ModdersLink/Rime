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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class EnlightenPipelineTerrain : 
		Asset
	{
		protected List<EnlightenPipelineTerrainMesh> m_Meshes = new List<EnlightenPipelineTerrainMesh>();
		[ContainerField(Name: "Meshes", Offset: 12, NameHash: 2648066496, Flags: 65)]
		public List<EnlightenPipelineTerrainMesh> Meshes { get { return m_Meshes; } set { if (OnPropertyChanging("EnlightenPipelineTerrain." + nameof(Meshes), this, m_Meshes, value)) m_Meshes = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2648066496:
					Meshes = (List<EnlightenPipelineTerrainMesh>) p_Value;
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
				case 2648066496:
					return Meshes;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2648066496:
					return typeof(EnlightenPipelineTerrain).GetProperty(nameof(Meshes));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
