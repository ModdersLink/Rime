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
	[ContainerType(16, 192)]
	public class WeaponUnlockPickupEntityData :
		PickupEntityData
	{
		[ContainerField(176), JsonProperty(Order = 176)]
		public List<WeaponUnlockPickupData> Weapons { get; set; } = new();

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public bool UseForPersistence { get; set; }

		[ContainerField(181), LayoutImmutable, Blittable, JsonProperty(Order = 181)]
		public bool RandomlySelectOneWeapon { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Weapons = p_EbxWriter.GetArrayWriter(Weapons.GetType(), Weapons.Count);
			p_Writer.Write(s_Weapons.ArrayIndex);
			foreach (var s_Entry in Weapons)
			{
				s_Entry.Serialize(s_Weapons.Writer, p_EbxWriter);
			}
			p_Writer.Write(UseForPersistence);
			p_Writer.Write(RandomlySelectOneWeapon);
			p_Writer.WriteNullBytes(10);
		}
	}
}
