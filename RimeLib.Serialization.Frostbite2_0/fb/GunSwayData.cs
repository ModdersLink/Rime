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
	[ContainerType(4, 808)]
	public partial class GunSwayData :
		WeaponSwayData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private GunSwayStandData _Stand = new();

		[ObservableProperty]
		[property: ContainerField(288), JsonProperty(Order = 288)]
		private GunSwayCrouchProneData _Crouch = new();

		[ObservableProperty]
		[property: ContainerField(440), JsonProperty(Order = 440)]
		private GunSwayCrouchProneData _Prone = new();

		[ObservableProperty]
		[property: ContainerField(592), JsonProperty(Order = 592)]
		private GunSwayStanceTransition _ProneToCrouch = new();

		[ObservableProperty]
		[property: ContainerField(612), JsonProperty(Order = 612)]
		private GunSwayStanceTransition _ProneToStand = new();

		[ObservableProperty]
		[property: ContainerField(632), JsonProperty(Order = 632)]
		private GunSwayStanceTransition _CrouchToProne = new();

		[ObservableProperty]
		[property: ContainerField(652), JsonProperty(Order = 652)]
		private GunSwayStanceTransition _CrouchToStand = new();

		[ObservableProperty]
		[property: ContainerField(672), JsonProperty(Order = 672)]
		private GunSwayStanceTransition _StandToProne = new();

		[ObservableProperty]
		[property: ContainerField(692), JsonProperty(Order = 692)]
		private GunSwayStanceTransition _StandToCrouch = new();

		[ObservableProperty]
		[property: ContainerField(712), JsonProperty(Order = 712)]
		private GunSwayStanceZoomModifierData _SuppressionModifierUnzoomed = new();

		[ObservableProperty]
		[property: ContainerField(744), JsonProperty(Order = 744)]
		private GunSwayStanceZoomModifierData _SuppressionModifierZoomed = new();

		[ObservableProperty]
		[property: ContainerField(776), JsonProperty(Order = 776)]
		private RefArray<GunSwayModifierData> _Modifiers = new();

		[ObservableProperty]
		[property: ContainerField(780), LayoutImmutable, Blittable, JsonProperty(Order = 780)]
		private float _DeviationScaleFactorZoom;

		[ObservableProperty]
		[property: ContainerField(784), LayoutImmutable, Blittable, JsonProperty(Order = 784)]
		private float _GameplayDeviationScaleFactorZoom;

		[ObservableProperty]
		[property: ContainerField(788), LayoutImmutable, Blittable, JsonProperty(Order = 788)]
		private float _DeviationScaleFactorNoZoom;

		[ObservableProperty]
		[property: ContainerField(792), LayoutImmutable, Blittable, JsonProperty(Order = 792)]
		private float _GameplayDeviationScaleFactorNoZoom;

		[ObservableProperty]
		[property: ContainerField(796), LayoutImmutable, Blittable, JsonProperty(Order = 796)]
		private float _ShootingRecoilDecreaseScale;

		[ObservableProperty]
		[property: ContainerField(800), LayoutImmutable, Blittable, JsonProperty(Order = 800)]
		private float _FirstShotRecoilMultiplier;

		[ObservableProperty]
		[property: ContainerField(804), JsonProperty(Order = 804)]
		private CtrRef<CameraRecoilData> _CameraRecoil = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Stand.Serialize(p_Writer, p_EbxWriter);
			Crouch.Serialize(p_Writer, p_EbxWriter);
			Prone.Serialize(p_Writer, p_EbxWriter);
			ProneToCrouch.Serialize(p_Writer, p_EbxWriter);
			ProneToStand.Serialize(p_Writer, p_EbxWriter);
			CrouchToProne.Serialize(p_Writer, p_EbxWriter);
			CrouchToStand.Serialize(p_Writer, p_EbxWriter);
			StandToProne.Serialize(p_Writer, p_EbxWriter);
			StandToCrouch.Serialize(p_Writer, p_EbxWriter);
			SuppressionModifierUnzoomed.Serialize(p_Writer, p_EbxWriter);
			SuppressionModifierZoomed.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Modifiers = p_EbxWriter.GetArrayWriter(Modifiers.GetType(), Modifiers.Count);
			p_Writer.Write(s_Modifiers.ArrayIndex);
			foreach (var s_Entry in Modifiers)
			{
				s_Modifiers.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(DeviationScaleFactorZoom);
			p_Writer.Write(GameplayDeviationScaleFactorZoom);
			p_Writer.Write(DeviationScaleFactorNoZoom);
			p_Writer.Write(GameplayDeviationScaleFactorNoZoom);
			p_Writer.Write(ShootingRecoilDecreaseScale);
			p_Writer.Write(FirstShotRecoilMultiplier);
			p_Writer.Write(p_EbxWriter.WriteImport(CameraRecoil));
		}
	}
}
