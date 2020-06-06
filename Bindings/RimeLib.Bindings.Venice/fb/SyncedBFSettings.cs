///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SyncedBFSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float GameModeCounterModifier { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool UnlicensedUnlocksUnlocked { get; set; } // 0x10 (16)
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool NoMinimap { get; set; } // 0x11 (17)
		
		[ContainerField(18), LayoutImmutable, Blittable]
		public bool NoHud { get; set; } // 0x12 (18)
		
		[ContainerField(19), LayoutImmutable, Blittable]
		public bool NoMinimapSpotting { get; set; } // 0x13 (19)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool No3dSpotting { get; set; } // 0x14 (20)
		
		[ContainerField(21), LayoutImmutable, Blittable]
		public bool NoNameTag { get; set; } // 0x15 (21)
		
		[ContainerField(22), LayoutImmutable, Blittable]
		public bool OnlySquadLeaderSpawn { get; set; } // 0x16 (22)
		
		[ContainerField(23), LayoutImmutable, Blittable]
		public bool TeamSwitchingAllowed { get; set; } // 0x17 (23)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool MemoryDefragUI { get; set; } // 0x18 (24)
		
		[ContainerField(25), LayoutImmutable, Blittable]
		public bool MemoryGarbageCollectHavok { get; set; } // 0x19 (25)
		
		[ContainerField(26), LayoutImmutable, Blittable]
		public bool MemoryDefragGlobal { get; set; } // 0x1A (26)
		
		[ContainerField(27), LayoutImmutable, Blittable]
		public bool AllUnlocksUnlocked { get; set; } // 0x1B (27)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3667623179:
					GameModeCounterModifier = (float) p_Value;
					break;

				case 3594366899:
					UnlicensedUnlocksUnlocked = (bool) p_Value;
					break;

				case 1386192603:
					NoMinimap = (bool) p_Value;
					break;

				case 215840861:
					NoHud = (bool) p_Value;
					break;

				case 1230894711:
					NoMinimapSpotting = (bool) p_Value;
					break;

				case 1747911103:
					No3dSpotting = (bool) p_Value;
					break;

				case 698198321:
					NoNameTag = (bool) p_Value;
					break;

				case 1511489379:
					OnlySquadLeaderSpawn = (bool) p_Value;
					break;

				case 3622000178:
					TeamSwitchingAllowed = (bool) p_Value;
					break;

				case 2646324939:
					MemoryDefragUI = (bool) p_Value;
					break;

				case 1120555892:
					MemoryGarbageCollectHavok = (bool) p_Value;
					break;

				case 153257596:
					MemoryDefragGlobal = (bool) p_Value;
					break;

				case 3219327094:
					AllUnlocksUnlocked = (bool) p_Value;
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
				case 3667623179:
					return GameModeCounterModifier;

				case 3594366899:
					return UnlicensedUnlocksUnlocked;

				case 1386192603:
					return NoMinimap;

				case 215840861:
					return NoHud;

				case 1230894711:
					return NoMinimapSpotting;

				case 1747911103:
					return No3dSpotting;

				case 698198321:
					return NoNameTag;

				case 1511489379:
					return OnlySquadLeaderSpawn;

				case 3622000178:
					return TeamSwitchingAllowed;

				case 2646324939:
					return MemoryDefragUI;

				case 1120555892:
					return MemoryGarbageCollectHavok;

				case 153257596:
					return MemoryDefragGlobal;

				case 3219327094:
					return AllUnlocksUnlocked;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3667623179:
					return typeof(SyncedBFSettings).GetProperty(nameof(GameModeCounterModifier));

				case 3594366899:
					return typeof(SyncedBFSettings).GetProperty(nameof(UnlicensedUnlocksUnlocked));

				case 1386192603:
					return typeof(SyncedBFSettings).GetProperty(nameof(NoMinimap));

				case 215840861:
					return typeof(SyncedBFSettings).GetProperty(nameof(NoHud));

				case 1230894711:
					return typeof(SyncedBFSettings).GetProperty(nameof(NoMinimapSpotting));

				case 1747911103:
					return typeof(SyncedBFSettings).GetProperty(nameof(No3dSpotting));

				case 698198321:
					return typeof(SyncedBFSettings).GetProperty(nameof(NoNameTag));

				case 1511489379:
					return typeof(SyncedBFSettings).GetProperty(nameof(OnlySquadLeaderSpawn));

				case 3622000178:
					return typeof(SyncedBFSettings).GetProperty(nameof(TeamSwitchingAllowed));

				case 2646324939:
					return typeof(SyncedBFSettings).GetProperty(nameof(MemoryDefragUI));

				case 1120555892:
					return typeof(SyncedBFSettings).GetProperty(nameof(MemoryGarbageCollectHavok));

				case 153257596:
					return typeof(SyncedBFSettings).GetProperty(nameof(MemoryDefragGlobal));

				case 3219327094:
					return typeof(SyncedBFSettings).GetProperty(nameof(AllUnlocksUnlocked));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
