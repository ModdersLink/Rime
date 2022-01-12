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
	[ContainerType(4, 104)]
	public class EmitterSystemSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint MeshDrawCountLimit { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float TimeScale { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float GlobalResetStartTimeInterval { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float QuadHalfResSlice2ThresholdLow { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float QuadHalfResSlice2ThresholdHigh { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float QuadHalfResSlice1ThresholdLow { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float QuadHalfResSlice1ThresholdHigh { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public int DebugOverdrawCount { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public uint DrawStats { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float MeshStreamingPriorityMultiplier { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float QuadZOcclusionBias { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public uint DrawBoundingBoxes { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float MinScreenArea { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float QuadNearFadeDistance { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public int QuadTechnique { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float MeshCullingDistance { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public bool EnableFixedTimeStep { get; set; }

		[ContainerField(73), LayoutImmutable, Blittable]
		public bool ZBufferCullEnable { get; set; }

		[ContainerField(74), LayoutImmutable, Blittable]
		public bool QuadEnableOverdrawRendering { get; set; }

		[ContainerField(75), LayoutImmutable, Blittable]
		public bool QuadColorShaderCostsEnable { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public bool DrawProjectedBoxes { get; set; }

		[ContainerField(77), LayoutImmutable, Blittable]
		public bool QuadSimpleRenderingEnable { get; set; }

		[ContainerField(78), LayoutImmutable, Blittable]
		public bool EnableJobs { get; set; }

		[ContainerField(79), LayoutImmutable, Blittable]
		public bool EnableRendering { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public bool QuadHalfResEnable { get; set; }

		[ContainerField(81), LayoutImmutable, Blittable]
		public bool QuadEnableRendering { get; set; }

		[ContainerField(82), LayoutImmutable, Blittable]
		public bool EnableFixedDelta { get; set; }

		[ContainerField(83), LayoutImmutable, Blittable]
		public bool QuadClipScaleEnable { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public bool QuadNiceRenderingEnable { get; set; }

		[ContainerField(85), LayoutImmutable, Blittable]
		public bool QuadGroupsJoinAll { get; set; }

		[ContainerField(86), LayoutImmutable, Blittable]
		public bool QuadGroupsJoinNone { get; set; }

		[ContainerField(87), LayoutImmutable, Blittable]
		public bool QuadGroupsJoinNiceAndSimple { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public bool QuadEnableOpaque { get; set; }

		[ContainerField(89), LayoutImmutable, Blittable]
		public bool QuadVertexShadowsEnable { get; set; }

		[ContainerField(90), LayoutImmutable, Blittable]
		public bool QuadPointLightsEnable { get; set; }

		[ContainerField(91), LayoutImmutable, Blittable]
		public bool QuadSpotLightsEnable { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public bool QuadEnableSorting { get; set; }

		[ContainerField(93), LayoutImmutable, Blittable]
		public bool MeshRenderingEnable { get; set; }

		[ContainerField(94), LayoutImmutable, Blittable]
		public bool MeshDrawTransforms { get; set; }

		[ContainerField(95), LayoutImmutable, Blittable]
		public bool MeshDrawBoundingBoxes { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public bool MeshShadowEnable { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable]
		public bool QuadEnableWireframe { get; set; }

		[ContainerField(98), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		[ContainerField(99), LayoutImmutable, Blittable]
		public bool QuadEnableZOcclusion { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public bool MeshDrawCullStats { get; set; }

	}
}
