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
	[ContainerType(4, 92)]
	public class ZoomLevelData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float FieldOfView { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float DispersionMultiplier { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float LookSpeedMultiplier { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float SprintLookSpeedMultiplier { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float MoveSpeedMultiplier { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float SwayPitchMultiplier { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float SwayYawMultiplier { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float SupportedSwayPitchMultiplier { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float SupportedSwayYawMultiplier { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float TimePitchMultiplier { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float TimeYawMultiplier { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float RecoilMultiplier { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float FadeToBlackDuration { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float RecoilFovMultiplier { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float CameraImpulseMultiplier { get; set; }

		[ContainerField(68)]
		public ZoomLevelActivateEventType OnActivateEventType { get; set; } = new();

		[ContainerField(72), LayoutImmutable, Blittable]
		public float StartFadeToBlackAtTime { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public float FadeFromBlackDuration { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public float StartFadeFromBlackAtTime { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float ScreenExposureAreaScale { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public bool FadeToBlackInZoomTransition { get; set; }

		[ContainerField(89), LayoutImmutable, Blittable]
		public bool UseFovSpecialisation { get; set; }

		[ContainerField(90), LayoutImmutable, Blittable]
		public bool AllowFieldOfViewScaling { get; set; }

		public static void Deserialize(ZoomLevelData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.FieldOfView = p_Reader.ReadSingle();
			p_Instance.DispersionMultiplier = p_Reader.ReadSingle();
			p_Instance.LookSpeedMultiplier = p_Reader.ReadSingle();
			p_Instance.SprintLookSpeedMultiplier = p_Reader.ReadSingle();
			p_Instance.MoveSpeedMultiplier = p_Reader.ReadSingle();
			p_Instance.SwayPitchMultiplier = p_Reader.ReadSingle();
			p_Instance.SwayYawMultiplier = p_Reader.ReadSingle();
			p_Instance.SupportedSwayPitchMultiplier = p_Reader.ReadSingle();
			p_Instance.SupportedSwayYawMultiplier = p_Reader.ReadSingle();
			p_Instance.TimePitchMultiplier = p_Reader.ReadSingle();
			p_Instance.TimeYawMultiplier = p_Reader.ReadSingle();
			p_Instance.RecoilMultiplier = p_Reader.ReadSingle();
			p_Instance.FadeToBlackDuration = p_Reader.ReadSingle();
			p_Instance.RecoilFovMultiplier = p_Reader.ReadSingle();
			p_Instance.CameraImpulseMultiplier = p_Reader.ReadSingle();
			p_Instance.OnActivateEventType = (ZoomLevelActivateEventType) p_Reader.ReadInt32();
			p_Instance.StartFadeToBlackAtTime = p_Reader.ReadSingle();
			p_Instance.FadeFromBlackDuration = p_Reader.ReadSingle();
			p_Instance.StartFadeFromBlackAtTime = p_Reader.ReadSingle();
			p_Instance.ScreenExposureAreaScale = p_Reader.ReadSingle();
			p_Instance.FadeToBlackInZoomTransition = p_Reader.ReadBool();
			p_Instance.UseFovSpecialisation = p_Reader.ReadBool();
			p_Instance.AllowFieldOfViewScaling = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
