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
	[ContainerType(4, 16)]
	public class WeaponFiringEffectsModifier : 
		WeaponModifierBase
	{
		[ContainerField(8)]
		public List<FireEffectData> FireEffects1p { get; set; } = new();

		[ContainerField(12)]
		public List<FireEffectData> FireEffects3p { get; set; } = new();

		public static void Deserialize(WeaponFiringEffectsModifier p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.FireEffects1p.Clear();
			(RimeReader Reader, uint Count) s_FireEffects1p = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_FireEffects1p.Count; ++i)
			{
				var s_Value = new FireEffectData();
				fb.FireEffectData.Deserialize(s_Value, s_FireEffects1p.Reader, p_Parser);
				p_Instance.FireEffects1p.Add(s_Value);
			}
			
			s_FireEffects1p.Reader.Dispose();
			p_Instance.FireEffects3p.Clear();
			(RimeReader Reader, uint Count) s_FireEffects3p = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_FireEffects3p.Count; ++i)
			{
				var s_Value = new FireEffectData();
				fb.FireEffectData.Deserialize(s_Value, s_FireEffects3p.Reader, p_Parser);
				p_Instance.FireEffects3p.Add(s_Value);
			}
			
			s_FireEffects3p.Reader.Dispose();
		}

	}
}
