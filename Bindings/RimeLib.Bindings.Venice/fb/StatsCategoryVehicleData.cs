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
	public class StatsCategoryVehicleData : 
		StatsCategoryGuidData
	{
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint FirstVehicleId { get; set; }

		public static void Deserialize(StatsCategoryVehicleData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.FirstVehicleId = p_Reader.ReadUInt32();
		}

	}
}
