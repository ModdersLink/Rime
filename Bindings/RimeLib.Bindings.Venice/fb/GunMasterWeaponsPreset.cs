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
	[ContainerType(4, 8)]
	public class GunMasterWeaponsPreset
	{
		[ContainerField(0)]
		public List<GunMasterLevelInfo> GunMasterLevelInfos { get; set; } = new();
		
		[ContainerField(4)]
		public List<CtrRef<CustomizeSoldierData>> LevelOverrides { get; set; } = new();
		
		public static void Deserialize(GunMasterWeaponsPreset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.GunMasterLevelInfos.Clear();
			(RimeReader Reader, uint Count) s_GunMasterLevelInfos = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_GunMasterLevelInfos.Count; ++i)
			{
				var s_Value = new GunMasterLevelInfo();
				fb.GunMasterLevelInfo.Deserialize(s_Value, s_GunMasterLevelInfos.Reader, p_Parser);
				p_Instance.GunMasterLevelInfos.Add(s_Value);
			}
			
			s_GunMasterLevelInfos.Reader.Dispose();
			p_Instance.LevelOverrides.Clear();
			(RimeReader Reader, uint Count) s_LevelOverrides = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_LevelOverrides.Count; ++i)
			{
				var s_CtrRef = new CtrRef<CustomizeSoldierData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_LevelOverrides.Reader.ReadUInt32()));
				p_Instance.LevelOverrides.Add(s_CtrRef);
			}
			
			s_LevelOverrides.Reader.Dispose();
		}
	}
}
