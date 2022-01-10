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
	[ContainerType(4, 36)]
	public class GeographicalData : 
		DataContainer
	{
		[ContainerField(8)]
		public UIGeoLatitude Latitude { get; set; } = new();

		[ContainerField(20)]
		public UIGeoLongitude Longitude { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public float SeaLevelOffset { get; set; }

		public static void Deserialize(GeographicalData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.UIGeoLatitude.Deserialize(p_Instance.Latitude, p_Reader, p_Parser);
			fb.UIGeoLongitude.Deserialize(p_Instance.Longitude, p_Reader, p_Parser);
			p_Instance.SeaLevelOffset = p_Reader.ReadSingle();
		}

	}
}
