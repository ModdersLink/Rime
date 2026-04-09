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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 28)]
	public partial class SoundPatchConfigurationAsset :
		SoundAsset
	{
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<SoundPatchAsset> _Sound = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private RefArray<SoundPatchConfigurationEntry> _Entries = new();

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _Loudness;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Sound));
			(RimeWriter Writer, uint ArrayIndex) s_Entries = p_EbxWriter.GetArrayWriter(Entries.GetType(), Entries.Count);
			p_Writer.Write(s_Entries.ArrayIndex);
			foreach (var s_Entry in Entries)
			{
				s_Entries.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(Loudness);
		}
	}
}
