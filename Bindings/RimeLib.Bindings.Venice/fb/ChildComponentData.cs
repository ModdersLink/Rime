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
	[ContainerType(16, 224)]
	public class ChildComponentData : 
		PartComponentData
	{
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform AlignTransform { get; set; } = new();

		[ContainerField(176)]
		public CtrRef<MovingBodyData> MovingBody { get; set; } = new();

		[ContainerField(180)]
		public VehicleHealthZoneData HealthZone { get; set; } = new();

		[ContainerField(200), LayoutImmutable, Blittable]
		public float SoundEffectStartRpm { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public float SoundEffectStopRpm { get; set; }

		[ContainerField(208)]
		public CtrRef<AlignmentData> AlignmentSettings { get; set; } = new();

		[ContainerField(212)]
		public CtrRef<SoundAsset> SoundEffect { get; set; } = new();

		[ContainerField(216), LayoutImmutable, Blittable]
		public bool EnableAlignToCamera { get; set; }

		[ContainerField(217), LayoutImmutable, Blittable]
		public bool WorldSpacePositionLock { get; set; }

		public static void Deserialize(ChildComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.LinearTransform.Deserialize(p_Instance.AlignTransform, p_Reader, p_Parser);
			p_Instance.MovingBody.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			fb.VehicleHealthZoneData.Deserialize(p_Instance.HealthZone, p_Reader, p_Parser);
			p_Instance.SoundEffectStartRpm = p_Reader.ReadSingle();
			p_Instance.SoundEffectStopRpm = p_Reader.ReadSingle();
			p_Instance.AlignmentSettings.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SoundEffect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.EnableAlignToCamera = p_Reader.ReadBool();
			p_Instance.WorldSpacePositionLock = p_Reader.ReadBool();
			p_Reader.Seek(6, SeekOrigin.Current);
		}

	}
}
