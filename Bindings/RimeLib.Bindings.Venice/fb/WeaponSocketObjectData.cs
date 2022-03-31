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
	[ContainerType(4, 24)]
	public class WeaponSocketObjectData : 
		SocketObjectDataBase
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public List<uint> ReferencedAssetHashes { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<Asset> Asset1p { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<Asset> Asset1pzoom { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<Asset> Asset3p { get; set; } = new();

	}
}
