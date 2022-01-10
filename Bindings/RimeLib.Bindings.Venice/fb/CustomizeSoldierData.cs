///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 48)]
	public class CustomizeSoldierData : 
		CustomizeCharacterData
	{
		[ContainerField(32)]
		public List<UnlockWeaponAndSlot> Weapons { get; set; } = new();

		[ContainerField(36)]
		public WeaponSlot ActiveSlot { get; set; } = new();

		[ContainerField(40)]
		public CtrRef<PickupEntityAsset> DeathPickup { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable]
		public bool RemoveAllExistingWeapons { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable]
		public bool DisableDeathPickup { get; set; }

		public static void Deserialize(CustomizeSoldierData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Weapons.Clear();
			(RimeReader Reader, uint Count) s_Weapons = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Weapons.Count; ++i)
			{
				var s_Value = new UnlockWeaponAndSlot();
				fb.UnlockWeaponAndSlot.Deserialize(s_Value, s_Weapons.Reader, p_Parser);
				p_Instance.Weapons.Add(s_Value);
			}
			
			s_Weapons.Reader.Dispose();
			p_Instance.ActiveSlot = (WeaponSlot) p_Reader.ReadInt32();
			p_Instance.DeathPickup.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.RemoveAllExistingWeapons = p_Reader.ReadBool();
			p_Instance.DisableDeathPickup = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
