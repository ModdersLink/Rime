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
	[ContainerType(4, 68)]
	public class VegetationSystemSettings :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float WindVariation { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float WindVariationRate { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float WindStrength { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float JointTensionLimit { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public int ForceShadowLod { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public uint MaxPreSimsPerJob { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public uint SimulationMemKbClient { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float MaxActiveDistance { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public uint SimulationMemKbServer { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public uint JobCount { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public int JointTensionLimitIndex { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float TimeScale { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public bool LocalInfluencesEnabled { get; set; }

		[ContainerField(57), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
		public bool SubDestructionEnabled { get; set; }

		[ContainerField(58), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
		public bool DissolveEnable { get; set; }

		[ContainerField(59), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
		public bool Enable { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public bool SimulateServerSide { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		public bool EnableJobs { get; set; }

		[ContainerField(62), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
		public bool ShadowMeshEnable { get; set; }

		[ContainerField(63), LayoutImmutable, Blittable, JsonProperty(Order = 63)]
		public bool DrawNodes { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public bool DrawEnable { get; set; }

		[ContainerField(65), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
		public bool BatchDrawEnable { get; set; }

		[ContainerField(66), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
		public bool DestructionEnabled { get; set; }

		[ContainerField(67), LayoutImmutable, Blittable, JsonProperty(Order = 67)]
		public bool UseShadowLodOffset { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(WindVariation);
			p_Writer.Write(WindVariationRate);
			p_Writer.Write(WindStrength);
			p_Writer.Write(JointTensionLimit);
			p_Writer.Write(ForceShadowLod);
			p_Writer.Write(MaxPreSimsPerJob);
			p_Writer.Write(SimulationMemKbClient);
			p_Writer.Write(MaxActiveDistance);
			p_Writer.Write(SimulationMemKbServer);
			p_Writer.Write(JobCount);
			p_Writer.Write(JointTensionLimitIndex);
			p_Writer.Write(TimeScale);
			p_Writer.Write(LocalInfluencesEnabled);
			p_Writer.Write(SubDestructionEnabled);
			p_Writer.Write(DissolveEnable);
			p_Writer.Write(Enable);
			p_Writer.Write(SimulateServerSide);
			p_Writer.Write(EnableJobs);
			p_Writer.Write(ShadowMeshEnable);
			p_Writer.Write(DrawNodes);
			p_Writer.Write(DrawEnable);
			p_Writer.Write(BatchDrawEnable);
			p_Writer.Write(DestructionEnabled);
			p_Writer.Write(UseShadowLodOffset);
		}
	}
}
