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
	[ContainerType(16, 64)]
	public class DestructionVolumeData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public AxisAlignedBox BoundingBox { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public CtrRef<DestructionVolumeAsset> Asset { get; set; } = new();

		[ContainerField(52), JsonProperty(Order = 52)]
		public List<Vec4> Impacts { get; set; } = new();

		[ContainerField(56), JsonProperty(Order = 56)]
		public List<uint> PartToImpactIndices { get; set; } = new();

	}
}
