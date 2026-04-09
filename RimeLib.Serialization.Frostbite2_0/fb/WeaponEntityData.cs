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
	[ContainerType(16, 128)]
	public partial class WeaponEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private List<WeaponStateData> _WeaponStates = new();

		[ObservableProperty]
		[property: ContainerField(100), JsonProperty(Order = 100)]
		private WeaponClassEnum _WeaponClass = new();

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private CtrRef<GameAIWeaponData> _AIData = new();

		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private CtrRef<WeaponFiringData> _WeaponFiring = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private CtrRef<WeaponData> _CustomWeaponType = new();

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
