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
	public partial class VoiceOverDialogClip :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _Offset;

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<VoiceOverDialogTake> _Takes = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private RefArray<VoiceOverDialogClip> _OffsetReferences = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<VoiceOverDialogClipEvents> _Events = new();

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private sbyte _SequenceIndex;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(Offset);
			(RimeWriter Writer, uint ArrayIndex) s_Takes = p_EbxWriter.GetArrayWriter(Takes.GetType(), Takes.Count);
			p_Writer.Write(s_Takes.ArrayIndex);
			foreach (var s_Entry in Takes)
			{
				s_Entry.Serialize(s_Takes.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_OffsetReferences = p_EbxWriter.GetArrayWriter(OffsetReferences.GetType(), OffsetReferences.Count);
			p_Writer.Write(s_OffsetReferences.ArrayIndex);
			foreach (var s_Entry in OffsetReferences)
			{
				s_OffsetReferences.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(Events));
			p_Writer.Write(SequenceIndex);
			p_Writer.WriteNullBytes(3);
		}
	}
}
