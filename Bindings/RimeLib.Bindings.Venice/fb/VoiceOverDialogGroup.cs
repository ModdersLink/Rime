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
	public class VoiceOverDialogGroup : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<SoundAsset> Sound { get; set; } = new();

		[ContainerField(12)]
		public List<CtrRef<VoiceOverDialogTrack>> Tracks { get; set; } = new();

		public static void Deserialize(VoiceOverDialogGroup p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Sound.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Tracks.Clear();
			(RimeReader Reader, uint Count) s_Tracks = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Tracks.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverDialogTrack>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Tracks.Reader.ReadUInt32()));
				p_Instance.Tracks.Add(s_CtrRef);
			}
			
			s_Tracks.Reader.Dispose();
		}

	}
}
