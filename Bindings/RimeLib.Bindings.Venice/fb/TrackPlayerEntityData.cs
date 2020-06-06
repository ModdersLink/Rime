///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class TrackPlayerEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float SnapHeightOffsetY { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public bool RandomizeTracker { get; set; } // 0x64 (100)
		
		[ContainerField(101), LayoutImmutable, Blittable]
		public bool SnapHeightOnKilledDestroyed { get; set; } // 0x65 (101)
		
		[ContainerField(102), LayoutImmutable, Blittable]
		public bool CheckPlayerAlive { get; set; } // 0x66 (102)
		
		[ContainerField(103), LayoutImmutable, Blittable]
		public bool EnforceSharedCombatArea { get; set; } // 0x67 (103)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public bool UpdateFlagComponent { get; set; } // 0x68 (104)
		
		[ContainerField(105), LayoutImmutable, Blittable]
		public bool TrackMultiplePlayers { get; set; } // 0x69 (105)
		
		[ContainerField(106), LayoutImmutable, Blittable]
		public bool Reseted { get; set; } // 0x6A (106)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2381182690:
					SnapHeightOffsetY = (float) p_Value;
					break;

				case 4092136432:
					RandomizeTracker = (bool) p_Value;
					break;

				case 1919550071:
					SnapHeightOnKilledDestroyed = (bool) p_Value;
					break;

				case 798272103:
					CheckPlayerAlive = (bool) p_Value;
					break;

				case 1149579547:
					EnforceSharedCombatArea = (bool) p_Value;
					break;

				case 4273434999:
					UpdateFlagComponent = (bool) p_Value;
					break;

				case 1274348570:
					TrackMultiplePlayers = (bool) p_Value;
					break;

				case 1303266193:
					Reseted = (bool) p_Value;
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
				case 2381182690:
					return SnapHeightOffsetY;

				case 4092136432:
					return RandomizeTracker;

				case 1919550071:
					return SnapHeightOnKilledDestroyed;

				case 798272103:
					return CheckPlayerAlive;

				case 1149579547:
					return EnforceSharedCombatArea;

				case 4273434999:
					return UpdateFlagComponent;

				case 1274348570:
					return TrackMultiplePlayers;

				case 1303266193:
					return Reseted;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2381182690:
					return typeof(TrackPlayerEntityData).GetProperty(nameof(SnapHeightOffsetY));

				case 4092136432:
					return typeof(TrackPlayerEntityData).GetProperty(nameof(RandomizeTracker));

				case 1919550071:
					return typeof(TrackPlayerEntityData).GetProperty(nameof(SnapHeightOnKilledDestroyed));

				case 798272103:
					return typeof(TrackPlayerEntityData).GetProperty(nameof(CheckPlayerAlive));

				case 1149579547:
					return typeof(TrackPlayerEntityData).GetProperty(nameof(EnforceSharedCombatArea));

				case 4273434999:
					return typeof(TrackPlayerEntityData).GetProperty(nameof(UpdateFlagComponent));

				case 1274348570:
					return typeof(TrackPlayerEntityData).GetProperty(nameof(TrackMultiplePlayers));

				case 1303266193:
					return typeof(TrackPlayerEntityData).GetProperty(nameof(Reseted));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
