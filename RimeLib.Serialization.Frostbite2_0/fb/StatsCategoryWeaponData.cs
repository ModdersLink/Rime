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
	[ContainerType(4, 36)]
	public class StatsCategoryWeaponData :
		StatsCategoryGuidData
	{
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint SoldierWeaponId { get; set; }

		[ContainerField(28), JsonProperty(Order = 28)]
		public CtrRef<CriteriaGateList> AccessoryUnlockGates { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public List<BasicUnlockInfo> UnlocksInfo { get; set; } = new();

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
