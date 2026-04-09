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
	[ContainerType(4, 212)]
	public partial class GunSwayModifierData :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<UnlockAssetBase> _UnlockAsset = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private GunSwayStanceZoomModifierData _StandZoomModifier = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private GunSwayStanceZoomModifierData _StandNoZoomModifier = new();

		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private GunSwayStanceZoomModifierData _CrouchZoomModifier = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private GunSwayStanceZoomModifierData _CrouchNoZoomModifier = new();

		[ObservableProperty]
		[property: ContainerField(144), JsonProperty(Order = 144)]
		private GunSwayStanceZoomModifierData _ProneZoomModifier = new();

		[ObservableProperty]
		[property: ContainerField(176), JsonProperty(Order = 176)]
		private GunSwayStanceZoomModifierData _ProneNoZoomModifier = new();

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private bool _OnlyInSupportedShooting;

		[ObservableProperty]
		[property: ContainerField(209), LayoutImmutable, Blittable, JsonProperty(Order = 209)]
		private bool _OnlyOnWeaponLightEnabled;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(UnlockAsset));
			StandZoomModifier.Serialize(p_Writer, p_EbxWriter);
			StandNoZoomModifier.Serialize(p_Writer, p_EbxWriter);
			CrouchZoomModifier.Serialize(p_Writer, p_EbxWriter);
			CrouchNoZoomModifier.Serialize(p_Writer, p_EbxWriter);
			ProneZoomModifier.Serialize(p_Writer, p_EbxWriter);
			ProneNoZoomModifier.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(OnlyInSupportedShooting);
			p_Writer.Write(OnlyOnWeaponLightEnabled);
			p_Writer.WriteNullBytes(2);
		}
	}
}
