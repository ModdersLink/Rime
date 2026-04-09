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
	[ContainerType(4, 24)]
	public partial class DogTagsAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<StatsCategoryWeaponData> _MeleeKillWeapon = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private RefArray<BasicDogTagData> _BasicDogTags = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private RefArray<AdvancedDogTagData> _AdvancedDogTags = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(MeleeKillWeapon));
			(RimeWriter Writer, uint ArrayIndex) s_BasicDogTags = p_EbxWriter.GetArrayWriter(BasicDogTags.GetType(), BasicDogTags.Count);
			p_Writer.Write(s_BasicDogTags.ArrayIndex);
			foreach (var s_Entry in BasicDogTags)
			{
				s_BasicDogTags.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_AdvancedDogTags = p_EbxWriter.GetArrayWriter(AdvancedDogTags.GetType(), AdvancedDogTags.Count);
			p_Writer.Write(s_AdvancedDogTags.ArrayIndex);
			foreach (var s_Entry in AdvancedDogTags)
			{
				s_AdvancedDogTags.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
