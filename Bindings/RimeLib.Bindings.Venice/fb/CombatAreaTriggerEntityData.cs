///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class CombatAreaTriggerEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float MaxRandomSpawnHeight { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float SpawnHeight { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public uint TimeToReturn { get; set; } // 0x68 (104)
		
		[ContainerField(108)]
		public CtrRef<BulletEntityData> DeserterProjectile { get; set; } = new CtrRef<BulletEntityData>(); // 0x6C (108)
		
		[ContainerField(112)]
		public TeamId Team { get; set; } = new TeamId(); // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float StrikeRadius { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float InitalSpeed { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public bool IsAiAllowedOutside { get; set; } // 0x7C (124)
		
		[ContainerField(125), LayoutImmutable, Blittable]
		public bool IsTeamSpecific { get; set; } // 0x7D (125)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2881356526:
					MaxRandomSpawnHeight = (float) p_Value;
					break;

				case 2780846849:
					SpawnHeight = (float) p_Value;
					break;

				case 2769825281:
					TimeToReturn = (uint) p_Value;
					break;

				case 1751079062:
					DeserterProjectile = (CtrRef<BulletEntityData>) p_Value;
					break;

				case 2089309528:
					Team = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 4030357871:
					StrikeRadius = (float) p_Value;
					break;

				case 3835059573:
					InitalSpeed = (float) p_Value;
					break;

				case 4144947226:
					IsAiAllowedOutside = (bool) p_Value;
					break;

				case 3554635554:
					IsTeamSpecific = (bool) p_Value;
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
				case 2881356526:
					return MaxRandomSpawnHeight;

				case 2780846849:
					return SpawnHeight;

				case 2769825281:
					return TimeToReturn;

				case 1751079062:
					return DeserterProjectile;

				case 2089309528:
					return Team;

				case 4030357871:
					return StrikeRadius;

				case 3835059573:
					return InitalSpeed;

				case 4144947226:
					return IsAiAllowedOutside;

				case 3554635554:
					return IsTeamSpecific;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2881356526:
					return typeof(CombatAreaTriggerEntityData).GetProperty(nameof(MaxRandomSpawnHeight));

				case 2780846849:
					return typeof(CombatAreaTriggerEntityData).GetProperty(nameof(SpawnHeight));

				case 2769825281:
					return typeof(CombatAreaTriggerEntityData).GetProperty(nameof(TimeToReturn));

				case 1751079062:
					return typeof(CombatAreaTriggerEntityData).GetProperty(nameof(DeserterProjectile));

				case 2089309528:
					return typeof(CombatAreaTriggerEntityData).GetProperty(nameof(Team));

				case 4030357871:
					return typeof(CombatAreaTriggerEntityData).GetProperty(nameof(StrikeRadius));

				case 3835059573:
					return typeof(CombatAreaTriggerEntityData).GetProperty(nameof(InitalSpeed));

				case 4144947226:
					return typeof(CombatAreaTriggerEntityData).GetProperty(nameof(IsAiAllowedOutside));

				case 3554635554:
					return typeof(CombatAreaTriggerEntityData).GetProperty(nameof(IsTeamSpecific));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
