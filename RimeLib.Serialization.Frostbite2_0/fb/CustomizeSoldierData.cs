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

namespace fb
{
	[ContainerType(4, 48)]
	public class CustomizeSoldierData :
		CustomizeCharacterData
	{
		[ContainerField(32), JsonProperty(Order = 32)]
		public List<UnlockWeaponAndSlot> Weapons { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public WeaponSlot ActiveSlot { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public CtrRef<PickupEntityAsset> DeathPickup { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public bool RemoveAllExistingWeapons { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		public bool DisableDeathPickup { get; set; }

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
