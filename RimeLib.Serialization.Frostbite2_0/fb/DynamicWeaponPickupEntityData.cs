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
	public class DynamicWeaponPickupEntityData :
		PickupEntityData
	{
		[ContainerField(176), JsonProperty(Order = 176)]
		public List<DynamicWeaponPickupSlotData> WeaponSlots { get; set; } = new();

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public bool KeepAmmoState { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_WeaponSlots = p_EbxWriter.GetArrayWriter(WeaponSlots.GetType(), WeaponSlots.Count);
			p_Writer.Write(s_WeaponSlots.ArrayIndex);
			foreach (var s_Entry in WeaponSlots)
			{
				s_Entry.Serialize(s_WeaponSlots.Writer, p_EbxWriter);
			}
			p_Writer.Write(KeepAmmoState);
			p_Writer.WriteNullBytes(11);
		}
	}
}
