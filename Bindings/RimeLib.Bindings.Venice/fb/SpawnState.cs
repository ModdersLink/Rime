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
	[ContainerType(8, 32)]
	public class SpawnState : 
		MetricState
	{
		[ContainerField(24), LayoutImmutable, Blittable]
		public int Team { get; set; }

		public static void Deserialize(SpawnState p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Team = p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
