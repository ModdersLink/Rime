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
	public class ProfileOptionData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string UniqueId { get; set; } = string.Empty;

		[ContainerField(16)]
		public ProfileOptionsType Category { get; set; } = new();

		public static void Deserialize(ProfileOptionData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.UniqueId = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Category = (ProfileOptionsType) p_Reader.ReadInt32();
		}

	}
}
