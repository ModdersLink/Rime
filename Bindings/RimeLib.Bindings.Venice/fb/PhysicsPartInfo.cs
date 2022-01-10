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
	[ContainerType(4, 8)]
	public class PhysicsPartInfo
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public uint PartComponentIndex { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public uint HealthStateIndex { get; set; }
		
		public static void Deserialize(PhysicsPartInfo p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PartComponentIndex = p_Reader.ReadUInt32();
			p_Instance.HealthStateIndex = p_Reader.ReadUInt32();
		}
	}
}
