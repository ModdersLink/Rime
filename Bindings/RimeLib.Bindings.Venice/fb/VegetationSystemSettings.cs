///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class VegetationSystemSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float WindVariation { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float WindVariationRate { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float WindStrength { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float JointTensionLimit { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int ForceShadowLod { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint MaxPreSimsPerJob { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public uint SimulationMemKbClient { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float MaxActiveDistance { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public uint SimulationMemKbServer { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public uint JobCount { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public int JointTensionLimitIndex { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float TimeScale { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public bool LocalInfluencesEnabled { get; set; } // 0x38 (56)
		
		[ContainerField(57), LayoutImmutable, Blittable]
		public bool SubDestructionEnabled { get; set; } // 0x39 (57)
		
		[ContainerField(58), LayoutImmutable, Blittable]
		public bool DissolveEnable { get; set; } // 0x3A (58)
		
		[ContainerField(59), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x3B (59)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public bool SimulateServerSide { get; set; } // 0x3C (60)
		
		[ContainerField(61), LayoutImmutable, Blittable]
		public bool EnableJobs { get; set; } // 0x3D (61)
		
		[ContainerField(62), LayoutImmutable, Blittable]
		public bool ShadowMeshEnable { get; set; } // 0x3E (62)
		
		[ContainerField(63), LayoutImmutable, Blittable]
		public bool DrawNodes { get; set; } // 0x3F (63)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public bool DrawEnable { get; set; } // 0x40 (64)
		
		[ContainerField(65), LayoutImmutable, Blittable]
		public bool BatchDrawEnable { get; set; } // 0x41 (65)
		
		[ContainerField(66), LayoutImmutable, Blittable]
		public bool DestructionEnabled { get; set; } // 0x42 (66)
		
		[ContainerField(67), LayoutImmutable, Blittable]
		public bool UseShadowLodOffset { get; set; } // 0x43 (67)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2346154816:
					WindVariation = (float) p_Value;
					break;

				case 1435068578:
					WindVariationRate = (float) p_Value;
					break;

				case 3768589012:
					WindStrength = (float) p_Value;
					break;

				case 2687352802:
					JointTensionLimit = (float) p_Value;
					break;

				case 694013785:
					ForceShadowLod = (int) p_Value;
					break;

				case 3246910962:
					MaxPreSimsPerJob = (uint) p_Value;
					break;

				case 188140739:
					SimulationMemKbClient = (uint) p_Value;
					break;

				case 2638833886:
					MaxActiveDistance = (float) p_Value;
					break;

				case 3858787743:
					SimulationMemKbServer = (uint) p_Value;
					break;

				case 4166996065:
					JobCount = (uint) p_Value;
					break;

				case 1641973468:
					JointTensionLimitIndex = (int) p_Value;
					break;

				case 169511528:
					TimeScale = (float) p_Value;
					break;

				case 438465675:
					LocalInfluencesEnabled = (bool) p_Value;
					break;

				case 1151400922:
					SubDestructionEnabled = (bool) p_Value;
					break;

				case 84402905:
					DissolveEnable = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
					break;

				case 314597893:
					SimulateServerSide = (bool) p_Value;
					break;

				case 1190923856:
					EnableJobs = (bool) p_Value;
					break;

				case 4253576529:
					ShadowMeshEnable = (bool) p_Value;
					break;

				case 2398188982:
					DrawNodes = (bool) p_Value;
					break;

				case 1347356004:
					DrawEnable = (bool) p_Value;
					break;

				case 3539660312:
					BatchDrawEnable = (bool) p_Value;
					break;

				case 4087722398:
					DestructionEnabled = (bool) p_Value;
					break;

				case 2320118218:
					UseShadowLodOffset = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2346154816:
					return WindVariation;

				case 1435068578:
					return WindVariationRate;

				case 3768589012:
					return WindStrength;

				case 2687352802:
					return JointTensionLimit;

				case 694013785:
					return ForceShadowLod;

				case 3246910962:
					return MaxPreSimsPerJob;

				case 188140739:
					return SimulationMemKbClient;

				case 2638833886:
					return MaxActiveDistance;

				case 3858787743:
					return SimulationMemKbServer;

				case 4166996065:
					return JobCount;

				case 1641973468:
					return JointTensionLimitIndex;

				case 169511528:
					return TimeScale;

				case 438465675:
					return LocalInfluencesEnabled;

				case 1151400922:
					return SubDestructionEnabled;

				case 84402905:
					return DissolveEnable;

				case 2342790116:
					return Enable;

				case 314597893:
					return SimulateServerSide;

				case 1190923856:
					return EnableJobs;

				case 4253576529:
					return ShadowMeshEnable;

				case 2398188982:
					return DrawNodes;

				case 1347356004:
					return DrawEnable;

				case 3539660312:
					return BatchDrawEnable;

				case 4087722398:
					return DestructionEnabled;

				case 2320118218:
					return UseShadowLodOffset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2346154816:
					return typeof(VegetationSystemSettings).GetProperty(nameof(WindVariation));

				case 1435068578:
					return typeof(VegetationSystemSettings).GetProperty(nameof(WindVariationRate));

				case 3768589012:
					return typeof(VegetationSystemSettings).GetProperty(nameof(WindStrength));

				case 2687352802:
					return typeof(VegetationSystemSettings).GetProperty(nameof(JointTensionLimit));

				case 694013785:
					return typeof(VegetationSystemSettings).GetProperty(nameof(ForceShadowLod));

				case 3246910962:
					return typeof(VegetationSystemSettings).GetProperty(nameof(MaxPreSimsPerJob));

				case 188140739:
					return typeof(VegetationSystemSettings).GetProperty(nameof(SimulationMemKbClient));

				case 2638833886:
					return typeof(VegetationSystemSettings).GetProperty(nameof(MaxActiveDistance));

				case 3858787743:
					return typeof(VegetationSystemSettings).GetProperty(nameof(SimulationMemKbServer));

				case 4166996065:
					return typeof(VegetationSystemSettings).GetProperty(nameof(JobCount));

				case 1641973468:
					return typeof(VegetationSystemSettings).GetProperty(nameof(JointTensionLimitIndex));

				case 169511528:
					return typeof(VegetationSystemSettings).GetProperty(nameof(TimeScale));

				case 438465675:
					return typeof(VegetationSystemSettings).GetProperty(nameof(LocalInfluencesEnabled));

				case 1151400922:
					return typeof(VegetationSystemSettings).GetProperty(nameof(SubDestructionEnabled));

				case 84402905:
					return typeof(VegetationSystemSettings).GetProperty(nameof(DissolveEnable));

				case 2342790116:
					return typeof(VegetationSystemSettings).GetProperty(nameof(Enable));

				case 314597893:
					return typeof(VegetationSystemSettings).GetProperty(nameof(SimulateServerSide));

				case 1190923856:
					return typeof(VegetationSystemSettings).GetProperty(nameof(EnableJobs));

				case 4253576529:
					return typeof(VegetationSystemSettings).GetProperty(nameof(ShadowMeshEnable));

				case 2398188982:
					return typeof(VegetationSystemSettings).GetProperty(nameof(DrawNodes));

				case 1347356004:
					return typeof(VegetationSystemSettings).GetProperty(nameof(DrawEnable));

				case 3539660312:
					return typeof(VegetationSystemSettings).GetProperty(nameof(BatchDrawEnable));

				case 4087722398:
					return typeof(VegetationSystemSettings).GetProperty(nameof(DestructionEnabled));

				case 2320118218:
					return typeof(VegetationSystemSettings).GetProperty(nameof(UseShadowLodOffset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
