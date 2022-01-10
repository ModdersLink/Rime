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
	public class WeaponPickupEntityData : 
		PickupEntityData
	{
		[ContainerField(176)]
		public List<WeaponPickupData> Weapons { get; set; } = new();

		[ContainerField(180), LayoutImmutable, Blittable]
		public bool UseForPersistence { get; set; }

		public static void Deserialize(WeaponPickupEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Weapons.Clear();
			(RimeReader Reader, uint Count) s_Weapons = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Weapons.Count; ++i)
			{
				var s_Value = new WeaponPickupData();
				fb.WeaponPickupData.Deserialize(s_Value, s_Weapons.Reader, p_Parser);
				p_Instance.Weapons.Add(s_Value);
			}
			
			s_Weapons.Reader.Dispose();
			p_Instance.UseForPersistence = p_Reader.ReadBool();
			p_Reader.Seek(11, SeekOrigin.Current);
		}

	}
}
