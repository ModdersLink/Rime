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
    [ContainerType(4)]
	public class TeamData : 
		TeamAsset
	{
		[ContainerField(12)]
		public CtrRef<SoldierBlueprint> Soldier { get; set; } = new CtrRef<SoldierBlueprint>(); // 0xC (12)
		
		[ContainerField(16)]
		public FactionId Faction { get; set; } = new FactionId(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<SoldierCustomizationAsset> SoldierCustomization { get; set; } = new RefArray<SoldierCustomizationAsset>(); // 0x14 (20)
		
		[ContainerField(24)]
		public RefArray<VehicleCustomizationAsset> VehicleCustomization { get; set; } = new RefArray<VehicleCustomizationAsset>(); // 0x18 (24)
		
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
