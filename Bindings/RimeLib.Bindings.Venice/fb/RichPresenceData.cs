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
	public class RichPresenceData : 
		Asset
	{
		[ContainerField(12)]
		public RefArray<RichPresencePresenceString> PresenceModes { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<RichPresencePresenceString> DefaultMode { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<RichPresencePresenceString> InactiveMode { get; set; } = new();

		[ContainerField(24)]
		public RefArray<RichPresenceContext> Contexts { get; set; } = new();

		[ContainerField(28)]
		public List<RichPresenceProperty> Properties { get; set; } = new();

	}
}
