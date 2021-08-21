///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 52)]
	public class SequenceEntityData : 
		EntityData
	{
		protected List<SequenceEventData> m_Events = new List<SequenceEventData>();
		[ContainerField(Name: "Events", Offset: 12, NameHash: 2352146554, Flags: 65)]
		public List<SequenceEventData> Events { get { return m_Events; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(Events), this, m_Events, value)) m_Events = value; } } // 0xC (12)
		
		protected int m_SequenceStartTime = new int();
		[ContainerField(Name: "SequenceStartTime", Offset: 16, NameHash: 1603593583, Flags: 49405), LayoutImmutable, Blittable]
		public int SequenceStartTime { get { return m_SequenceStartTime; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(SequenceStartTime), this, m_SequenceStartTime, value)) m_SequenceStartTime = value; } } // 0x10 (16)
		
		protected int m_SequenceLength = new int();
		[ContainerField(Name: "SequenceLength", Offset: 20, NameHash: 2068204742, Flags: 49405), LayoutImmutable, Blittable]
		public int SequenceLength { get { return m_SequenceLength; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(SequenceLength), this, m_SequenceLength, value)) m_SequenceLength = value; } } // 0x14 (20)
		
		protected float m_ExternalTime = new float();
		[ContainerField(Name: "ExternalTime", Offset: 24, NameHash: 2162678253, Flags: 49469), LayoutImmutable, Blittable]
		public float ExternalTime { get { return m_ExternalTime; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(ExternalTime), this, m_ExternalTime, value)) m_ExternalTime = value; } } // 0x18 (24)
		
		protected RefArray<PropertyTrackData> m_PropertyTracks = new RefArray<PropertyTrackData>();
		[ContainerField(Name: "PropertyTracks", Offset: 28, NameHash: 3471592734, Flags: 65)]
		public RefArray<PropertyTrackData> PropertyTracks { get { return m_PropertyTracks; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(PropertyTracks), this, m_PropertyTracks, value)) m_PropertyTracks = value; } } // 0x1C (28)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 32, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x20 (32)
		
		protected UpdatePass m_ServerUpdatePass = new UpdatePass();
		[ContainerField(Name: "ServerUpdatePass", Offset: 36, NameHash: 2515352480, Flags: 137)]
		public UpdatePass ServerUpdatePass { get { return m_ServerUpdatePass; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(ServerUpdatePass), this, m_ServerUpdatePass, value)) m_ServerUpdatePass = value; } } // 0x24 (36)
		
		protected UpdatePass m_ClientUpdatePass = new UpdatePass();
		[ContainerField(Name: "ClientUpdatePass", Offset: 40, NameHash: 2631769212, Flags: 137)]
		public UpdatePass ClientUpdatePass { get { return m_ClientUpdatePass; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(ClientUpdatePass), this, m_ClientUpdatePass, value)) m_ClientUpdatePass = value; } } // 0x28 (40)
		
		protected RefArray<CustomSequenceTrackData> m_CustomSequenceTracks = new RefArray<CustomSequenceTrackData>();
		[ContainerField(Name: "CustomSequenceTracks", Offset: 44, NameHash: 2058346709, Flags: 65)]
		public RefArray<CustomSequenceTrackData> CustomSequenceTracks { get { return m_CustomSequenceTracks; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(CustomSequenceTracks), this, m_CustomSequenceTracks, value)) m_CustomSequenceTracks = value; } } // 0x2C (44)
		
		protected bool m_AutoPlayFirstFrame = new bool();
		[ContainerField(Name: "AutoPlayFirstFrame", Offset: 48, NameHash: 3638007145, Flags: 49325), LayoutImmutable, Blittable]
		public bool AutoPlayFirstFrame { get { return m_AutoPlayFirstFrame; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(AutoPlayFirstFrame), this, m_AutoPlayFirstFrame, value)) m_AutoPlayFirstFrame = value; } } // 0x30 (48)
		
		protected bool m_Looping = new bool();
		[ContainerField(Name: "Looping", Offset: 49, NameHash: 1366646169, Flags: 49325), LayoutImmutable, Blittable]
		public bool Looping { get { return m_Looping; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(Looping), this, m_Looping, value)) m_Looping = value; } } // 0x31 (49)
		
		protected bool m_AutoStart = new bool();
		[ContainerField(Name: "AutoStart", Offset: 50, NameHash: 792615882, Flags: 49325), LayoutImmutable, Blittable]
		public bool AutoStart { get { return m_AutoStart; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(AutoStart), this, m_AutoStart, value)) m_AutoStart = value; } } // 0x32 (50)
		
		protected bool m_PlayInReverse = new bool();
		[ContainerField(Name: "PlayInReverse", Offset: 51, NameHash: 2845503782, Flags: 49325), LayoutImmutable, Blittable]
		public bool PlayInReverse { get { return m_PlayInReverse; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(PlayInReverse), this, m_PlayInReverse, value)) m_PlayInReverse = value; } } // 0x33 (51)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2352146554:
					Events = (List<SequenceEventData>) p_Value;
					break;

				case 1603593583:
					SequenceStartTime = (int) p_Value;
					break;

				case 2068204742:
					SequenceLength = (int) p_Value;
					break;

				case 2162678253:
					ExternalTime = (float) p_Value;
					break;

				case 3471592734:
					PropertyTracks = (RefArray<PropertyTrackData>) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2515352480:
					ServerUpdatePass = (UpdatePass) Enum.ToObject(typeof(UpdatePass), p_Value);
					break;

				case 2631769212:
					ClientUpdatePass = (UpdatePass) Enum.ToObject(typeof(UpdatePass), p_Value);
					break;

				case 2058346709:
					CustomSequenceTracks = (RefArray<CustomSequenceTrackData>) p_Value;
					break;

				case 3638007145:
					AutoPlayFirstFrame = (bool) p_Value;
					break;

				case 1366646169:
					Looping = (bool) p_Value;
					break;

				case 792615882:
					AutoStart = (bool) p_Value;
					break;

				case 2845503782:
					PlayInReverse = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2352146554:
					return Events;

				case 1603593583:
					return SequenceStartTime;

				case 2068204742:
					return SequenceLength;

				case 2162678253:
					return ExternalTime;

				case 3471592734:
					return PropertyTracks;

				case 229961746:
					return Realm;

				case 2515352480:
					return ServerUpdatePass;

				case 2631769212:
					return ClientUpdatePass;

				case 2058346709:
					return CustomSequenceTracks;

				case 3638007145:
					return AutoPlayFirstFrame;

				case 1366646169:
					return Looping;

				case 792615882:
					return AutoStart;

				case 2845503782:
					return PlayInReverse;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2352146554:
					return typeof(SequenceEntityData).GetProperty(nameof(Events));

				case 1603593583:
					return typeof(SequenceEntityData).GetProperty(nameof(SequenceStartTime));

				case 2068204742:
					return typeof(SequenceEntityData).GetProperty(nameof(SequenceLength));

				case 2162678253:
					return typeof(SequenceEntityData).GetProperty(nameof(ExternalTime));

				case 3471592734:
					return typeof(SequenceEntityData).GetProperty(nameof(PropertyTracks));

				case 229961746:
					return typeof(SequenceEntityData).GetProperty(nameof(Realm));

				case 2515352480:
					return typeof(SequenceEntityData).GetProperty(nameof(ServerUpdatePass));

				case 2631769212:
					return typeof(SequenceEntityData).GetProperty(nameof(ClientUpdatePass));

				case 2058346709:
					return typeof(SequenceEntityData).GetProperty(nameof(CustomSequenceTracks));

				case 3638007145:
					return typeof(SequenceEntityData).GetProperty(nameof(AutoPlayFirstFrame));

				case 1366646169:
					return typeof(SequenceEntityData).GetProperty(nameof(Looping));

				case 792615882:
					return typeof(SequenceEntityData).GetProperty(nameof(AutoStart));

				case 2845503782:
					return typeof(SequenceEntityData).GetProperty(nameof(PlayInReverse));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
