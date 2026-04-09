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
	public partial class WeaponFiringEffectsModifier :
		WeaponModifierBase
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private List<FireEffectData> _FireEffects1p = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<FireEffectData> _FireEffects3p = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_FireEffects1p = p_EbxWriter.GetArrayWriter(FireEffects1p.GetType(), FireEffects1p.Count);
			p_Writer.Write(s_FireEffects1p.ArrayIndex);
			foreach (var s_Entry in FireEffects1p)
			{
				s_Entry.Serialize(s_FireEffects1p.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_FireEffects3p = p_EbxWriter.GetArrayWriter(FireEffects3p.GetType(), FireEffects3p.Count);
			p_Writer.Write(s_FireEffects3p.ArrayIndex);
			foreach (var s_Entry in FireEffects3p)
			{
				s_Entry.Serialize(s_FireEffects3p.Writer, p_EbxWriter);
			}
		}
	}
}
