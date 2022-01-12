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
	[ContainerType(4, 44)]
	public class TimingConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float UpdateTimePerFrame { get; set; }

		[ContainerField(16)]
		public SubsystemTimingConfigData SubsystemTimeParts { get; set; } = new();

		[ContainerField(40)]
		public RefArray<BotPriorityConfigData> PriorityClasses { get; set; } = new();

	}
}
