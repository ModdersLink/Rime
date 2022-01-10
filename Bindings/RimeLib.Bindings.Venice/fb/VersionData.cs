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
	[ContainerType(4, 32)]
	public class VersionData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string disclaimer { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable, Blittable]
		public int Version { get; set; }

		[ContainerField(20), LayoutImmutable]
		public string DateTime { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable]
		public string BranchId { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable]
		public string GameName { get; set; } = string.Empty;

		public static void Deserialize(VersionData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.disclaimer = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Version = p_Reader.ReadInt32();
			p_Instance.DateTime = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.BranchId = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.GameName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}

	}
}
