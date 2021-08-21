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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class TrackPlayerEntityData : 
		GameEntityData
	{
		protected float m_SnapHeightOffsetY = new float();
		[ContainerField(Name: "SnapHeightOffsetY", Offset: 96, NameHash: 2381182690, Flags: 49469), LayoutImmutable, Blittable]
		public float SnapHeightOffsetY { get { return m_SnapHeightOffsetY; } set { if (OnPropertyChanging("TrackPlayerEntityData." + nameof(SnapHeightOffsetY), this, m_SnapHeightOffsetY, value)) m_SnapHeightOffsetY = value; } } // 0x60 (96)
		
		protected bool m_RandomizeTracker = new bool();
		[ContainerField(Name: "RandomizeTracker", Offset: 100, NameHash: 4092136432, Flags: 49325), LayoutImmutable, Blittable]
		public bool RandomizeTracker { get { return m_RandomizeTracker; } set { if (OnPropertyChanging("TrackPlayerEntityData." + nameof(RandomizeTracker), this, m_RandomizeTracker, value)) m_RandomizeTracker = value; } } // 0x64 (100)
		
		protected bool m_SnapHeightOnKilledDestroyed = new bool();
		[ContainerField(Name: "SnapHeightOnKilledDestroyed", Offset: 101, NameHash: 1919550071, Flags: 49325), LayoutImmutable, Blittable]
		public bool SnapHeightOnKilledDestroyed { get { return m_SnapHeightOnKilledDestroyed; } set { if (OnPropertyChanging("TrackPlayerEntityData." + nameof(SnapHeightOnKilledDestroyed), this, m_SnapHeightOnKilledDestroyed, value)) m_SnapHeightOnKilledDestroyed = value; } } // 0x65 (101)
		
		protected bool m_CheckPlayerAlive = new bool();
		[ContainerField(Name: "CheckPlayerAlive", Offset: 102, NameHash: 798272103, Flags: 49325), LayoutImmutable, Blittable]
		public bool CheckPlayerAlive { get { return m_CheckPlayerAlive; } set { if (OnPropertyChanging("TrackPlayerEntityData." + nameof(CheckPlayerAlive), this, m_CheckPlayerAlive, value)) m_CheckPlayerAlive = value; } } // 0x66 (102)
		
		protected bool m_EnforceSharedCombatArea = new bool();
		[ContainerField(Name: "EnforceSharedCombatArea", Offset: 103, NameHash: 1149579547, Flags: 49325), LayoutImmutable, Blittable]
		public bool EnforceSharedCombatArea { get { return m_EnforceSharedCombatArea; } set { if (OnPropertyChanging("TrackPlayerEntityData." + nameof(EnforceSharedCombatArea), this, m_EnforceSharedCombatArea, value)) m_EnforceSharedCombatArea = value; } } // 0x67 (103)
		
		protected bool m_UpdateFlagComponent = new bool();
		[ContainerField(Name: "UpdateFlagComponent", Offset: 104, NameHash: 4273434999, Flags: 49325), LayoutImmutable, Blittable]
		public bool UpdateFlagComponent { get { return m_UpdateFlagComponent; } set { if (OnPropertyChanging("TrackPlayerEntityData." + nameof(UpdateFlagComponent), this, m_UpdateFlagComponent, value)) m_UpdateFlagComponent = value; } } // 0x68 (104)
		
		protected bool m_TrackMultiplePlayers = new bool();
		[ContainerField(Name: "TrackMultiplePlayers", Offset: 105, NameHash: 1274348570, Flags: 49325), LayoutImmutable, Blittable]
		public bool TrackMultiplePlayers { get { return m_TrackMultiplePlayers; } set { if (OnPropertyChanging("TrackPlayerEntityData." + nameof(TrackMultiplePlayers), this, m_TrackMultiplePlayers, value)) m_TrackMultiplePlayers = value; } } // 0x69 (105)
		
		protected bool m_Reseted = new bool();
		[ContainerField(Name: "Reseted", Offset: 106, NameHash: 1303266193, Flags: 49325), LayoutImmutable, Blittable]
		public bool Reseted { get { return m_Reseted; } set { if (OnPropertyChanging("TrackPlayerEntityData." + nameof(Reseted), this, m_Reseted, value)) m_Reseted = value; } } // 0x6A (106)
		
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
