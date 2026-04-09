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
	[ContainerType(4, 68)]
	public partial class HudData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private float _CrosshairScaleMin;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		private float _CrosshairScaleMax;
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _CrosshairOpacityMin;
		
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _CrosshairOpacityMax;
		
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _CrosshairOpacityModifier;
		
		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		private string _CrosshairTypeId = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		private string _WeaponClass = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _CameraShakeModifier;
		
		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _SeaLevelAltFreq;
		
		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _LowAmmoWarning;
		
		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _ReloadPrompt;
		
		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private int _RenderTargetIndex;
		
		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private CtrRef<UIPartPropertyList> _HudPropertyList = new();
		
		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private bool _ShowMinimap;
		
		[ObservableProperty]
		[property: ContainerField(53), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
		private bool _InfiniteAmmo;
		
		[ObservableProperty]
		[property: ContainerField(54), LayoutImmutable, Blittable, JsonProperty(Order = 54)]
		private bool _HideCrosshairWhenAimOnFriend;
		
		[ObservableProperty]
		[property: ContainerField(55), LayoutImmutable, Blittable, JsonProperty(Order = 55)]
		private bool _HideAmmo;
		
		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private bool _UseRangeMeter;
		
		[ObservableProperty]
		[property: ContainerField(57), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
		private bool _UsePredictedSight;
		
		[ObservableProperty]
		[property: ContainerField(58), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
		private bool _UseWeaponOrientations;
		
		[ObservableProperty]
		[property: ContainerField(59), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
		private bool _UseVelocityVectorMarker;
		
		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private bool _UseLockingController;
		
		[ObservableProperty]
		[property: ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		private bool _UseThrust;
		
		[ObservableProperty]
		[property: ContainerField(62), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
		private bool _UseGForce;
		
		[ObservableProperty]
		[property: ContainerField(63), LayoutImmutable, Blittable, JsonProperty(Order = 63)]
		private bool _UseSkidSlip;
		
		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private bool _UseClimbRate;
		
		[ObservableProperty]
		[property: ContainerField(65), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
		private bool _UseAimWarning;
		
		[ObservableProperty]
		[property: ContainerField(66), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
		private bool _UseRenderTarget;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(CrosshairScaleMin);
			p_Writer.Write(CrosshairScaleMax);
			p_Writer.Write(CrosshairOpacityMin);
			p_Writer.Write(CrosshairOpacityMax);
			p_Writer.Write(CrosshairOpacityModifier);
			p_Writer.Write(p_EbxWriter.WriteString(CrosshairTypeId));
			p_Writer.Write(p_EbxWriter.WriteString(WeaponClass));
			p_Writer.Write(CameraShakeModifier);
			p_Writer.Write(SeaLevelAltFreq);
			p_Writer.Write(LowAmmoWarning);
			p_Writer.Write(ReloadPrompt);
			p_Writer.Write(RenderTargetIndex);
			p_Writer.Write(p_EbxWriter.WriteImport(HudPropertyList));
			p_Writer.Write(ShowMinimap);
			p_Writer.Write(InfiniteAmmo);
			p_Writer.Write(HideCrosshairWhenAimOnFriend);
			p_Writer.Write(HideAmmo);
			p_Writer.Write(UseRangeMeter);
			p_Writer.Write(UsePredictedSight);
			p_Writer.Write(UseWeaponOrientations);
			p_Writer.Write(UseVelocityVectorMarker);
			p_Writer.Write(UseLockingController);
			p_Writer.Write(UseThrust);
			p_Writer.Write(UseGForce);
			p_Writer.Write(UseSkidSlip);
			p_Writer.Write(UseClimbRate);
			p_Writer.Write(UseAimWarning);
			p_Writer.Write(UseRenderTarget);
			p_Writer.WriteNullBytes(1);
		}
	}
}
