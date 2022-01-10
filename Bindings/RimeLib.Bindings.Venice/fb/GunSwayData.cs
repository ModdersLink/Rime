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
	[ContainerType(4, 808)]
	public class GunSwayData : 
		WeaponSwayData
	{
		[ContainerField(8)]
		public GunSwayStandData Stand { get; set; } = new();

		[ContainerField(288)]
		public GunSwayCrouchProneData Crouch { get; set; } = new();

		[ContainerField(440)]
		public GunSwayCrouchProneData Prone { get; set; } = new();

		[ContainerField(592)]
		public GunSwayStanceTransition ProneToCrouch { get; set; } = new();

		[ContainerField(612)]
		public GunSwayStanceTransition ProneToStand { get; set; } = new();

		[ContainerField(632)]
		public GunSwayStanceTransition CrouchToProne { get; set; } = new();

		[ContainerField(652)]
		public GunSwayStanceTransition CrouchToStand { get; set; } = new();

		[ContainerField(672)]
		public GunSwayStanceTransition StandToProne { get; set; } = new();

		[ContainerField(692)]
		public GunSwayStanceTransition StandToCrouch { get; set; } = new();

		[ContainerField(712)]
		public GunSwayStanceZoomModifierData SuppressionModifierUnzoomed { get; set; } = new();

		[ContainerField(744)]
		public GunSwayStanceZoomModifierData SuppressionModifierZoomed { get; set; } = new();

		[ContainerField(776)]
		public List<CtrRef<GunSwayModifierData>> Modifiers { get; set; } = new();

		[ContainerField(780), LayoutImmutable, Blittable]
		public float DeviationScaleFactorZoom { get; set; }

		[ContainerField(784), LayoutImmutable, Blittable]
		public float GameplayDeviationScaleFactorZoom { get; set; }

		[ContainerField(788), LayoutImmutable, Blittable]
		public float DeviationScaleFactorNoZoom { get; set; }

		[ContainerField(792), LayoutImmutable, Blittable]
		public float GameplayDeviationScaleFactorNoZoom { get; set; }

		[ContainerField(796), LayoutImmutable, Blittable]
		public float ShootingRecoilDecreaseScale { get; set; }

		[ContainerField(800), LayoutImmutable, Blittable]
		public float FirstShotRecoilMultiplier { get; set; }

		[ContainerField(804)]
		public CtrRef<CameraRecoilData> CameraRecoil { get; set; } = new();

		public static void Deserialize(GunSwayData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.GunSwayStandData.Deserialize(p_Instance.Stand, p_Reader, p_Parser);
			fb.GunSwayCrouchProneData.Deserialize(p_Instance.Crouch, p_Reader, p_Parser);
			fb.GunSwayCrouchProneData.Deserialize(p_Instance.Prone, p_Reader, p_Parser);
			fb.GunSwayStanceTransition.Deserialize(p_Instance.ProneToCrouch, p_Reader, p_Parser);
			fb.GunSwayStanceTransition.Deserialize(p_Instance.ProneToStand, p_Reader, p_Parser);
			fb.GunSwayStanceTransition.Deserialize(p_Instance.CrouchToProne, p_Reader, p_Parser);
			fb.GunSwayStanceTransition.Deserialize(p_Instance.CrouchToStand, p_Reader, p_Parser);
			fb.GunSwayStanceTransition.Deserialize(p_Instance.StandToProne, p_Reader, p_Parser);
			fb.GunSwayStanceTransition.Deserialize(p_Instance.StandToCrouch, p_Reader, p_Parser);
			fb.GunSwayStanceZoomModifierData.Deserialize(p_Instance.SuppressionModifierUnzoomed, p_Reader, p_Parser);
			fb.GunSwayStanceZoomModifierData.Deserialize(p_Instance.SuppressionModifierZoomed, p_Reader, p_Parser);
			p_Instance.Modifiers.Clear();
			(RimeReader Reader, uint Count) s_Modifiers = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Modifiers.Count; ++i)
			{
				var s_CtrRef = new CtrRef<GunSwayModifierData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Modifiers.Reader.ReadUInt32()));
				p_Instance.Modifiers.Add(s_CtrRef);
			}
			
			s_Modifiers.Reader.Dispose();
			p_Instance.DeviationScaleFactorZoom = p_Reader.ReadSingle();
			p_Instance.GameplayDeviationScaleFactorZoom = p_Reader.ReadSingle();
			p_Instance.DeviationScaleFactorNoZoom = p_Reader.ReadSingle();
			p_Instance.GameplayDeviationScaleFactorNoZoom = p_Reader.ReadSingle();
			p_Instance.ShootingRecoilDecreaseScale = p_Reader.ReadSingle();
			p_Instance.FirstShotRecoilMultiplier = p_Reader.ReadSingle();
			p_Instance.CameraRecoil.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
