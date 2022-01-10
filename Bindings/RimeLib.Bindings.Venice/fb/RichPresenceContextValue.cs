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
	public class RichPresenceContextValue : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string SID { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable, Blittable]
		public sbyte Index { get; set; }

		public static void Deserialize(RichPresenceContextValue p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SID = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Index = p_Reader.ReadSByte();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
