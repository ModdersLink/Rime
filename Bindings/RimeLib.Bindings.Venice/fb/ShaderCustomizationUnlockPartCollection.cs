///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 20)]
	public class ShaderCustomizationUnlockPartCollection : 
		DataContainer
	{
		[ContainerField(8)]
		public RefArray<ObjectBlueprint> MeshBlueprints { get; set; } = new();

		[ContainerField(12), LayoutImmutable]
		public string ShaderNodeName { get; set; } = string.Empty;

		[ContainerField(16)]
		public List<CustomizedMeshMaterialsData> MeshMaterials { get; set; } = new();

	}
}
