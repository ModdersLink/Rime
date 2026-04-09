///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 48)]
	public partial class CustomizeSoldierData :
		CustomizeCharacterData
	{
		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private List<UnlockWeaponAndSlot> _Weapons = new();

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private WeaponSlot _ActiveSlot = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private CtrRef<PickupEntityAsset> _DeathPickup = new();

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private bool _RemoveAllExistingWeapons;

		[ObservableProperty]
		[property: ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		private bool _DisableDeathPickup;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Weapons = p_EbxWriter.GetArrayWriter(Weapons.GetType(), Weapons.Count);
			p_Writer.Write(s_Weapons.ArrayIndex);
			foreach (var s_Entry in Weapons)
			{
				s_Entry.Serialize(s_Weapons.Writer, p_EbxWriter);
			}
			p_Writer.Write((int) ActiveSlot);
			p_Writer.Write(p_EbxWriter.WriteImport(DeathPickup));
			p_Writer.Write(RemoveAllExistingWeapons);
			p_Writer.Write(DisableDeathPickup);
			p_Writer.WriteNullBytes(2);
		}
	}
}
