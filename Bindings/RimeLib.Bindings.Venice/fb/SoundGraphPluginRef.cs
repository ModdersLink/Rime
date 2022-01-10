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
	[ContainerType(1, 3)]
	public class SoundGraphPluginRef
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public bool IsValid { get; set; }
		
		[ContainerField(1), LayoutImmutable, Blittable]
		public sbyte VoiceIndex { get; set; }
		
		[ContainerField(2), LayoutImmutable, Blittable]
		public sbyte PluginIndex { get; set; }
		
		public static void Deserialize(SoundGraphPluginRef p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.IsValid = p_Reader.ReadBool();
			p_Instance.VoiceIndex = p_Reader.ReadSByte();
			p_Instance.PluginIndex = p_Reader.ReadSByte();
		}
	}
}
