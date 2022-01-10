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
	[ContainerType(4, 40)]
	public class VeniceOnlineConfiguration : 
		OnlineConfiguration
	{
		[ContainerField(28)]
		public List<OnlinePlatformConfiguration> Platforms { get; set; } = new();

		[ContainerField(32)]
		public List<CtrRef<EntitlementQuery>> EntitlementQueries { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public bool UseFallback { get; set; }

		public static void Deserialize(VeniceOnlineConfiguration p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Platforms.Clear();
			(RimeReader Reader, uint Count) s_Platforms = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Platforms.Count; ++i)
			{
				var s_Value = new OnlinePlatformConfiguration();
				fb.OnlinePlatformConfiguration.Deserialize(s_Value, s_Platforms.Reader, p_Parser);
				p_Instance.Platforms.Add(s_Value);
			}
			
			s_Platforms.Reader.Dispose();
			p_Instance.EntitlementQueries.Clear();
			(RimeReader Reader, uint Count) s_EntitlementQueries = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_EntitlementQueries.Count; ++i)
			{
				var s_CtrRef = new CtrRef<EntitlementQuery>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_EntitlementQueries.Reader.ReadUInt32()));
				p_Instance.EntitlementQueries.Add(s_CtrRef);
			}
			
			s_EntitlementQueries.Reader.Dispose();
			p_Instance.UseFallback = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
