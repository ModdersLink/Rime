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
	[ContainerType(16, 80)]
	public class CameraData : 
		GameObjectData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 OcclusionRayOffset { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public float ShakeFactor { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float PreFadeTime { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float FadeTime { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float FadeWaitTime { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float SoundListenerRadius { get; set; }

		[ContainerField(52)]
		public CtrRef<ViewFxData> ViewFx { get; set; } = new();

		[ContainerField(56), LayoutImmutable, Blittable]
		public float NearPlane { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float ShadowViewDistanceScale { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float SoundOcclusion { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public bool StayFadedWhileStreaming { get; set; }

		public static void Deserialize(CameraData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.OcclusionRayOffset, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ShakeFactor = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.PreFadeTime = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.FadeTime = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.FadeWaitTime = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.SoundListenerRadius = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ViewFx.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.NearPlane = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ShadowViewDistanceScale = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.SoundOcclusion = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.StayFadedWhileStreaming = p_Reader.ReadBool();
			p_Reader.Seek(15, SeekOrigin.Current);
		}

	}
}
