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
	[ContainerType(4, 32)]
	public class SoundAreaEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public CtrRef<SoundAsset> Sound { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<BigWorldSettingsAsset> BigWorld { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float FadeWidth { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float ProximityMultiplier { get; set; }

		[ContainerField(28)]
		public FadeCurveType FadeCurve { get; set; } = new();

		public static void Deserialize(SoundAreaEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Sound.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.BigWorld.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.FadeWidth = p_Reader.ReadSingle();
			p_Instance.ProximityMultiplier = p_Reader.ReadSingle();
			p_Instance.FadeCurve = (FadeCurveType) p_Reader.ReadInt32();
		}

	}
}
