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
	[ContainerType(4, 16)]
	public class WeaponFiringEffectsModifier :
		WeaponModifierBase
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public List<FireEffectData> FireEffects1p { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public List<FireEffectData> FireEffects3p { get; set; } = new();

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
