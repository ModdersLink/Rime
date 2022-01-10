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
	[ContainerType(4, 52)]
	public class SequenceEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public List<SequenceEventData> Events { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public int SequenceStartTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public int SequenceLength { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float ExternalTime { get; set; }

		[ContainerField(28)]
		public List<CtrRef<PropertyTrackData>> PropertyTracks { get; set; } = new();

		[ContainerField(32)]
		public Realm Realm { get; set; } = new();

		[ContainerField(36)]
		public UpdatePass ServerUpdatePass { get; set; } = new();

		[ContainerField(40)]
		public UpdatePass ClientUpdatePass { get; set; } = new();

		[ContainerField(44)]
		public List<CtrRef<CustomSequenceTrackData>> CustomSequenceTracks { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable]
		public bool AutoPlayFirstFrame { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable]
		public bool Looping { get; set; }

		[ContainerField(50), LayoutImmutable, Blittable]
		public bool AutoStart { get; set; }

		[ContainerField(51), LayoutImmutable, Blittable]
		public bool PlayInReverse { get; set; }

		public static void Deserialize(SequenceEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Events.Clear();
			(RimeReader Reader, uint Count) s_Events = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Events.Count; ++i)
			{
				var s_Value = new SequenceEventData();
				fb.SequenceEventData.Deserialize(s_Value, s_Events.Reader, p_Parser);
				p_Instance.Events.Add(s_Value);
			}
			
			s_Events.Reader.Dispose();
			p_Instance.SequenceStartTime = p_Reader.ReadInt32();
			p_Instance.SequenceLength = p_Reader.ReadInt32();
			p_Instance.ExternalTime = p_Reader.ReadSingle();
			p_Instance.PropertyTracks.Clear();
			(RimeReader Reader, uint Count) s_PropertyTracks = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PropertyTracks.Count; ++i)
			{
				var s_CtrRef = new CtrRef<PropertyTrackData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_PropertyTracks.Reader.ReadUInt32()));
				p_Instance.PropertyTracks.Add(s_CtrRef);
			}
			
			s_PropertyTracks.Reader.Dispose();
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.ServerUpdatePass = (UpdatePass) p_Reader.ReadInt32();
			p_Instance.ClientUpdatePass = (UpdatePass) p_Reader.ReadInt32();
			p_Instance.CustomSequenceTracks.Clear();
			(RimeReader Reader, uint Count) s_CustomSequenceTracks = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_CustomSequenceTracks.Count; ++i)
			{
				var s_CtrRef = new CtrRef<CustomSequenceTrackData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_CustomSequenceTracks.Reader.ReadUInt32()));
				p_Instance.CustomSequenceTracks.Add(s_CtrRef);
			}
			
			s_CustomSequenceTracks.Reader.Dispose();
			p_Instance.AutoPlayFirstFrame = p_Reader.ReadBool();
			p_Instance.Looping = p_Reader.ReadBool();
			p_Instance.AutoStart = p_Reader.ReadBool();
			p_Instance.PlayInReverse = p_Reader.ReadBool();
		}

	}
}
