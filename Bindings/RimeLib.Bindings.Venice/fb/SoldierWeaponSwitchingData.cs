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
	[ContainerType(4, 24)]
	public class SoldierWeaponSwitchingData : 
		Asset
	{
		[ContainerField(12)]
		public List<WeaponSwitchingMapData> SwitchMap { get; set; } = new();

		[ContainerField(16)]
		public List<DirectWeaponSwitchingMapData> DirectSwitchMap { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float SwitchToGadgetCooldownTime { get; set; }

		public static void Deserialize(SoldierWeaponSwitchingData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SwitchMap.Clear();
			(RimeReader Reader, uint Count) s_SwitchMap = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_SwitchMap.Count; ++i)
			{
				var s_Value = new WeaponSwitchingMapData();
				fb.WeaponSwitchingMapData.Deserialize(s_Value, s_SwitchMap.Reader, p_Parser);
				p_Instance.SwitchMap.Add(s_Value);
			}
			
			s_SwitchMap.Reader.Dispose();
			p_Instance.DirectSwitchMap.Clear();
			(RimeReader Reader, uint Count) s_DirectSwitchMap = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_DirectSwitchMap.Count; ++i)
			{
				var s_Value = new DirectWeaponSwitchingMapData();
				fb.DirectWeaponSwitchingMapData.Deserialize(s_Value, s_DirectSwitchMap.Reader, p_Parser);
				p_Instance.DirectSwitchMap.Add(s_Value);
			}
			
			s_DirectSwitchMap.Reader.Dispose();
			p_Instance.SwitchToGadgetCooldownTime = p_Reader.ReadSingle();
		}

	}
}
