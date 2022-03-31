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
	[ContainerType(16, 128)]
	public class WeaponEntityData :
		GameEntityData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public List<WeaponStateData> WeaponStates { get; set; } = new();

		[ContainerField(100), JsonProperty(Order = 100)]
		public WeaponClassEnum WeaponClass { get; set; } = new();

		[ContainerField(104), JsonProperty(Order = 104)]
		public CtrRef<GameAIWeaponData> AIData { get; set; } = new();

		[ContainerField(108), JsonProperty(Order = 108)]
		public CtrRef<WeaponFiringData> WeaponFiring { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public CtrRef<WeaponData> CustomWeaponType { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_WeaponStates = p_EbxWriter.GetArrayWriter(WeaponStates.GetType(), WeaponStates.Count);
			p_Writer.Write(s_WeaponStates.ArrayIndex);
			foreach (var s_Entry in WeaponStates)
			{
				s_Entry.Serialize(s_WeaponStates.Writer, p_EbxWriter);
			}
			p_Writer.Write((int) WeaponClass);
			p_Writer.Write(p_EbxWriter.WriteImport(AIData));
			p_Writer.Write(p_EbxWriter.WriteImport(WeaponFiring));
			p_Writer.Write(p_EbxWriter.WriteImport(CustomWeaponType));
			p_Writer.WriteNullBytes(12);
		}
	}
}
