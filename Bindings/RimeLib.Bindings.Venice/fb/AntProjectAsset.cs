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
	[ContainerType(4, 28)]
	public class AntProjectAsset : 
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<AntPackageAsset> PackageAssets { get; set; } = new();

		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string AntNativeProjectName { get; set; } = string.Empty;

		[ContainerField(20), JsonProperty(Order = 20)]
		public AntRef SceneOp { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public int ProjectId { get; set; }

	}
}
