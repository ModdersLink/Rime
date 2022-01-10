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
	[ContainerType(16, 192)]
	public class DynamicWeaponPickupEntityData : 
		PickupEntityData
	{
		[ContainerField(176)]
		public List<DynamicWeaponPickupSlotData> WeaponSlots { get; set; } = new();

		[ContainerField(180), LayoutImmutable, Blittable]
		public bool KeepAmmoState { get; set; }

		public static void Deserialize(DynamicWeaponPickupEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.WeaponSlots.Clear();
			(RimeReader Reader, uint Count) s_WeaponSlots = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_WeaponSlots.Count; ++i)
			{
				var s_Value = new DynamicWeaponPickupSlotData();
				fb.DynamicWeaponPickupSlotData.Deserialize(s_Value, s_WeaponSlots.Reader, p_Parser);
				p_Instance.WeaponSlots.Add(s_Value);
			}
			
			s_WeaponSlots.Reader.Dispose();
			p_Instance.KeepAmmoState = p_Reader.ReadBool();
			p_Reader.Seek(11, SeekOrigin.Current);
		}

	}
}
