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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class SoldierWeaponSwitchingData :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<WeaponSwitchingMapData> SwitchMap { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<DirectWeaponSwitchingMapData> DirectSwitchMap { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float SwitchToGadgetCooldownTime { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_SwitchMap = p_EbxWriter.GetArrayWriter(SwitchMap.GetType(), SwitchMap.Count);
			p_Writer.Write(s_SwitchMap.ArrayIndex);
			foreach (var s_Entry in SwitchMap)
			{
				s_Entry.Serialize(s_SwitchMap.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_DirectSwitchMap = p_EbxWriter.GetArrayWriter(DirectSwitchMap.GetType(), DirectSwitchMap.Count);
			p_Writer.Write(s_DirectSwitchMap.ArrayIndex);
			foreach (var s_Entry in DirectSwitchMap)
			{
				s_Entry.Serialize(s_DirectSwitchMap.Writer, p_EbxWriter);
			}
			p_Writer.Write(SwitchToGadgetCooldownTime);
		}
	}
}
