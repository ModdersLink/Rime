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
	public partial class SoundStateSettingsAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private RefArray<SoundState> _SoundStates = new();

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _ImpairedHearingImpulseThreshold;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _ScreamThreshold;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _SupressionThreshold;

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
