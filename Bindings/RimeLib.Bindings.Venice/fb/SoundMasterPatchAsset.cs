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
	public class SoundMasterPatchAsset : 
		SoundGraphAsset
	{
		[ContainerField(24)]
		public List<CtrRef<SoundBusData>> Busses { get; set; } = new();

		[ContainerField(28)]
		public CtrRef<SoundBusData> RwMovieBus { get; set; } = new();

		public static void Deserialize(SoundMasterPatchAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Busses.Clear();
			(RimeReader Reader, uint Count) s_Busses = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Busses.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SoundBusData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Busses.Reader.ReadUInt32()));
				p_Instance.Busses.Add(s_CtrRef);
			}
			
			s_Busses.Reader.Dispose();
			p_Instance.RwMovieBus.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
