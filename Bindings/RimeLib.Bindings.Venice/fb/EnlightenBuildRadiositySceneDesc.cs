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
	[ContainerType(4, 48)]
	public class EnlightenBuildRadiositySceneDesc : 
		DataContainer
	{
		[ContainerField(8)]
		public List<EnlightenLightProbeSet> LightProbeSets { get; set; } = new();

		[ContainerField(12)]
		public List<EnlightenInputInstance> Instances { get; set; } = new();

		[ContainerField(16)]
		public List<Vec3> StaticLightProbes { get; set; } = new();

		[ContainerField(20), LayoutImmutable]
		public string Terrain { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint SamplesPerCluster { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float SystemInfluenceRadius { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public uint SystemSize { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public uint IrBudget { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float ClusterSize { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public bool SaveDebugData { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable]
		public bool DistributedBuild { get; set; }

		[ContainerField(46), LayoutImmutable, Blittable]
		public bool CacheEnable { get; set; }

		public static void Deserialize(EnlightenBuildRadiositySceneDesc p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.LightProbeSets.Clear();
			(RimeReader Reader, uint Count) s_LightProbeSets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_LightProbeSets.Count; ++i)
			{
				var s_Value = new EnlightenLightProbeSet();
				fb.EnlightenLightProbeSet.Deserialize(s_Value, s_LightProbeSets.Reader, p_Parser);
				p_Instance.LightProbeSets.Add(s_Value);
			}
			
			s_LightProbeSets.Reader.Dispose();
			p_Instance.Instances.Clear();
			(RimeReader Reader, uint Count) s_Instances = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Instances.Count; ++i)
			{
				var s_Value = new EnlightenInputInstance();
				fb.EnlightenInputInstance.Deserialize(s_Value, s_Instances.Reader, p_Parser);
				p_Instance.Instances.Add(s_Value);
			}
			
			s_Instances.Reader.Dispose();
			p_Instance.StaticLightProbes.Clear();
			(RimeReader Reader, uint Count) s_StaticLightProbes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_StaticLightProbes.Count; ++i)
			{
				var s_Value = new Vec3();
				fb.Vec3.Deserialize(s_Value, s_StaticLightProbes.Reader, p_Parser);
				p_Instance.StaticLightProbes.Add(s_Value);
			}
			
			s_StaticLightProbes.Reader.Dispose();
			p_Instance.Terrain = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.SamplesPerCluster = p_Reader.ReadUInt32();
			p_Instance.SystemInfluenceRadius = p_Reader.ReadSingle();
			p_Instance.SystemSize = p_Reader.ReadUInt32();
			p_Instance.IrBudget = p_Reader.ReadUInt32();
			p_Instance.ClusterSize = p_Reader.ReadSingle();
			p_Instance.SaveDebugData = p_Reader.ReadBool();
			p_Instance.DistributedBuild = p_Reader.ReadBool();
			p_Instance.CacheEnable = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
