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
	[ContainerType(4, 24)]
	public class MixerAsset :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<MixerGraphData> Graph { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<MixerPreset> Presets { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<MixerPreset> DefaultPreset { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Graph));
			(RimeWriter Writer, uint ArrayIndex) s_Presets = p_EbxWriter.GetArrayWriter(Presets.GetType(), Presets.Count);
			p_Writer.Write(s_Presets.ArrayIndex);
			foreach (var s_Entry in Presets)
			{
				s_Presets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(DefaultPreset));
		}
	}
}
