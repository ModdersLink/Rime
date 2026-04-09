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
	[ContainerType(4, 36)]
	public partial class StatsCategoryWeaponData :
		StatsCategoryGuidData
	{
		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _SoldierWeaponId;

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private CtrRef<CriteriaGateList> _AccessoryUnlockGates = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private List<BasicUnlockInfo> _UnlocksInfo = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SoldierWeaponId);
			p_Writer.Write(p_EbxWriter.WriteImport(AccessoryUnlockGates));
			(RimeWriter Writer, uint ArrayIndex) s_UnlocksInfo = p_EbxWriter.GetArrayWriter(UnlocksInfo.GetType(), UnlocksInfo.Count);
			p_Writer.Write(s_UnlocksInfo.ArrayIndex);
			foreach (var s_Entry in UnlocksInfo)
			{
				s_Entry.Serialize(s_UnlocksInfo.Writer, p_EbxWriter);
			}
		}
	}
}
