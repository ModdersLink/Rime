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
	public class DamageAreaTriggerEntityData : 
		TriggerEntityData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public float DamagePerSecond { get; set; } // 0x70 (112)
		
		[ContainerField(116)]
		public TeamId TeamOfImmortalCharacters { get; set; } = new TeamId(); // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float DamageTime { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public bool DamageVehicles { get; set; } // 0x7C (124)
		
		[ContainerField(125), LayoutImmutable, Blittable]
		public bool DamageBangers { get; set; } // 0x7D (125)
		
		[ContainerField(126), LayoutImmutable, Blittable]
		public bool ExcludeImmortalCharactersInTeam { get; set; } // 0x7E (126)
		
		[ContainerField(127), LayoutImmutable, Blittable]
		public bool DamageCharacters { get; set; } // 0x7F (127)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public bool ExcludeShieldedSoldiers { get; set; } // 0x80 (128)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1464141113:
					DamagePerSecond = (float) p_Value;
					break;

				case 1833832214:
					TeamOfImmortalCharacters = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 3581575931:
					DamageTime = (float) p_Value;
					break;

				case 1372095173:
					DamageVehicles = (bool) p_Value;
					break;

				case 2480211808:
					DamageBangers = (bool) p_Value;
					break;

				case 2802150974:
					ExcludeImmortalCharactersInTeam = (bool) p_Value;
					break;

				case 3682715684:
					DamageCharacters = (bool) p_Value;
					break;

				case 3210013316:
					ExcludeShieldedSoldiers = (bool) p_Value;
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
				case 1464141113:
					return DamagePerSecond;

				case 1833832214:
					return TeamOfImmortalCharacters;

				case 3581575931:
					return DamageTime;

				case 1372095173:
					return DamageVehicles;

				case 2480211808:
					return DamageBangers;

				case 2802150974:
					return ExcludeImmortalCharactersInTeam;

				case 3682715684:
					return DamageCharacters;

				case 3210013316:
					return ExcludeShieldedSoldiers;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1464141113:
					return typeof(DamageAreaTriggerEntityData).GetProperty(nameof(DamagePerSecond));

				case 1833832214:
					return typeof(DamageAreaTriggerEntityData).GetProperty(nameof(TeamOfImmortalCharacters));

				case 3581575931:
					return typeof(DamageAreaTriggerEntityData).GetProperty(nameof(DamageTime));

				case 1372095173:
					return typeof(DamageAreaTriggerEntityData).GetProperty(nameof(DamageVehicles));

				case 2480211808:
					return typeof(DamageAreaTriggerEntityData).GetProperty(nameof(DamageBangers));

				case 2802150974:
					return typeof(DamageAreaTriggerEntityData).GetProperty(nameof(ExcludeImmortalCharactersInTeam));

				case 3682715684:
					return typeof(DamageAreaTriggerEntityData).GetProperty(nameof(DamageCharacters));

				case 3210013316:
					return typeof(DamageAreaTriggerEntityData).GetProperty(nameof(ExcludeShieldedSoldiers));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
