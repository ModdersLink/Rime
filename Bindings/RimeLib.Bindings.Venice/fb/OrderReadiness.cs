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
	[ContainerType(4, 28)]
	public class OrderReadiness : 
		UrgencyUserData
	{
		[ContainerField(20), LayoutImmutable]
		public string OrderType { get; set; } = string.Empty;

		[ContainerField(24)]
		public ReadinessState MinimumReadiness { get; set; } = new();

	}
}
