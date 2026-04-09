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
	[ContainerType(16, 96)]
	public partial class EnlightenRuntimeSettings :
		SystemSettings
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _AlbedoDefaultColor = new();

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _LocalLightForceRadius;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private int _DrawDebugSystemDependenciesEnable;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _TemporalCoherenceThreshold;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _SkyBoxScale;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private uint _MinSystemUpdateCount;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private uint _JobCount;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private int _DrawDebugSystemBoundingBoxEnable;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private uint _LightProbeMaxUpdateSolveCount;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _DrawDebugLightProbeSize;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private bool _CompensateSunShadowHeightScale;

		[ObservableProperty]
		[property: ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		private bool _SaveRadiosityTexturesEnable;

		[ObservableProperty]
		[property: ContainerField(70), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
		private bool _ShadowsEnable;

		[ObservableProperty]
		[property: ContainerField(71), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
		private bool _LightMapsEnable;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private bool _LocalLightsEnable;

		[ObservableProperty]
		[property: ContainerField(73), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
		private bool _LocalLightCullingEnable;

		[ObservableProperty]
		[property: ContainerField(74), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
		private bool _LocalLightCustumFalloff;

		[ObservableProperty]
		[property: ContainerField(75), LayoutImmutable, Blittable, JsonProperty(Order = 75)]
		private bool _LightProbeForceUpdate;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private bool _ForceDynamic;

		[ObservableProperty]
		[property: ContainerField(77), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
		private bool _DrawDebugSystemsEnable;

		[ObservableProperty]
		[property: ContainerField(78), LayoutImmutable, Blittable, JsonProperty(Order = 78)]
		private bool _LightProbeEnable;

		[ObservableProperty]
		[property: ContainerField(79), LayoutImmutable, Blittable, JsonProperty(Order = 79)]
		private bool _LightProbeJobsEnable;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private bool _DrawDebugLightProbes;

		[ObservableProperty]
		[property: ContainerField(81), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
		private bool _DrawDebugLightProbeOcclusion;

		[ObservableProperty]
		[property: ContainerField(82), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
		private bool _DrawDebugLightProbeStats;

		[ObservableProperty]
		[property: ContainerField(83), LayoutImmutable, Blittable, JsonProperty(Order = 83)]
		private bool _DrawDebugLightProbeBoundingBoxes;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private bool _Enable;

		[ObservableProperty]
		[property: ContainerField(85), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
		private bool _DrawSolveTaskPerformance;

		[ObservableProperty]
		[property: ContainerField(86), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
		private bool _DrawDebugColoringEnable;

		[ObservableProperty]
		[property: ContainerField(87), LayoutImmutable, Blittable, JsonProperty(Order = 87)]
		private bool _DrawDebugTextures;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private bool _DrawDebugBackFaces;

		[ObservableProperty]
		[property: ContainerField(89), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
		private bool _DrawDebugTargetMeshes;

		[ObservableProperty]
		[property: ContainerField(90), LayoutImmutable, Blittable, JsonProperty(Order = 90)]
		private bool _DrawWarningsEnable;

		[ObservableProperty]
		[property: ContainerField(91), LayoutImmutable, Blittable, JsonProperty(Order = 91)]
		private bool _AlbedoForceUpdateEnable;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private bool _AlbedoForceColorEnable;

		[ObservableProperty]
		[property: ContainerField(93), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
		private bool _DrawDebugEntities;

		[ObservableProperty]
		[property: ContainerField(94), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
		private bool _TerrainMapEnable;

		[ObservableProperty]
		[property: ContainerField(95), LayoutImmutable, Blittable, JsonProperty(Order = 95)]
		private bool _EmissiveEnable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			AlbedoDefaultColor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(LocalLightForceRadius);
			p_Writer.Write(DrawDebugSystemDependenciesEnable);
			p_Writer.Write(TemporalCoherenceThreshold);
			p_Writer.Write(SkyBoxScale);
			p_Writer.Write(MinSystemUpdateCount);
			p_Writer.Write(JobCount);
			p_Writer.Write(DrawDebugSystemBoundingBoxEnable);
			p_Writer.Write(LightProbeMaxUpdateSolveCount);
			p_Writer.Write(DrawDebugLightProbeSize);
			p_Writer.Write(CompensateSunShadowHeightScale);
			p_Writer.Write(SaveRadiosityTexturesEnable);
			p_Writer.Write(ShadowsEnable);
			p_Writer.Write(LightMapsEnable);
			p_Writer.Write(LocalLightsEnable);
			p_Writer.Write(LocalLightCullingEnable);
			p_Writer.Write(LocalLightCustumFalloff);
			p_Writer.Write(LightProbeForceUpdate);
			p_Writer.Write(ForceDynamic);
			p_Writer.Write(DrawDebugSystemsEnable);
			p_Writer.Write(LightProbeEnable);
			p_Writer.Write(LightProbeJobsEnable);
			p_Writer.Write(DrawDebugLightProbes);
			p_Writer.Write(DrawDebugLightProbeOcclusion);
			p_Writer.Write(DrawDebugLightProbeStats);
			p_Writer.Write(DrawDebugLightProbeBoundingBoxes);
			p_Writer.Write(Enable);
			p_Writer.Write(DrawSolveTaskPerformance);
			p_Writer.Write(DrawDebugColoringEnable);
			p_Writer.Write(DrawDebugTextures);
			p_Writer.Write(DrawDebugBackFaces);
			p_Writer.Write(DrawDebugTargetMeshes);
			p_Writer.Write(DrawWarningsEnable);
			p_Writer.Write(AlbedoForceUpdateEnable);
			p_Writer.Write(AlbedoForceColorEnable);
			p_Writer.Write(DrawDebugEntities);
			p_Writer.Write(TerrainMapEnable);
			p_Writer.Write(EmissiveEnable);
		}
	}
}
