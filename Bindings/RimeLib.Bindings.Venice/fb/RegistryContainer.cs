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
	[ContainerType(4, 24)]
	public class RegistryContainer : 
		DataContainer
	{
		[ContainerField(8)]
		public RefArray<DataContainer> EntityRegistry { get; set; } = new();

		[ContainerField(12)]
		public RefArray<DataContainer> AssetRegistry { get; set; } = new();

		[ContainerField(16)]
		public RefArray<DataContainer> BlueprintRegistry { get; set; } = new();

		[ContainerField(20)]
		public RefArray<DataContainer> ReferenceObjectRegistry { get; set; } = new();

	}
}
