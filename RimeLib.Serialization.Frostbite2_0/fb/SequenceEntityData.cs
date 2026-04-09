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
	[ContainerType(4, 52)]
	public partial class SequenceEntityData :
		EntityData
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<SequenceEventData> _Events = new();

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private int _SequenceStartTime;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private int _SequenceLength;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _ExternalTime;

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private RefArray<PropertyTrackData> _PropertyTracks = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private UpdatePass _ServerUpdatePass = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private UpdatePass _ClientUpdatePass = new();

		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private RefArray<CustomSequenceTrackData> _CustomSequenceTracks = new();

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private bool _AutoPlayFirstFrame;

		[ObservableProperty]
		[property: ContainerField(49), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
		private bool _Looping;

		[ObservableProperty]
		[property: ContainerField(50), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
		private bool _AutoStart;

		[ObservableProperty]
		[property: ContainerField(51), LayoutImmutable, Blittable, JsonProperty(Order = 51)]
		private bool _PlayInReverse;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Events = p_EbxWriter.GetArrayWriter(Events.GetType(), Events.Count);
			p_Writer.Write(s_Events.ArrayIndex);
			foreach (var s_Entry in Events)
			{
				s_Entry.Serialize(s_Events.Writer, p_EbxWriter);
			}
			p_Writer.Write(SequenceStartTime);
			p_Writer.Write(SequenceLength);
			p_Writer.Write(ExternalTime);
			(RimeWriter Writer, uint ArrayIndex) s_PropertyTracks = p_EbxWriter.GetArrayWriter(PropertyTracks.GetType(), PropertyTracks.Count);
			p_Writer.Write(s_PropertyTracks.ArrayIndex);
			foreach (var s_Entry in PropertyTracks)
			{
				s_PropertyTracks.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write((int) Realm);
			p_Writer.Write((int) ServerUpdatePass);
			p_Writer.Write((int) ClientUpdatePass);
			(RimeWriter Writer, uint ArrayIndex) s_CustomSequenceTracks = p_EbxWriter.GetArrayWriter(CustomSequenceTracks.GetType(), CustomSequenceTracks.Count);
			p_Writer.Write(s_CustomSequenceTracks.ArrayIndex);
			foreach (var s_Entry in CustomSequenceTracks)
			{
				s_CustomSequenceTracks.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(AutoPlayFirstFrame);
			p_Writer.Write(Looping);
			p_Writer.Write(AutoStart);
			p_Writer.Write(PlayInReverse);
		}
	}
}
