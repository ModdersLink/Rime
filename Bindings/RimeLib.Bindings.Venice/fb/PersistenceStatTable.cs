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
	[ContainerType(4, 16)]
	public class PersistenceStatTable : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string TableName { get; set; } = string.Empty;

		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<AbstractPersistenceData> OwnerPersistenceData { get; set; } = new();

	}
}
