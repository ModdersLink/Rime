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
	[ContainerType(4, 28)]
	public class TeamData : 
		TeamAsset
	{
		[ContainerField(12)]
		public CtrRef<SoldierBlueprint> Soldier { get; set; } = new();

		[ContainerField(16)]
		public FactionId Faction { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<SoldierCustomizationAsset>> SoldierCustomization { get; set; } = new();

		[ContainerField(24)]
		public List<CtrRef<VehicleCustomizationAsset>> VehicleCustomization { get; set; } = new();

		public static void Deserialize(TeamData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Soldier.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Faction = (FactionId) p_Reader.ReadInt32();
			p_Instance.SoldierCustomization.Clear();
			(RimeReader Reader, uint Count) s_SoldierCustomization = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_SoldierCustomization.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SoldierCustomizationAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_SoldierCustomization.Reader.ReadUInt32()));
				p_Instance.SoldierCustomization.Add(s_CtrRef);
			}
			
			s_SoldierCustomization.Reader.Dispose();
			p_Instance.VehicleCustomization.Clear();
			(RimeReader Reader, uint Count) s_VehicleCustomization = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_VehicleCustomization.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VehicleCustomizationAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_VehicleCustomization.Reader.ReadUInt32()));
				p_Instance.VehicleCustomization.Add(s_CtrRef);
			}
			
			s_VehicleCustomization.Reader.Dispose();
		}

	}
}
