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

using fb.Core;

namespace fb.Entity;

[ContainerType(8, 88)]
public class SequenceEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<SequenceEventData> Events { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int SequenceStartTime { get; set; } = 0;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public int SequenceLength { get; set; } = 10000;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public RefArray<PropertyTrackData> PropertyTracks { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public RefArray<CustomSequenceTrackData> CustomSequenceTracks { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public UpdatePass ClientUpdatePass { get; set; } = UpdatePass.UpdatePass_PostFrame;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public UpdatePass ServerUpdatePass { get; set; } = UpdatePass.UpdatePass_PreSim;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float ExternalTime { get; set; } = 0.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float PlaybackSpeed { get; set; } = 1.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool Looping { get; set; } = false;
	
	[ContainerField(0x51), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
	public bool AutoStart { get; set; } = false;
	
	[ContainerField(0x52), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
	public bool AutoPlayFirstFrame { get; set; } = false;
	
	[ContainerField(0x53), LayoutImmutable, Blittable, JsonProperty(Order = 83)]
	public bool PlayInReverse { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Events = p_EbxWriter.GetArrayWriter(Events.GetType(), Events.Count);
		p_Writer.Write(s_Events.ArrayIndex);
		foreach (var s_Entry in Events)
		{
			s_Entry.Serialize(s_Events.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(SequenceStartTime);
		p_Writer.Write(SequenceLength);
		p_Writer.Write((int) Realm);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PropertyTracks = p_EbxWriter.GetArrayWriter(PropertyTracks.GetType(), PropertyTracks.Count);
		p_Writer.Write(s_PropertyTracks.ArrayIndex);
		foreach (var s_Entry in PropertyTracks)
		{
			s_PropertyTracks.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_CustomSequenceTracks = p_EbxWriter.GetArrayWriter(CustomSequenceTracks.GetType(), CustomSequenceTracks.Count);
		p_Writer.Write(s_CustomSequenceTracks.ArrayIndex);
		foreach (var s_Entry in CustomSequenceTracks)
		{
			s_CustomSequenceTracks.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) ClientUpdatePass);
		p_Writer.Write((int) ServerUpdatePass);
		p_Writer.Write(ExternalTime);
		p_Writer.Write(PlaybackSpeed);
		p_Writer.Write(Looping);
		p_Writer.Write(AutoStart);
		p_Writer.Write(AutoPlayFirstFrame);
		p_Writer.Write(PlayInReverse);
		p_Writer.WriteNullBytes(4);
	}
}

