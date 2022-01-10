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

		public static void Deserialize(EmitterSystemSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MeshDrawCountLimit = p_Reader.ReadUInt32();
			p_Instance.TimeScale = p_Reader.ReadSingle();
			p_Instance.GlobalResetStartTimeInterval = p_Reader.ReadSingle();
			p_Instance.QuadHalfResSlice2ThresholdLow = p_Reader.ReadSingle();
			p_Instance.QuadHalfResSlice2ThresholdHigh = p_Reader.ReadSingle();
			p_Instance.QuadHalfResSlice1ThresholdLow = p_Reader.ReadSingle();
			p_Instance.QuadHalfResSlice1ThresholdHigh = p_Reader.ReadSingle();
			p_Instance.DebugOverdrawCount = p_Reader.ReadInt32();
			p_Instance.DrawStats = p_Reader.ReadUInt32();
			p_Instance.MeshStreamingPriorityMultiplier = p_Reader.ReadSingle();
			p_Instance.QuadZOcclusionBias = p_Reader.ReadSingle();
			p_Instance.DrawBoundingBoxes = p_Reader.ReadUInt32();
			p_Instance.MinScreenArea = p_Reader.ReadSingle();
			p_Instance.QuadNearFadeDistance = p_Reader.ReadSingle();
			p_Instance.QuadTechnique = p_Reader.ReadInt32();
			p_Instance.MeshCullingDistance = p_Reader.ReadSingle();
			p_Instance.EnableFixedTimeStep = p_Reader.ReadBool();
			p_Instance.ZBufferCullEnable = p_Reader.ReadBool();
			p_Instance.QuadEnableOverdrawRendering = p_Reader.ReadBool();
			p_Instance.QuadColorShaderCostsEnable = p_Reader.ReadBool();
			p_Instance.DrawProjectedBoxes = p_Reader.ReadBool();
			p_Instance.QuadSimpleRenderingEnable = p_Reader.ReadBool();
			p_Instance.EnableJobs = p_Reader.ReadBool();
			p_Instance.EnableRendering = p_Reader.ReadBool();
			p_Instance.QuadHalfResEnable = p_Reader.ReadBool();
			p_Instance.QuadEnableRendering = p_Reader.ReadBool();
			p_Instance.EnableFixedDelta = p_Reader.ReadBool();
			p_Instance.QuadClipScaleEnable = p_Reader.ReadBool();
			p_Instance.QuadNiceRenderingEnable = p_Reader.ReadBool();
			p_Instance.QuadGroupsJoinAll = p_Reader.ReadBool();
			p_Instance.QuadGroupsJoinNone = p_Reader.ReadBool();
			p_Instance.QuadGroupsJoinNiceAndSimple = p_Reader.ReadBool();
			p_Instance.QuadEnableOpaque = p_Reader.ReadBool();
			p_Instance.QuadVertexShadowsEnable = p_Reader.ReadBool();
			p_Instance.QuadPointLightsEnable = p_Reader.ReadBool();
			p_Instance.QuadSpotLightsEnable = p_Reader.ReadBool();
			p_Instance.QuadEnableSorting = p_Reader.ReadBool();
			p_Instance.MeshRenderingEnable = p_Reader.ReadBool();
			p_Instance.MeshDrawTransforms = p_Reader.ReadBool();
			p_Instance.MeshDrawBoundingBoxes = p_Reader.ReadBool();
			p_Instance.MeshShadowEnable = p_Reader.ReadBool();
			p_Instance.QuadEnableWireframe = p_Reader.ReadBool();
			p_Instance.Enable = p_Reader.ReadBool();
			p_Instance.QuadEnableZOcclusion = p_Reader.ReadBool();
			p_Instance.MeshDrawCullStats = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
