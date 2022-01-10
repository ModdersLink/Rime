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
	public class WaypointData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int SchematicsNameHash { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public ushort WaypointId { get; set; }

		[ContainerField(14), LayoutImmutable, Blittable]
		public bool UseClientsPosition { get; set; }

		public static void Deserialize(WaypointData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SchematicsNameHash = p_Reader.ReadInt32();
			p_Instance.WaypointId = p_Reader.ReadUInt16();
			p_Instance.UseClientsPosition = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
