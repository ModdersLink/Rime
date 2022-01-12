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
	public class VoiceOverEvent : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12)]
		public RefArray<VoiceOverNamedValue> Parameters { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<VoiceOverLogicAsset> Owner { get; set; } = new();

	}
}
