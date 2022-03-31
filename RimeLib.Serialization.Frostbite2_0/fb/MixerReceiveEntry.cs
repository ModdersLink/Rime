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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class MixerReceiveEntry :
		AudioGraphNodePortGroup
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public AudioGraphNodePort Out { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<AudioGraphParameter> Source { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<MixerAsset> Mixer { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Out.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Source));
			p_Writer.Write(p_EbxWriter.WriteImport(Mixer));
		}
	}
}
