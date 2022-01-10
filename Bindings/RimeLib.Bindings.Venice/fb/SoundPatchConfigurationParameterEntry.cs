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
	public class SoundPatchConfigurationParameterEntry : 
		SoundPatchConfigurationEntry
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint NameHash { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float Value { get; set; }

		public static void Deserialize(SoundPatchConfigurationParameterEntry p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.NameHash = p_Reader.ReadUInt32();
			p_Instance.Value = p_Reader.ReadSingle();
		}

	}
}
