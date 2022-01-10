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
	public class BlazePresenceBackendData : 
		PresenceBackendData
	{
		[ContainerField(16)]
		public List<CtrRef<MatchmakingSession>> MatchmakingSessions { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool UseDemanglerService { get; set; }

		public static void Deserialize(BlazePresenceBackendData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MatchmakingSessions.Clear();
			(RimeReader Reader, uint Count) s_MatchmakingSessions = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_MatchmakingSessions.Count; ++i)
			{
				var s_CtrRef = new CtrRef<MatchmakingSession>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_MatchmakingSessions.Reader.ReadUInt32()));
				p_Instance.MatchmakingSessions.Add(s_CtrRef);
			}
			
			s_MatchmakingSessions.Reader.Dispose();
			p_Instance.UseDemanglerService = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
