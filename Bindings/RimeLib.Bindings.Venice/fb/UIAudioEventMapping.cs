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
	[ContainerType(4, 8)]
	public class UIAudioEventMapping
	{
		[ContainerField(0), LayoutImmutable]
		public string EventName { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public CtrRef<SoundAsset> SoundAsset { get; set; } = new();
		
	}
}
