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
	[ContainerType(4, 140)]
	public partial class GunSwayBaseMoveJumpData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private GunSwayDispersionData _BaseValue = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private GunSwayDispersionData _Moving = new();
		
		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private GunSwayDispersionData _Jumping = new();
		
		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private GunSwayDispersionData _Sprinting = new();
		
		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private GunSwayDispersionData _VaultingSmallObject = new();
		
		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private GunSwayDispersionData _VaultingMediumObject = new();
		
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private GunSwayRecoilData _Recoil = new();
		
		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private GunSwayLagData _GunSwayLag = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			BaseValue.Serialize(p_Writer, p_EbxWriter);
			Moving.Serialize(p_Writer, p_EbxWriter);
			Jumping.Serialize(p_Writer, p_EbxWriter);
			Sprinting.Serialize(p_Writer, p_EbxWriter);
			VaultingSmallObject.Serialize(p_Writer, p_EbxWriter);
			VaultingMediumObject.Serialize(p_Writer, p_EbxWriter);
			Recoil.Serialize(p_Writer, p_EbxWriter);
			GunSwayLag.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
