///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SequenceEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public List<SequenceEventData> Events { get; set; } = new List<SequenceEventData>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int SequenceStartTime { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public int SequenceLength { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float ExternalTime { get; set; } // 0x18 (24)
		
		[ContainerField(28)]
		public RefArray<PropertyTrackData> PropertyTracks { get; set; } = new RefArray<PropertyTrackData>(); // 0x1C (28)
		
		[ContainerField(32)]
		public Realm Realm { get; set; } = new Realm(); // 0x20 (32)
		
		[ContainerField(36)]
		public UpdatePass ServerUpdatePass { get; set; } = new UpdatePass(); // 0x24 (36)
		
		[ContainerField(40)]
		public UpdatePass ClientUpdatePass { get; set; } = new UpdatePass(); // 0x28 (40)
		
		[ContainerField(44)]
		public RefArray<CustomSequenceTrackData> CustomSequenceTracks { get; set; } = new RefArray<CustomSequenceTrackData>(); // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public bool AutoPlayFirstFrame { get; set; } // 0x30 (48)
		
		[ContainerField(49), LayoutImmutable, Blittable]
		public bool Looping { get; set; } // 0x31 (49)
		
		[ContainerField(50), LayoutImmutable, Blittable]
		public bool AutoStart { get; set; } // 0x32 (50)
		
		[ContainerField(51), LayoutImmutable, Blittable]
		public bool PlayInReverse { get; set; } // 0x33 (51)
		
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
