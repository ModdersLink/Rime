///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 36)]
	public class MaterialGridData : 
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<MaterialContainerPair> DefaultMaterial { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<MaterialContainerPair> MaterialPairs { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public List<uint> MaterialIndexMap { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint DefaultMaterialIndex { get; set; }

		[ContainerField(28), JsonProperty(Order = 28)]
		public List<MaterialRelationPropertyPair> MaterialProperties { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public List<MaterialInteractionGridRow> InteractionGrid { get; set; } = new();

	}
}
