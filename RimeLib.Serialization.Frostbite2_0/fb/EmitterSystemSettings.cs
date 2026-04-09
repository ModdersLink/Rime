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
	[ContainerType(4, 104)]
	public partial class EmitterSystemSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private uint _MeshDrawCountLimit;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _TimeScale;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _GlobalResetStartTimeInterval;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _QuadHalfResSlice2ThresholdLow;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _QuadHalfResSlice2ThresholdHigh;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _QuadHalfResSlice1ThresholdLow;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _QuadHalfResSlice1ThresholdHigh;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private int _DebugOverdrawCount;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private uint _DrawStats;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _MeshStreamingPriorityMultiplier;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _QuadZOcclusionBias;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private uint _DrawBoundingBoxes;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _MinScreenArea;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _QuadNearFadeDistance;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private int _QuadTechnique;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _MeshCullingDistance;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private bool _EnableFixedTimeStep;

		[ObservableProperty]
		[property: ContainerField(73), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
		private bool _ZBufferCullEnable;

		[ObservableProperty]
		[property: ContainerField(74), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
		private bool _QuadEnableOverdrawRendering;

		[ObservableProperty]
		[property: ContainerField(75), LayoutImmutable, Blittable, JsonProperty(Order = 75)]
		private bool _QuadColorShaderCostsEnable;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private bool _DrawProjectedBoxes;

		[ObservableProperty]
		[property: ContainerField(77), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
		private bool _QuadSimpleRenderingEnable;

		[ObservableProperty]
		[property: ContainerField(78), LayoutImmutable, Blittable, JsonProperty(Order = 78)]
		private bool _EnableJobs;

		[ObservableProperty]
		[property: ContainerField(79), LayoutImmutable, Blittable, JsonProperty(Order = 79)]
		private bool _EnableRendering;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private bool _QuadHalfResEnable;

		[ObservableProperty]
		[property: ContainerField(81), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
		private bool _QuadEnableRendering;

		[ObservableProperty]
		[property: ContainerField(82), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
		private bool _EnableFixedDelta;

		[ObservableProperty]
		[property: ContainerField(83), LayoutImmutable, Blittable, JsonProperty(Order = 83)]
		private bool _QuadClipScaleEnable;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private bool _QuadNiceRenderingEnable;

		[ObservableProperty]
		[property: ContainerField(85), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
		private bool _QuadGroupsJoinAll;

		[ObservableProperty]
		[property: ContainerField(86), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
		private bool _QuadGroupsJoinNone;

		[ObservableProperty]
		[property: ContainerField(87), LayoutImmutable, Blittable, JsonProperty(Order = 87)]
		private bool _QuadGroupsJoinNiceAndSimple;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private bool _QuadEnableOpaque;

		[ObservableProperty]
		[property: ContainerField(89), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
		private bool _QuadVertexShadowsEnable;

		[ObservableProperty]
		[property: ContainerField(90), LayoutImmutable, Blittable, JsonProperty(Order = 90)]
		private bool _QuadPointLightsEnable;

		[ObservableProperty]
		[property: ContainerField(91), LayoutImmutable, Blittable, JsonProperty(Order = 91)]
		private bool _QuadSpotLightsEnable;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private bool _QuadEnableSorting;

		[ObservableProperty]
		[property: ContainerField(93), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
		private bool _MeshRenderingEnable;

		[ObservableProperty]
		[property: ContainerField(94), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
		private bool _MeshDrawTransforms;

		[ObservableProperty]
		[property: ContainerField(95), LayoutImmutable, Blittable, JsonProperty(Order = 95)]
		private bool _MeshDrawBoundingBoxes;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private bool _MeshShadowEnable;

		[ObservableProperty]
		[property: ContainerField(97), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
		private bool _QuadEnableWireframe;

		[ObservableProperty]
		[property: ContainerField(98), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
		private bool _Enable;

		[ObservableProperty]
		[property: ContainerField(99), LayoutImmutable, Blittable, JsonProperty(Order = 99)]
		private bool _QuadEnableZOcclusion;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private bool _MeshDrawCullStats;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(MeshDrawCountLimit);
			p_Writer.Write(TimeScale);
			p_Writer.Write(GlobalResetStartTimeInterval);
			p_Writer.Write(QuadHalfResSlice2ThresholdLow);
			p_Writer.Write(QuadHalfResSlice2ThresholdHigh);
			p_Writer.Write(QuadHalfResSlice1ThresholdLow);
			p_Writer.Write(QuadHalfResSlice1ThresholdHigh);
			p_Writer.Write(DebugOverdrawCount);
			p_Writer.Write(DrawStats);
			p_Writer.Write(MeshStreamingPriorityMultiplier);
			p_Writer.Write(QuadZOcclusionBias);
			p_Writer.Write(DrawBoundingBoxes);
			p_Writer.Write(MinScreenArea);
			p_Writer.Write(QuadNearFadeDistance);
			p_Writer.Write(QuadTechnique);
			p_Writer.Write(MeshCullingDistance);
			p_Writer.Write(EnableFixedTimeStep);
			p_Writer.Write(ZBufferCullEnable);
			p_Writer.Write(QuadEnableOverdrawRendering);
			p_Writer.Write(QuadColorShaderCostsEnable);
			p_Writer.Write(DrawProjectedBoxes);
			p_Writer.Write(QuadSimpleRenderingEnable);
			p_Writer.Write(EnableJobs);
			p_Writer.Write(EnableRendering);
			p_Writer.Write(QuadHalfResEnable);
			p_Writer.Write(QuadEnableRendering);
			p_Writer.Write(EnableFixedDelta);
			p_Writer.Write(QuadClipScaleEnable);
			p_Writer.Write(QuadNiceRenderingEnable);
			p_Writer.Write(QuadGroupsJoinAll);
			p_Writer.Write(QuadGroupsJoinNone);
			p_Writer.Write(QuadGroupsJoinNiceAndSimple);
			p_Writer.Write(QuadEnableOpaque);
			p_Writer.Write(QuadVertexShadowsEnable);
			p_Writer.Write(QuadPointLightsEnable);
			p_Writer.Write(QuadSpotLightsEnable);
			p_Writer.Write(QuadEnableSorting);
			p_Writer.Write(MeshRenderingEnable);
			p_Writer.Write(MeshDrawTransforms);
			p_Writer.Write(MeshDrawBoundingBoxes);
			p_Writer.Write(MeshShadowEnable);
			p_Writer.Write(QuadEnableWireframe);
			p_Writer.Write(Enable);
			p_Writer.Write(QuadEnableZOcclusion);
			p_Writer.Write(MeshDrawCullStats);
			p_Writer.WriteNullBytes(3);
		}
	}
}
