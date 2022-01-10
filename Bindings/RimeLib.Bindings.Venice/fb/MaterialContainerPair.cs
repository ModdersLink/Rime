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
	public class MaterialContainerPair : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint FlagsAndIndex { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public sbyte PhysicsPropertyIndex { get; set; }

		[ContainerField(13), LayoutImmutable, Blittable]
		public sbyte PhysicsMaterialIndex { get; set; }

		public static void Deserialize(MaterialContainerPair p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.FlagsAndIndex = p_Reader.ReadUInt32();
			p_Instance.PhysicsPropertyIndex = p_Reader.ReadSByte();
			p_Instance.PhysicsMaterialIndex = p_Reader.ReadSByte();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
