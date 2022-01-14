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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 104)]
	public class EmitterSystemSettings :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public uint MeshDrawCountLimit { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float TimeScale { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float GlobalResetStartTimeInterval { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float QuadHalfResSlice2ThresholdLow { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float QuadHalfResSlice2ThresholdHigh { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float QuadHalfResSlice1ThresholdLow { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float QuadHalfResSlice1ThresholdHigh { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public int DebugOverdrawCount { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public uint DrawStats { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float MeshStreamingPriorityMultiplier { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float QuadZOcclusionBias { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public uint DrawBoundingBoxes { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float MinScreenArea { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float QuadNearFadeDistance { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public int QuadTechnique { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float MeshCullingDistance { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public bool EnableFixedTimeStep { get; set; }

		[ContainerField(73), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
		public bool ZBufferCullEnable { get; set; }

		[ContainerField(74), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
		public bool QuadEnableOverdrawRendering { get; set; }

		[ContainerField(75), LayoutImmutable, Blittable, JsonProperty(Order = 75)]
		public bool QuadColorShaderCostsEnable { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public bool DrawProjectedBoxes { get; set; }

		[ContainerField(77), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
		public bool QuadSimpleRenderingEnable { get; set; }

		[ContainerField(78), LayoutImmutable, Blittable, JsonProperty(Order = 78)]
		public bool EnableJobs { get; set; }

		[ContainerField(79), LayoutImmutable, Blittable, JsonProperty(Order = 79)]
		public bool EnableRendering { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public bool QuadHalfResEnable { get; set; }

		[ContainerField(81), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
		public bool QuadEnableRendering { get; set; }

		[ContainerField(82), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
		public bool EnableFixedDelta { get; set; }

		[ContainerField(83), LayoutImmutable, Blittable, JsonProperty(Order = 83)]
		public bool QuadClipScaleEnable { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public bool QuadNiceRenderingEnable { get; set; }

		[ContainerField(85), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
		public bool QuadGroupsJoinAll { get; set; }

		[ContainerField(86), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
		public bool QuadGroupsJoinNone { get; set; }

		[ContainerField(87), LayoutImmutable, Blittable, JsonProperty(Order = 87)]
		public bool QuadGroupsJoinNiceAndSimple { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public bool QuadEnableOpaque { get; set; }

		[ContainerField(89), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
		public bool QuadVertexShadowsEnable { get; set; }

		[ContainerField(90), LayoutImmutable, Blittable, JsonProperty(Order = 90)]
		public bool QuadPointLightsEnable { get; set; }

		[ContainerField(91), LayoutImmutable, Blittable, JsonProperty(Order = 91)]
		public bool QuadSpotLightsEnable { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public bool QuadEnableSorting { get; set; }

		[ContainerField(93), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
		public bool MeshRenderingEnable { get; set; }

		[ContainerField(94), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
		public bool MeshDrawTransforms { get; set; }

		[ContainerField(95), LayoutImmutable, Blittable, JsonProperty(Order = 95)]
		public bool MeshDrawBoundingBoxes { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public bool MeshShadowEnable { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
		public bool QuadEnableWireframe { get; set; }

		[ContainerField(98), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
		public bool Enable { get; set; }

		[ContainerField(99), LayoutImmutable, Blittable, JsonProperty(Order = 99)]
		public bool QuadEnableZOcclusion { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public bool MeshDrawCullStats { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
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
