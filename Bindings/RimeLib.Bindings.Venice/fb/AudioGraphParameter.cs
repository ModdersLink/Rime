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
	[ContainerType(4, 20)]
	public class AudioGraphParameter : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float DefaultValue { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public uint NameHash { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public ushort ValueIndex { get; set; }

		public static void Deserialize(AudioGraphParameter p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DefaultValue = p_Reader.ReadSingle();
			p_Instance.NameHash = p_Reader.ReadUInt32();
			p_Instance.ValueIndex = p_Reader.ReadUInt16();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
