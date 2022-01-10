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
	public class OnlinePlatformConfiguration
	{
		[ContainerField(0)]
		public GamePlatform Platform { get; set; } = new();
		
		[ContainerField(4)]
		public CtrRef<OnlineServicesAsset> Services { get; set; } = new();
		
		[ContainerField(8)]
		public List<CtrRef<PresenceBackendData>> ClientBackends { get; set; } = new();
		
		[ContainerField(12)]
		public List<CtrRef<ServerBackendData>> ServerBackends { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool IsFallback { get; set; }
		
		public static void Deserialize(OnlinePlatformConfiguration p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Platform = (GamePlatform) p_Reader.ReadInt32();
			p_Instance.Services.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ClientBackends.Clear();
			(RimeReader Reader, uint Count) s_ClientBackends = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ClientBackends.Count; ++i)
			{
				var s_CtrRef = new CtrRef<PresenceBackendData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_ClientBackends.Reader.ReadUInt32()));
				p_Instance.ClientBackends.Add(s_CtrRef);
			}
			
			s_ClientBackends.Reader.Dispose();
			p_Instance.ServerBackends.Clear();
			(RimeReader Reader, uint Count) s_ServerBackends = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ServerBackends.Count; ++i)
			{
				var s_CtrRef = new CtrRef<ServerBackendData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_ServerBackends.Reader.ReadUInt32()));
				p_Instance.ServerBackends.Add(s_CtrRef);
			}
			
			s_ServerBackends.Reader.Dispose();
			p_Instance.IsFallback = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
