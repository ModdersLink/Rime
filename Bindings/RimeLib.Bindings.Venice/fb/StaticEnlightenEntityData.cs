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
	[ContainerType(4, 32)]
	public class StaticEnlightenEntityData : 
		EnlightenEntityData
	{
		[ContainerField(24)]
		public CtrRef<StaticEnlightenData> EnlightenData { get; set; } = new();

		[ContainerField(28)]
		public CtrRef<EnlightenDataAsset> DynamicEnlightenData { get; set; } = new();

	}
}
