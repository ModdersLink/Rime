///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 16)]
	public class VoiceOverDialogGroup :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<SoundAsset> Sound { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<VoiceOverDialogTrack> Tracks { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Sound));
			(RimeWriter Writer, uint ArrayIndex) s_Tracks = p_EbxWriter.GetArrayWriter(Tracks.GetType(), Tracks.Count);
			p_Writer.Write(s_Tracks.ArrayIndex);
			foreach (var s_Entry in Tracks)
			{
				s_Tracks.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
