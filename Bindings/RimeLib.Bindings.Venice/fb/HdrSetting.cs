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
	[ContainerType(4, 68)]
	public class HdrSetting : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float WindowMinTop { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float WindowMinBottom { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float WindowTopMinReleaseTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float WindowTopMaxReleaseTime { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float WindowTopAttackTime { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float WindowBottomReleaseTime { get; set; }

		[ContainerField(32)]
		public AudioCurve WindowTopReleaseTimeCurve { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable]
		public float DischargeFactor { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float MaxAllowedEnergy { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float WindowBottomAttackTime { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float WindowSize { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float CompressFactor { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float Headroom { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float AllowedOvershoot { get; set; }

		public static void Deserialize(HdrSetting p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.WindowMinTop = p_Reader.ReadSingle();
			p_Instance.WindowMinBottom = p_Reader.ReadSingle();
			p_Instance.WindowTopMinReleaseTime = p_Reader.ReadSingle();
			p_Instance.WindowTopMaxReleaseTime = p_Reader.ReadSingle();
			p_Instance.WindowTopAttackTime = p_Reader.ReadSingle();
			p_Instance.WindowBottomReleaseTime = p_Reader.ReadSingle();
			fb.AudioCurve.Deserialize(p_Instance.WindowTopReleaseTimeCurve, p_Reader, p_Parser);
			p_Instance.DischargeFactor = p_Reader.ReadSingle();
			p_Instance.MaxAllowedEnergy = p_Reader.ReadSingle();
			p_Instance.WindowBottomAttackTime = p_Reader.ReadSingle();
			p_Instance.WindowSize = p_Reader.ReadSingle();
			p_Instance.CompressFactor = p_Reader.ReadSingle();
			p_Instance.Headroom = p_Reader.ReadSingle();
			p_Instance.AllowedOvershoot = p_Reader.ReadSingle();
		}

	}
}
