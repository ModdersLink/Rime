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
	[ContainerType(4, 16)]
	public class CustomSequenceTrackPropertyMapping : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int TrackPropertyID { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public int SequencePropertyID { get; set; }

		public static void Deserialize(CustomSequenceTrackPropertyMapping p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TrackPropertyID = p_Reader.ReadInt32();
			p_Instance.SequencePropertyID = p_Reader.ReadInt32();
		}

	}
}
