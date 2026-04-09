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
	[ContainerType(4, 48)]
	public partial class EnlightenBuildRadiositySceneDesc :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private List<EnlightenLightProbeSet> _LightProbeSets = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<EnlightenInputInstance> _Instances = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private List<Vec3> _StaticLightProbes = new();

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		private string _Terrain = string.Empty;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _SamplesPerCluster;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _SystemInfluenceRadius;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private uint _SystemSize;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private uint _IrBudget;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _ClusterSize;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private bool _SaveDebugData;

		[ObservableProperty]
		[property: ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		private bool _DistributedBuild;

		[ObservableProperty]
		[property: ContainerField(46), LayoutImmutable, Blittable, JsonProperty(Order = 46)]
		private bool _CacheEnable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			(RimeWriter Writer, uint ArrayIndex) s_LightProbeSets = p_EbxWriter.GetArrayWriter(LightProbeSets.GetType(), LightProbeSets.Count);
			p_Writer.Write(s_LightProbeSets.ArrayIndex);
			foreach (var s_Entry in LightProbeSets)
			{
				s_Entry.Serialize(s_LightProbeSets.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_Instances = p_EbxWriter.GetArrayWriter(Instances.GetType(), Instances.Count);
			p_Writer.Write(s_Instances.ArrayIndex);
			foreach (var s_Entry in Instances)
			{
				s_Entry.Serialize(s_Instances.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_StaticLightProbes = p_EbxWriter.GetArrayWriter(StaticLightProbes.GetType(), StaticLightProbes.Count);
			p_Writer.Write(s_StaticLightProbes.ArrayIndex);
			foreach (var s_Entry in StaticLightProbes)
			{
				s_Entry.Serialize(s_StaticLightProbes.Writer, p_EbxWriter);
			}
			p_Writer.Write(p_EbxWriter.WriteString(Terrain));
			p_Writer.Write(SamplesPerCluster);
			p_Writer.Write(SystemInfluenceRadius);
			p_Writer.Write(SystemSize);
			p_Writer.Write(IrBudget);
			p_Writer.Write(ClusterSize);
			p_Writer.Write(SaveDebugData);
			p_Writer.Write(DistributedBuild);
			p_Writer.Write(CacheEnable);
			p_Writer.WriteNullBytes(1);
		}
	}
}
