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
	[ContainerType(4, 28)]
	public class SoundStateSettingsAsset :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<SoundState> SoundStates { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float ImpairedHearingImpulseThreshold { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float ScreamThreshold { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float SupressionThreshold { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_SoundStates = p_EbxWriter.GetArrayWriter(SoundStates.GetType(), SoundStates.Count);
			p_Writer.Write(s_SoundStates.ArrayIndex);
			foreach (var s_Entry in SoundStates)
			{
				s_SoundStates.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(ImpairedHearingImpulseThreshold);
			p_Writer.Write(ScreamThreshold);
			p_Writer.Write(SupressionThreshold);
		}
	}
}
