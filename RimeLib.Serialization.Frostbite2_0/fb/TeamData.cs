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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 28)]
	public partial class TeamData :
		TeamAsset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<SoldierBlueprint> _Soldier = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private FactionId _Faction = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private RefArray<SoldierCustomizationAsset> _SoldierCustomization = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private RefArray<VehicleCustomizationAsset> _VehicleCustomization = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Soldier));
			p_Writer.Write((int) Faction);
			(RimeWriter Writer, uint ArrayIndex) s_SoldierCustomization = p_EbxWriter.GetArrayWriter(SoldierCustomization.GetType(), SoldierCustomization.Count);
			p_Writer.Write(s_SoldierCustomization.ArrayIndex);
			foreach (var s_Entry in SoldierCustomization)
			{
				s_SoldierCustomization.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_VehicleCustomization = p_EbxWriter.GetArrayWriter(VehicleCustomization.GetType(), VehicleCustomization.Count);
			p_Writer.Write(s_VehicleCustomization.ArrayIndex);
			foreach (var s_Entry in VehicleCustomization)
			{
				s_VehicleCustomization.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
