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
	public class UrgencyUserData : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<UrgencyUserData> Base { get; set; } = new();

		[ContainerField(12)]
		public List<UrgencyModifierData> UrgencyModifiers { get; set; } = new();

		[ContainerField(16)]
		public RefArray<UrgencySetData> ModifierSets { get; set; } = new();

	}
}
