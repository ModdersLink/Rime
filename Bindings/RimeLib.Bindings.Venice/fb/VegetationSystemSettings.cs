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
	[ContainerType(4, 68)]
	public class VegetationSystemSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float WindVariation { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float WindVariationRate { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float WindStrength { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float JointTensionLimit { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public int ForceShadowLod { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public uint MaxPreSimsPerJob { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public uint SimulationMemKbClient { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float MaxActiveDistance { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public uint SimulationMemKbServer { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public uint JobCount { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public int JointTensionLimitIndex { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float TimeScale { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public bool LocalInfluencesEnabled { get; set; }

		[ContainerField(57), LayoutImmutable, Blittable]
		public bool SubDestructionEnabled { get; set; }

		[ContainerField(58), LayoutImmutable, Blittable]
		public bool DissolveEnable { get; set; }

		[ContainerField(59), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public bool SimulateServerSide { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable]
		public bool EnableJobs { get; set; }

		[ContainerField(62), LayoutImmutable, Blittable]
		public bool ShadowMeshEnable { get; set; }

		[ContainerField(63), LayoutImmutable, Blittable]
		public bool DrawNodes { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public bool DrawEnable { get; set; }

		[ContainerField(65), LayoutImmutable, Blittable]
		public bool BatchDrawEnable { get; set; }

		[ContainerField(66), LayoutImmutable, Blittable]
		public bool DestructionEnabled { get; set; }

		[ContainerField(67), LayoutImmutable, Blittable]
		public bool UseShadowLodOffset { get; set; }

		public static void Deserialize(VegetationSystemSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.WindVariation = p_Reader.ReadSingle();
			p_Instance.WindVariationRate = p_Reader.ReadSingle();
			p_Instance.WindStrength = p_Reader.ReadSingle();
			p_Instance.JointTensionLimit = p_Reader.ReadSingle();
			p_Instance.ForceShadowLod = p_Reader.ReadInt32();
			p_Instance.MaxPreSimsPerJob = p_Reader.ReadUInt32();
			p_Instance.SimulationMemKbClient = p_Reader.ReadUInt32();
			p_Instance.MaxActiveDistance = p_Reader.ReadSingle();
			p_Instance.SimulationMemKbServer = p_Reader.ReadUInt32();
			p_Instance.JobCount = p_Reader.ReadUInt32();
			p_Instance.JointTensionLimitIndex = p_Reader.ReadInt32();
			p_Instance.TimeScale = p_Reader.ReadSingle();
			p_Instance.LocalInfluencesEnabled = p_Reader.ReadBool();
			p_Instance.SubDestructionEnabled = p_Reader.ReadBool();
			p_Instance.DissolveEnable = p_Reader.ReadBool();
			p_Instance.Enable = p_Reader.ReadBool();
			p_Instance.SimulateServerSide = p_Reader.ReadBool();
			p_Instance.EnableJobs = p_Reader.ReadBool();
			p_Instance.ShadowMeshEnable = p_Reader.ReadBool();
			p_Instance.DrawNodes = p_Reader.ReadBool();
			p_Instance.DrawEnable = p_Reader.ReadBool();
			p_Instance.BatchDrawEnable = p_Reader.ReadBool();
			p_Instance.DestructionEnabled = p_Reader.ReadBool();
			p_Instance.UseShadowLodOffset = p_Reader.ReadBool();
		}

	}
}
