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
	[ContainerType(4, 8)]
	public class GunMasterWeaponsPreset :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public List<GunMasterLevelInfo> GunMasterLevelInfos { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public RefArray<CustomizeSoldierData> LevelOverrides { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_GunMasterLevelInfos = p_EbxWriter.GetArrayWriter(GunMasterLevelInfos.GetType(), GunMasterLevelInfos.Count);
			p_Writer.Write(s_GunMasterLevelInfos.ArrayIndex);
			foreach (var s_Entry in GunMasterLevelInfos)
			{
				s_Entry.Serialize(s_GunMasterLevelInfos.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_LevelOverrides = p_EbxWriter.GetArrayWriter(LevelOverrides.GetType(), LevelOverrides.Count);
			p_Writer.Write(s_LevelOverrides.ArrayIndex);
			foreach (var s_Entry in LevelOverrides)
			{
				s_LevelOverrides.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
