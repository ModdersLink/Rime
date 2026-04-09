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
	[ContainerType(4, 68)]
	public partial class VegetationSystemSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _WindVariation;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _WindVariationRate;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _WindStrength;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _JointTensionLimit;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private int _ForceShadowLod;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private uint _MaxPreSimsPerJob;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private uint _SimulationMemKbClient;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _MaxActiveDistance;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private uint _SimulationMemKbServer;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private uint _JobCount;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private int _JointTensionLimitIndex;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _TimeScale;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private bool _LocalInfluencesEnabled;

		[ObservableProperty]
		[property: ContainerField(57), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
		private bool _SubDestructionEnabled;

		[ObservableProperty]
		[property: ContainerField(58), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
		private bool _DissolveEnable;

		[ObservableProperty]
		[property: ContainerField(59), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
		private bool _Enable;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private bool _SimulateServerSide;

		[ObservableProperty]
		[property: ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		private bool _EnableJobs;

		[ObservableProperty]
		[property: ContainerField(62), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
		private bool _ShadowMeshEnable;

		[ObservableProperty]
		[property: ContainerField(63), LayoutImmutable, Blittable, JsonProperty(Order = 63)]
		private bool _DrawNodes;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private bool _DrawEnable;

		[ObservableProperty]
		[property: ContainerField(65), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
		private bool _BatchDrawEnable;

		[ObservableProperty]
		[property: ContainerField(66), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
		private bool _DestructionEnabled;

		[ObservableProperty]
		[property: ContainerField(67), LayoutImmutable, Blittable, JsonProperty(Order = 67)]
		private bool _UseShadowLodOffset;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
