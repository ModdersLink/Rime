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
	[ContainerType(4, 20)]
	public class SoldierWeaponMultiUnlock : 
		UnlockUserDataBase
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<UnlockAssetBase> First { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<UnlockAssetPair> UnlockAssetPairs { get; set; } = new();

	}
}
