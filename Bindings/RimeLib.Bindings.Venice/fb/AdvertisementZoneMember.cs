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
	public class AdvertisementZoneMember
	{
		[ContainerField(0), LayoutImmutable]
		public string Identifier { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string Filename { get; set; } = string.Empty;
		
		public static void Deserialize(AdvertisementZoneMember p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Identifier = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Filename = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}
	}
}
