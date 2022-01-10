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
	public class SoldierAimingConstraintsData : 
		DataContainer
	{
		[ContainerField(8)]
		public AimingConstraintsData SwimmingConstraints { get; set; } = new();

		public static void Deserialize(SoldierAimingConstraintsData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AimingConstraintsData.Deserialize(p_Instance.SwimmingConstraints, p_Reader, p_Parser);
		}

	}
}
