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
	[ContainerType(16, 192)]
	public class EmitterTemplateData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 PointLightIntensity { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 PointLightPivot { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 PointLightColor { get; set; } = new();

		[ContainerField(64), LayoutImmutable, Blittable]
		public uint MaxCount { get; set; }

		[ContainerField(68), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(72), LayoutImmutable, Blittable]
		public float TimeScale { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public uint LifetimeFrameCount { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public float Lifetime { get; set; }

		[ContainerField(84)]
		public CtrRef<ProcessorData> RootProcessor { get; set; } = new();

		[ContainerField(88), LayoutImmutable, Blittable]
		public float VisibleAfterDistance { get; set; }

		[ContainerField(92)]
		public List<float> ZOcclusionLookup { get; set; } = new();

		[ContainerField(96)]
		public EmittableType EmittableType { get; set; } = new();

		[ContainerField(100)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable]
		public float DistanceScaleNearValue { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float PointLightRadius { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float VertexPixelLightingBlendFactor { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float GlobalLocalNormalBlendFactor { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float SoftParticlesFadeDistanceMultiplier { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float LightWrapAroundFactor { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float LightMultiplier { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float DistanceScaleFarValue { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float PointLightRandomIntensityMin { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float MeshCullingDistance { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public float PointLightRandomIntensityMax { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public float MaxSpawnDistance { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float MinScreenArea { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public float DistanceScaleLength { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public float PointLightMaxClamp { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float ParticleCullingFactor { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public float PointLightMinClamp { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public bool FollowSpawnSource { get; set; }

		[ContainerField(173), LayoutImmutable, Blittable]
		public bool RepeatParticleSpawning { get; set; }

		[ContainerField(174), LayoutImmutable, Blittable]
		public bool Emissive { get; set; }

		[ContainerField(175), LayoutImmutable, Blittable]
		public bool ExclusionVolumeCullEnable { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public bool TransparencySunShadowEnable { get; set; }

		[ContainerField(177), LayoutImmutable, Blittable]
		public bool ForceFullRes { get; set; }

		[ContainerField(178), LayoutImmutable, Blittable]
		public bool LocalSpace { get; set; }

		[ContainerField(179), LayoutImmutable, Blittable]
		public bool Opaque { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public bool ActAsPointLight { get; set; }

		[ContainerField(181), LayoutImmutable, Blittable]
		public bool KillParticlesWithEmitter { get; set; }

		[ContainerField(182), LayoutImmutable, Blittable]
		public bool ForceNiceSorting { get; set; }

		public static void Deserialize(EmitterTemplateData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.PointLightIntensity, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.PointLightPivot, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.PointLightColor, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.MaxCount = p_Reader.ReadUInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.TimeScale = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.LifetimeFrameCount = p_Reader.ReadUInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Lifetime = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.RootProcessor.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.VisibleAfterDistance = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ZOcclusionLookup.Clear();
			(RimeReader Reader, uint Count) s_ZOcclusionLookup = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ZOcclusionLookup.Count; ++i)
			{
				var s_Value = s_ZOcclusionLookup.Reader.ReadSingle();
				p_Instance.ZOcclusionLookup.Add(s_Value);
			}
			
			s_ZOcclusionLookup.Reader.Dispose();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.EmittableType = (EmittableType) p_Reader.ReadInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Mesh.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.DistanceScaleNearValue = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.PointLightRadius = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.VertexPixelLightingBlendFactor = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.GlobalLocalNormalBlendFactor = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.SoftParticlesFadeDistanceMultiplier = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.LightWrapAroundFactor = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.LightMultiplier = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.DistanceScaleFarValue = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.PointLightRandomIntensityMin = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.MeshCullingDistance = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.PointLightRandomIntensityMax = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.MaxSpawnDistance = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.MinScreenArea = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.DistanceScaleLength = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.PointLightMaxClamp = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ParticleCullingFactor = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.PointLightMinClamp = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.FollowSpawnSource = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.RepeatParticleSpawning = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Emissive = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ExclusionVolumeCullEnable = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.TransparencySunShadowEnable = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ForceFullRes = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.LocalSpace = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Opaque = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ActAsPointLight = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.KillParticlesWithEmitter = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ForceNiceSorting = p_Reader.ReadBool();
			p_Reader.Seek(17, SeekOrigin.Current);
		}

	}
}
