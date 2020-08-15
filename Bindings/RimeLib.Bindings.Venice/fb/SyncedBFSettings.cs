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
	[ContainerType(4)]
	public class SyncedBFSettings : 
		SystemSettings
	{
		protected float m_GameModeCounterModifier = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(3667623179)]
		public float GameModeCounterModifier { get { return m_GameModeCounterModifier; } set { if (OnPropertyChanging("SyncedBFSettings." + nameof(GameModeCounterModifier), this, m_GameModeCounterModifier, value)) m_GameModeCounterModifier = value; } } // 0xC (12)
		
		protected bool m_UnlicensedUnlocksUnlocked = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(3594366899)]
		public bool UnlicensedUnlocksUnlocked { get { return m_UnlicensedUnlocksUnlocked; } set { if (OnPropertyChanging("SyncedBFSettings." + nameof(UnlicensedUnlocksUnlocked), this, m_UnlicensedUnlocksUnlocked, value)) m_UnlicensedUnlocksUnlocked = value; } } // 0x10 (16)
		
		protected bool m_NoMinimap = new bool();
		[ContainerField(17), LayoutImmutable, Blittable, ContainerFieldNameHash(1386192603)]
		public bool NoMinimap { get { return m_NoMinimap; } set { if (OnPropertyChanging("SyncedBFSettings." + nameof(NoMinimap), this, m_NoMinimap, value)) m_NoMinimap = value; } } // 0x11 (17)
		
		protected bool m_NoHud = new bool();
		[ContainerField(18), LayoutImmutable, Blittable, ContainerFieldNameHash(215840861)]
		public bool NoHud { get { return m_NoHud; } set { if (OnPropertyChanging("SyncedBFSettings." + nameof(NoHud), this, m_NoHud, value)) m_NoHud = value; } } // 0x12 (18)
		
		protected bool m_NoMinimapSpotting = new bool();
		[ContainerField(19), LayoutImmutable, Blittable, ContainerFieldNameHash(1230894711)]
		public bool NoMinimapSpotting { get { return m_NoMinimapSpotting; } set { if (OnPropertyChanging("SyncedBFSettings." + nameof(NoMinimapSpotting), this, m_NoMinimapSpotting, value)) m_NoMinimapSpotting = value; } } // 0x13 (19)
		
		protected bool m_No3dSpotting = new bool();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(1747911103)]
		public bool No3dSpotting { get { return m_No3dSpotting; } set { if (OnPropertyChanging("SyncedBFSettings." + nameof(No3dSpotting), this, m_No3dSpotting, value)) m_No3dSpotting = value; } } // 0x14 (20)
		
		protected bool m_NoNameTag = new bool();
		[ContainerField(21), LayoutImmutable, Blittable, ContainerFieldNameHash(698198321)]
		public bool NoNameTag { get { return m_NoNameTag; } set { if (OnPropertyChanging("SyncedBFSettings." + nameof(NoNameTag), this, m_NoNameTag, value)) m_NoNameTag = value; } } // 0x15 (21)
		
		protected bool m_OnlySquadLeaderSpawn = new bool();
		[ContainerField(22), LayoutImmutable, Blittable, ContainerFieldNameHash(1511489379)]
		public bool OnlySquadLeaderSpawn { get { return m_OnlySquadLeaderSpawn; } set { if (OnPropertyChanging("SyncedBFSettings." + nameof(OnlySquadLeaderSpawn), this, m_OnlySquadLeaderSpawn, value)) m_OnlySquadLeaderSpawn = value; } } // 0x16 (22)
		
		protected bool m_TeamSwitchingAllowed = new bool();
		[ContainerField(23), LayoutImmutable, Blittable, ContainerFieldNameHash(3622000178)]
		public bool TeamSwitchingAllowed { get { return m_TeamSwitchingAllowed; } set { if (OnPropertyChanging("SyncedBFSettings." + nameof(TeamSwitchingAllowed), this, m_TeamSwitchingAllowed, value)) m_TeamSwitchingAllowed = value; } } // 0x17 (23)
		
		protected bool m_MemoryDefragUI = new bool();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(2646324939)]
		public bool MemoryDefragUI { get { return m_MemoryDefragUI; } set { if (OnPropertyChanging("SyncedBFSettings." + nameof(MemoryDefragUI), this, m_MemoryDefragUI, value)) m_MemoryDefragUI = value; } } // 0x18 (24)
		
		protected bool m_MemoryGarbageCollectHavok = new bool();
		[ContainerField(25), LayoutImmutable, Blittable, ContainerFieldNameHash(1120555892)]
		public bool MemoryGarbageCollectHavok { get { return m_MemoryGarbageCollectHavok; } set { if (OnPropertyChanging("SyncedBFSettings." + nameof(MemoryGarbageCollectHavok), this, m_MemoryGarbageCollectHavok, value)) m_MemoryGarbageCollectHavok = value; } } // 0x19 (25)
		
		protected bool m_MemoryDefragGlobal = new bool();
		[ContainerField(26), LayoutImmutable, Blittable, ContainerFieldNameHash(153257596)]
		public bool MemoryDefragGlobal { get { return m_MemoryDefragGlobal; } set { if (OnPropertyChanging("SyncedBFSettings." + nameof(MemoryDefragGlobal), this, m_MemoryDefragGlobal, value)) m_MemoryDefragGlobal = value; } } // 0x1A (26)
		
		protected bool m_AllUnlocksUnlocked = new bool();
		[ContainerField(27), LayoutImmutable, Blittable, ContainerFieldNameHash(3219327094)]
		public bool AllUnlocksUnlocked { get { return m_AllUnlocksUnlocked; } set { if (OnPropertyChanging("SyncedBFSettings." + nameof(AllUnlocksUnlocked), this, m_AllUnlocksUnlocked, value)) m_AllUnlocksUnlocked = value; } } // 0x1B (27)
		
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
