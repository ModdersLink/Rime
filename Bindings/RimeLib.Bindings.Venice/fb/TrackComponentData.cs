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
	[ContainerType(16, 128)]
	public class TrackComponentData : 
		MeshComponentData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public float ScrollFactor { get; set; }

		public static void Deserialize(TrackComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ScrollFactor = p_Reader.ReadSingle();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
