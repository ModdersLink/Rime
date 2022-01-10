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
	[ContainerType(4, 16)]
	public class GunMasterKillCounterEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public List<GunMasterWeaponsPreset> WeaponsPreset { get; set; } = new();

		public static void Deserialize(GunMasterKillCounterEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.WeaponsPreset.Clear();
			(RimeReader Reader, uint Count) s_WeaponsPreset = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_WeaponsPreset.Count; ++i)
			{
				var s_Value = new GunMasterWeaponsPreset();
				fb.GunMasterWeaponsPreset.Deserialize(s_Value, s_WeaponsPreset.Reader, p_Parser);
				p_Instance.WeaponsPreset.Add(s_Value);
			}
			
			s_WeaponsPreset.Reader.Dispose();
		}

	}
}
