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
	public class AudioGraphNodePort
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float UnconnectedValue { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public ushort ValueIndex { get; set; }
		
		[ContainerField(6), LayoutImmutable, Blittable]
		public bool IsConnected { get; set; }
		
		public static void Deserialize(AudioGraphNodePort p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.UnconnectedValue = p_Reader.ReadSingle();
			p_Instance.ValueIndex = p_Reader.ReadUInt16();
			p_Instance.IsConnected = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}
	}
}
