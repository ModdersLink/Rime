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
	[ContainerType(4, 16)]
	public partial class WeaponSwitchingMapData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private WeaponSwitchingEnum _FromWeapon = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private EntryInputActionEnum _Action = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private List<WeaponSwitchingEnum> _ToWeapon = new();
		
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private bool _FireAndSwitchBackToPrev;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) FromWeapon);
			p_Writer.Write((int) Action);
			(RimeWriter Writer, uint ArrayIndex) s_ToWeapon = p_EbxWriter.GetArrayWriter(ToWeapon.GetType(), ToWeapon.Count);
			p_Writer.Write(s_ToWeapon.ArrayIndex);
			foreach (var s_Entry in ToWeapon)
			{
				s_ToWeapon.Writer.Write((int) s_Entry);
			}
			p_Writer.Write(FireAndSwitchBackToPrev);
			p_Writer.WriteNullBytes(3);
		}
	}
}
