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
	public class SoundTestTaskSpec : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Description { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable, Blittable]
		public float Duration { get; set; }

		public static void Deserialize(SoundTestTaskSpec p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Description = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Duration = p_Reader.ReadSingle();
		}

	}
}
