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
	[ContainerType(4, 24)]
	public class MapRotationConfig
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public int MapRotationId { get; set; }
		
		[ContainerField(4), LayoutImmutable]
		public string NameSid { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable]
		public string DescSid { get; set; } = string.Empty;
		
		[ContainerField(12), LayoutImmutable]
		public string Mod { get; set; } = string.Empty;
		
		[ContainerField(16), LayoutImmutable]
		public string GameMode { get; set; } = string.Empty;
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool RandomizeStartingMap { get; set; }
		
		public static void Deserialize(MapRotationConfig p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MapRotationId = p_Reader.ReadInt32();
			p_Instance.NameSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.DescSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Mod = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.GameMode = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.RandomizeStartingMap = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
