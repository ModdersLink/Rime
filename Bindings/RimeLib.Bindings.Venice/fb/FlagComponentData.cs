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
	[ContainerType(16, 112)]
	public class FlagComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public Realm Realm { get; set; } = new();

		[ContainerField(100)]
		public CtrRef<ObjectBlueprint> Flag_Team1 { get; set; } = new();

		[ContainerField(104)]
		public CtrRef<ObjectBlueprint> Flag_Team2 { get; set; } = new();

	}
}
