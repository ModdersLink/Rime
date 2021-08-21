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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class TeamData : 
		TeamAsset
	{
		protected CtrRef<SoldierBlueprint> m_Soldier = new CtrRef<SoldierBlueprint>();
		[ContainerField(Name: "Soldier", Offset: 12, NameHash: 2844639087, Flags: 53)]
		public CtrRef<SoldierBlueprint> Soldier { get { return m_Soldier; } set { if (OnPropertyChanging("TeamData." + nameof(Soldier), this, m_Soldier, value)) m_Soldier = value; } } // 0xC (12)
		
		protected FactionId m_Faction = new FactionId();
		[ContainerField(Name: "Faction", Offset: 16, NameHash: 1419764413, Flags: 137)]
		public FactionId Faction { get { return m_Faction; } set { if (OnPropertyChanging("TeamData." + nameof(Faction), this, m_Faction, value)) m_Faction = value; } } // 0x10 (16)
		
		protected RefArray<SoldierCustomizationAsset> m_SoldierCustomization = new RefArray<SoldierCustomizationAsset>();
		[ContainerField(Name: "SoldierCustomization", Offset: 20, NameHash: 2197823922, Flags: 65)]
		public RefArray<SoldierCustomizationAsset> SoldierCustomization { get { return m_SoldierCustomization; } set { if (OnPropertyChanging("TeamData." + nameof(SoldierCustomization), this, m_SoldierCustomization, value)) m_SoldierCustomization = value; } } // 0x14 (20)
		
		protected RefArray<VehicleCustomizationAsset> m_VehicleCustomization = new RefArray<VehicleCustomizationAsset>();
		[ContainerField(Name: "VehicleCustomization", Offset: 24, NameHash: 448553568, Flags: 65)]
		public RefArray<VehicleCustomizationAsset> VehicleCustomization { get { return m_VehicleCustomization; } set { if (OnPropertyChanging("TeamData." + nameof(VehicleCustomization), this, m_VehicleCustomization, value)) m_VehicleCustomization = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2844639087:
					Soldier = (CtrRef<SoldierBlueprint>) p_Value;
					break;

				case 1419764413:
					Faction = (FactionId) Enum.ToObject(typeof(FactionId), p_Value);
					break;

				case 2197823922:
					SoldierCustomization = (RefArray<SoldierCustomizationAsset>) p_Value;
					break;

				case 448553568:
					VehicleCustomization = (RefArray<VehicleCustomizationAsset>) p_Value;
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
				case 2844639087:
					return Soldier;

				case 1419764413:
					return Faction;

				case 2197823922:
					return SoldierCustomization;

				case 448553568:
					return VehicleCustomization;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2844639087:
					return typeof(TeamData).GetProperty(nameof(Soldier));

				case 1419764413:
					return typeof(TeamData).GetProperty(nameof(Faction));

				case 2197823922:
					return typeof(TeamData).GetProperty(nameof(SoldierCustomization));

				case 448553568:
					return typeof(TeamData).GetProperty(nameof(VehicleCustomization));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
