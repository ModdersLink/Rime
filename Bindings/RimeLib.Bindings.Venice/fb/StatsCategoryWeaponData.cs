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
	[ContainerType(4, 36)]
	public class StatsCategoryWeaponData : 
		StatsCategoryGuidData
	{
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint SoldierWeaponId { get; set; }

		[ContainerField(28)]
		public CtrRef<CriteriaGateList> AccessoryUnlockGates { get; set; } = new();

		[ContainerField(32)]
		public List<BasicUnlockInfo> UnlocksInfo { get; set; } = new();

		public static void Deserialize(StatsCategoryWeaponData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SoldierWeaponId = p_Reader.ReadUInt32();
			p_Instance.AccessoryUnlockGates.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.UnlocksInfo.Clear();
			(RimeReader Reader, uint Count) s_UnlocksInfo = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_UnlocksInfo.Count; ++i)
			{
				var s_Value = new BasicUnlockInfo();
				fb.BasicUnlockInfo.Deserialize(s_Value, s_UnlocksInfo.Reader, p_Parser);
				p_Instance.UnlocksInfo.Add(s_Value);
			}
			
			s_UnlocksInfo.Reader.Dispose();
		}

	}
}
