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
	public class VoiceOverDialogClipEvents : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint StartedNameHash { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public uint FinishedNameHash { get; set; }

		public static void Deserialize(VoiceOverDialogClipEvents p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.StartedNameHash = p_Reader.ReadUInt32();
			p_Instance.FinishedNameHash = p_Reader.ReadUInt32();
		}

	}
}
