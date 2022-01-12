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
	[ContainerType(4, 88)]
	public class UICompassDataBinding : 
		UIDataBinding
	{
		[ContainerField(8)]
		public UIDataSourceInfo Heading { get; set; } = new();

		[ContainerField(24)]
		public UIDataSourceInfo Objectives { get; set; } = new();

		[ContainerField(40)]
		public UIDataSourceInfo Visibility { get; set; } = new();

		[ContainerField(56)]
		public UIDataSourceInfo ShowAirRadar { get; set; } = new();

		[ContainerField(72)]
		public UIDataSourceInfo RadarSweepDegree { get; set; } = new();

	}
}
