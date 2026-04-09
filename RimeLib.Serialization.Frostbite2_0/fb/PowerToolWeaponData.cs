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
	public partial class PowerToolWeaponData :
		WeaponData
	{
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<SoundAsset> _RepairSound = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<SoundAsset> _RepairCompletedSound = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private CtrRef<SoundAsset> _DamageSound = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private CtrRef<MaterialContainerPair> _RepairMaterialPair = new();

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private bool _PlayFireEffectOnRepairOnly;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(RepairSound));
			p_Writer.Write(p_EbxWriter.WriteImport(RepairCompletedSound));
			p_Writer.Write(p_EbxWriter.WriteImport(DamageSound));
			p_Writer.Write(p_EbxWriter.WriteImport(RepairMaterialPair));
			p_Writer.Write(PlayFireEffectOnRepairOnly);
			p_Writer.WriteNullBytes(3);
		}
	}
}
