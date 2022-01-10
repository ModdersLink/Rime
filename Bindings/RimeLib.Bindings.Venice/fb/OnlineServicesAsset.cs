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
	public class OnlineServicesAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<PresenceServiceData>> OnlineServices { get; set; } = new();

		public static void Deserialize(OnlineServicesAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.OnlineServices.Clear();
			(RimeReader Reader, uint Count) s_OnlineServices = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_OnlineServices.Count; ++i)
			{
				var s_CtrRef = new CtrRef<PresenceServiceData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_OnlineServices.Reader.ReadUInt32()));
				p_Instance.OnlineServices.Add(s_CtrRef);
			}
			
			s_OnlineServices.Reader.Dispose();
		}

	}
}
