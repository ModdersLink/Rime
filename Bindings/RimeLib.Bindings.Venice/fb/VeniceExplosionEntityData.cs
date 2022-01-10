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
	[ContainerType(16, 192)]
	public class VeniceExplosionEntityData : 
		ExplosionEntityData
	{
		[ContainerField(176), LayoutImmutable, Blittable]
		public float UnspottableTime { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public bool UnspotsOnExplode { get; set; }

		[ContainerField(181), LayoutImmutable, Blittable]
		public bool SpotsOnExplode { get; set; }

		[ContainerField(182), LayoutImmutable, Blittable]
		public bool IsCausingSuppression { get; set; }

		public static void Deserialize(VeniceExplosionEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.UnspottableTime = p_Reader.ReadSingle();
			p_Instance.UnspotsOnExplode = p_Reader.ReadBool();
			p_Instance.SpotsOnExplode = p_Reader.ReadBool();
			p_Instance.IsCausingSuppression = p_Reader.ReadBool();
			p_Reader.Seek(9, SeekOrigin.Current);
		}

	}
}
