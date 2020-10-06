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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(52), ContainerClass]
	public class SequenceEntityData : 
		EntityData
	{
		protected List<SequenceEventData> m_Events = new List<SequenceEventData>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(2352146554), ContainerArray]
		public List<SequenceEventData> Events { get { return m_Events; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(Events), this, m_Events, value)) m_Events = value; } } // 0xC (12)
		
		protected int m_SequenceStartTime = new int();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1603593583)]
		public int SequenceStartTime { get { return m_SequenceStartTime; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(SequenceStartTime), this, m_SequenceStartTime, value)) m_SequenceStartTime = value; } } // 0x10 (16)
		
		protected int m_SequenceLength = new int();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2068204742)]
		public int SequenceLength { get { return m_SequenceLength; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(SequenceLength), this, m_SequenceLength, value)) m_SequenceLength = value; } } // 0x14 (20)
		
		protected float m_ExternalTime = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2162678253)]
		public float ExternalTime { get { return m_ExternalTime; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(ExternalTime), this, m_ExternalTime, value)) m_ExternalTime = value; } } // 0x18 (24)
		
		protected RefArray<PropertyTrackData> m_PropertyTracks = new RefArray<PropertyTrackData>();
		[ContainerField(28), MemberInfoFlag(65), ContainerFieldNameHash(3471592734), ContainerRefArray]
		public RefArray<PropertyTrackData> PropertyTracks { get { return m_PropertyTracks; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(PropertyTracks), this, m_PropertyTracks, value)) m_PropertyTracks = value; } } // 0x1C (28)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(32), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x20 (32)
		
		protected UpdatePass m_ServerUpdatePass = new UpdatePass();
		[ContainerField(36), MemberInfoFlag(137), ContainerFieldNameHash(2515352480)]
		public UpdatePass ServerUpdatePass { get { return m_ServerUpdatePass; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(ServerUpdatePass), this, m_ServerUpdatePass, value)) m_ServerUpdatePass = value; } } // 0x24 (36)
		
		protected UpdatePass m_ClientUpdatePass = new UpdatePass();
		[ContainerField(40), MemberInfoFlag(137), ContainerFieldNameHash(2631769212)]
		public UpdatePass ClientUpdatePass { get { return m_ClientUpdatePass; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(ClientUpdatePass), this, m_ClientUpdatePass, value)) m_ClientUpdatePass = value; } } // 0x28 (40)
		
		protected RefArray<CustomSequenceTrackData> m_CustomSequenceTracks = new RefArray<CustomSequenceTrackData>();
		[ContainerField(44), MemberInfoFlag(65), ContainerFieldNameHash(2058346709), ContainerRefArray]
		public RefArray<CustomSequenceTrackData> CustomSequenceTracks { get { return m_CustomSequenceTracks; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(CustomSequenceTracks), this, m_CustomSequenceTracks, value)) m_CustomSequenceTracks = value; } } // 0x2C (44)
		
		protected bool m_AutoPlayFirstFrame = new bool();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3638007145)]
		public bool AutoPlayFirstFrame { get { return m_AutoPlayFirstFrame; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(AutoPlayFirstFrame), this, m_AutoPlayFirstFrame, value)) m_AutoPlayFirstFrame = value; } } // 0x30 (48)
		
		protected bool m_Looping = new bool();
		[ContainerField(49), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1366646169)]
		public bool Looping { get { return m_Looping; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(Looping), this, m_Looping, value)) m_Looping = value; } } // 0x31 (49)
		
		protected bool m_AutoStart = new bool();
		[ContainerField(50), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(792615882)]
		public bool AutoStart { get { return m_AutoStart; } set { if (OnPropertyChanging("SequenceEntityData." + nameof(AutoStart), this, m_AutoStart, value)) m_AutoStart = value; } } // 0x32 (50)
		
		protected bool m_PlayInReverse = new bool();
		[ContainerField(51), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2845503782)]
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
