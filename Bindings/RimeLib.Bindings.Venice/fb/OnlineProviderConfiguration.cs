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
	[ContainerType(4, 28)]
	public class OnlineProviderConfiguration
	{
		[ContainerField(0)]
		public GamePlatform Platform { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable]
		public string Client { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable]
		public string ServiceName { get; set; } = string.Empty;
		
		[ContainerField(12), LayoutImmutable]
		public string SKU { get; set; } = string.Empty;
		
		[ContainerField(16), LayoutImmutable]
		public string Version { get; set; } = string.Empty;
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint ServerSocketPacketSize { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool IsServer { get; set; }
		
		public static void Deserialize(OnlineProviderConfiguration p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Platform = (GamePlatform) p_Reader.ReadInt32();
			p_Instance.Client = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ServiceName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.SKU = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Version = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ServerSocketPacketSize = p_Reader.ReadUInt32();
			p_Instance.IsServer = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
