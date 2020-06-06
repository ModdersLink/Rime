///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class PropellerEngineConfigData : 
		EngineConfigData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 HorisontalForceOffset { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112)]
		public PropellerType PropellerType { get; set; } = new PropellerType(); // 0x70 (112)
		
		[ContainerField(116)]
		public CtrRef<RotorParameters> RotorConfig { get; set; } = new CtrRef<RotorParameters>(); // 0x74 (116)
		
		[ContainerField(120)]
		public ForceMagnitudeInputType ForceMagnitudeInputType { get; set; } = new ForceMagnitudeInputType(); // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public uint DirectionVectorIndex { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float ForceMagnitudeMultiplier { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float LiftForceSpringConstant { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float LiftForceDampingConstant { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float CyclicInputScaleRoll { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float CyclicRollLiftMod { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float CyclicRollStrafeMod { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float CyclicInputScalePitch { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float CyclicPitchLiftMod { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float CyclicPitchStrafeMod { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float CyclicPitchStrafeBrakeMod { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public float CollectiveInputIdle { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public float CollectiveThrottleInputScale { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float CollectiveBrakeInputScale { get; set; } // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public float DefaultAngleOfAttack { get; set; } // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public float AttackAngleMod { get; set; } // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public float StabilizerMod { get; set; } // 0xBC (188)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public float HorisontalMinEffectVelocity { get; set; } // 0xC0 (192)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public float HorisontalMinEffectMod { get; set; } // 0xC4 (196)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public float PitchStrength { get; set; } // 0xC8 (200)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public float PitchFromVel { get; set; } // 0xCC (204)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public float GravityMod { get; set; } // 0xD0 (208)
		
		[ContainerField(212), LayoutImmutable, Blittable]
		public float SPForwardStrength { get; set; } // 0xD4 (212)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public float SPSidewaysStrength { get; set; } // 0xD8 (216)
		
		[ContainerField(220), LayoutImmutable, Blittable]
		public float SPVerticalStrength { get; set; } // 0xDC (220)
		
		[ContainerField(224), LayoutImmutable, Blittable]
		public float VelocityFromPitch { get; set; } // 0xE0 (224)
		
		[ContainerField(228), LayoutImmutable, Blittable]
		public float PitchLimit { get; set; } // 0xE4 (228)
		
		[ContainerField(232), LayoutImmutable, Blittable]
		public float BankingStrength { get; set; } // 0xE8 (232)
		
		[ContainerField(236), LayoutImmutable, Blittable]
		public float BankingLimit { get; set; } // 0xEC (236)
		
		[ContainerField(240), LayoutImmutable, Blittable]
		public float RollStrength { get; set; } // 0xF0 (240)
		
		[ContainerField(244), LayoutImmutable, Blittable]
		public float PitchUpWhenBankStrength { get; set; } // 0xF4 (244)
		
		[ContainerField(248), LayoutImmutable, Blittable]
		public float PitchUpWhenBankLimit { get; set; } // 0xF8 (248)
		
		[ContainerField(252), LayoutImmutable, Blittable]
		public bool SPDefault { get; set; } // 0xFC (252)
		
		[ContainerField(253), LayoutImmutable, Blittable]
		public bool EnableNewHelicopter { get; set; } // 0xFD (253)
		
		[ContainerField(254), LayoutImmutable, Blittable]
		public bool SPAllowed { get; set; } // 0xFE (254)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3212041026:
					HorisontalForceOffset = (Vec3) p_Value;
					break;

				case 1200379762:
					PropellerType = (PropellerType) Enum.ToObject(typeof(PropellerType), p_Value);
					break;

				case 468078427:
					RotorConfig = (CtrRef<RotorParameters>) p_Value;
					break;

				case 3842564762:
					ForceMagnitudeInputType = (ForceMagnitudeInputType) Enum.ToObject(typeof(ForceMagnitudeInputType), p_Value);
					break;

				case 3901228711:
					DirectionVectorIndex = (uint) p_Value;
					break;

				case 3209574239:
					ForceMagnitudeMultiplier = (float) p_Value;
					break;

				case 201216672:
					LiftForceSpringConstant = (float) p_Value;
					break;

				case 3660889641:
					LiftForceDampingConstant = (float) p_Value;
					break;

				case 3891841257:
					CyclicInputScaleRoll = (float) p_Value;
					break;

				case 1157893238:
					CyclicRollLiftMod = (float) p_Value;
					break;

				case 2784120854:
					CyclicRollStrafeMod = (float) p_Value;
					break;

				case 3869827346:
					CyclicInputScalePitch = (float) p_Value;
					break;

				case 908927597:
					CyclicPitchLiftMod = (float) p_Value;
					break;

				case 1559244621:
					CyclicPitchStrafeMod = (float) p_Value;
					break;

				case 1510977458:
					CyclicPitchStrafeBrakeMod = (float) p_Value;
					break;

				case 3489057395:
					CollectiveInputIdle = (float) p_Value;
					break;

				case 2328068935:
					CollectiveThrottleInputScale = (float) p_Value;
					break;

				case 3062684400:
					CollectiveBrakeInputScale = (float) p_Value;
					break;

				case 1125032846:
					DefaultAngleOfAttack = (float) p_Value;
					break;

				case 947227178:
					AttackAngleMod = (float) p_Value;
					break;

				case 870578278:
					StabilizerMod = (float) p_Value;
					break;

				case 3650611512:
					HorisontalMinEffectVelocity = (float) p_Value;
					break;

				case 2678032425:
					HorisontalMinEffectMod = (float) p_Value;
					break;

				case 724430630:
					PitchStrength = (float) p_Value;
					break;

				case 3054994922:
					PitchFromVel = (float) p_Value;
					break;

				case 3507401381:
					GravityMod = (float) p_Value;
					break;

				case 439958200:
					SPForwardStrength = (float) p_Value;
					break;

				case 3287536100:
					SPSidewaysStrength = (float) p_Value;
					break;

				case 3767334993:
					SPVerticalStrength = (float) p_Value;
					break;

				case 2548692482:
					VelocityFromPitch = (float) p_Value;
					break;

				case 3055348630:
					PitchLimit = (float) p_Value;
					break;

				case 1620944870:
					BankingStrength = (float) p_Value;
					break;

				case 3461970646:
					BankingLimit = (float) p_Value;
					break;

				case 3312814269:
					RollStrength = (float) p_Value;
					break;

				case 1714831281:
					PitchUpWhenBankStrength = (float) p_Value;
					break;

				case 1223555233:
					PitchUpWhenBankLimit = (float) p_Value;
					break;

				case 2087493101:
					SPDefault = (bool) p_Value;
					break;

				case 4043707695:
					EnableNewHelicopter = (bool) p_Value;
					break;

				case 1786637822:
					SPAllowed = (bool) p_Value;
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
				case 3212041026:
					return HorisontalForceOffset;

				case 1200379762:
					return PropellerType;

				case 468078427:
					return RotorConfig;

				case 3842564762:
					return ForceMagnitudeInputType;

				case 3901228711:
					return DirectionVectorIndex;

				case 3209574239:
					return ForceMagnitudeMultiplier;

				case 201216672:
					return LiftForceSpringConstant;

				case 3660889641:
					return LiftForceDampingConstant;

				case 3891841257:
					return CyclicInputScaleRoll;

				case 1157893238:
					return CyclicRollLiftMod;

				case 2784120854:
					return CyclicRollStrafeMod;

				case 3869827346:
					return CyclicInputScalePitch;

				case 908927597:
					return CyclicPitchLiftMod;

				case 1559244621:
					return CyclicPitchStrafeMod;

				case 1510977458:
					return CyclicPitchStrafeBrakeMod;

				case 3489057395:
					return CollectiveInputIdle;

				case 2328068935:
					return CollectiveThrottleInputScale;

				case 3062684400:
					return CollectiveBrakeInputScale;

				case 1125032846:
					return DefaultAngleOfAttack;

				case 947227178:
					return AttackAngleMod;

				case 870578278:
					return StabilizerMod;

				case 3650611512:
					return HorisontalMinEffectVelocity;

				case 2678032425:
					return HorisontalMinEffectMod;

				case 724430630:
					return PitchStrength;

				case 3054994922:
					return PitchFromVel;

				case 3507401381:
					return GravityMod;

				case 439958200:
					return SPForwardStrength;

				case 3287536100:
					return SPSidewaysStrength;

				case 3767334993:
					return SPVerticalStrength;

				case 2548692482:
					return VelocityFromPitch;

				case 3055348630:
					return PitchLimit;

				case 1620944870:
					return BankingStrength;

				case 3461970646:
					return BankingLimit;

				case 3312814269:
					return RollStrength;

				case 1714831281:
					return PitchUpWhenBankStrength;

				case 1223555233:
					return PitchUpWhenBankLimit;

				case 2087493101:
					return SPDefault;

				case 4043707695:
					return EnableNewHelicopter;

				case 1786637822:
					return SPAllowed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3212041026:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(HorisontalForceOffset));

				case 1200379762:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(PropellerType));

				case 468078427:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(RotorConfig));

				case 3842564762:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(ForceMagnitudeInputType));

				case 3901228711:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(DirectionVectorIndex));

				case 3209574239:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(ForceMagnitudeMultiplier));

				case 201216672:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(LiftForceSpringConstant));

				case 3660889641:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(LiftForceDampingConstant));

				case 3891841257:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(CyclicInputScaleRoll));

				case 1157893238:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(CyclicRollLiftMod));

				case 2784120854:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(CyclicRollStrafeMod));

				case 3869827346:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(CyclicInputScalePitch));

				case 908927597:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(CyclicPitchLiftMod));

				case 1559244621:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(CyclicPitchStrafeMod));

				case 1510977458:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(CyclicPitchStrafeBrakeMod));

				case 3489057395:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(CollectiveInputIdle));

				case 2328068935:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(CollectiveThrottleInputScale));

				case 3062684400:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(CollectiveBrakeInputScale));

				case 1125032846:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(DefaultAngleOfAttack));

				case 947227178:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(AttackAngleMod));

				case 870578278:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(StabilizerMod));

				case 3650611512:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(HorisontalMinEffectVelocity));

				case 2678032425:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(HorisontalMinEffectMod));

				case 724430630:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(PitchStrength));

				case 3054994922:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(PitchFromVel));

				case 3507401381:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(GravityMod));

				case 439958200:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(SPForwardStrength));

				case 3287536100:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(SPSidewaysStrength));

				case 3767334993:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(SPVerticalStrength));

				case 2548692482:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(VelocityFromPitch));

				case 3055348630:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(PitchLimit));

				case 1620944870:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(BankingStrength));

				case 3461970646:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(BankingLimit));

				case 3312814269:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(RollStrength));

				case 1714831281:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(PitchUpWhenBankStrength));

				case 1223555233:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(PitchUpWhenBankLimit));

				case 2087493101:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(SPDefault));

				case 4043707695:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(EnableNewHelicopter));

				case 1786637822:
					return typeof(PropellerEngineConfigData).GetProperty(nameof(SPAllowed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
