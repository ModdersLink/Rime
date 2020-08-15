///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16)]
	public class PropellerEngineConfigData : 
		EngineConfigData
	{
		protected Vec3 m_HorisontalForceOffset = new Vec3();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(3212041026)]
		public Vec3 HorisontalForceOffset { get { return m_HorisontalForceOffset; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(HorisontalForceOffset), this, m_HorisontalForceOffset, value)) m_HorisontalForceOffset = value; } } // 0x60 (96)
		
		protected PropellerType m_PropellerType = new PropellerType();
		[ContainerField(112), ContainerFieldNameHash(1200379762)]
		public PropellerType PropellerType { get { return m_PropellerType; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(PropellerType), this, m_PropellerType, value)) m_PropellerType = value; } } // 0x70 (112)
		
		protected CtrRef<RotorParameters> m_RotorConfig = new CtrRef<RotorParameters>();
		[ContainerField(116), ContainerFieldNameHash(468078427)]
		public CtrRef<RotorParameters> RotorConfig { get { return m_RotorConfig; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(RotorConfig), this, m_RotorConfig, value)) m_RotorConfig = value; } } // 0x74 (116)
		
		protected ForceMagnitudeInputType m_ForceMagnitudeInputType = new ForceMagnitudeInputType();
		[ContainerField(120), ContainerFieldNameHash(3842564762)]
		public ForceMagnitudeInputType ForceMagnitudeInputType { get { return m_ForceMagnitudeInputType; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(ForceMagnitudeInputType), this, m_ForceMagnitudeInputType, value)) m_ForceMagnitudeInputType = value; } } // 0x78 (120)
		
		protected uint m_DirectionVectorIndex = new uint();
		[ContainerField(124), LayoutImmutable, Blittable, ContainerFieldNameHash(3901228711)]
		public uint DirectionVectorIndex { get { return m_DirectionVectorIndex; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(DirectionVectorIndex), this, m_DirectionVectorIndex, value)) m_DirectionVectorIndex = value; } } // 0x7C (124)
		
		protected float m_ForceMagnitudeMultiplier = new float();
		[ContainerField(128), LayoutImmutable, Blittable, ContainerFieldNameHash(3209574239)]
		public float ForceMagnitudeMultiplier { get { return m_ForceMagnitudeMultiplier; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(ForceMagnitudeMultiplier), this, m_ForceMagnitudeMultiplier, value)) m_ForceMagnitudeMultiplier = value; } } // 0x80 (128)
		
		protected float m_LiftForceSpringConstant = new float();
		[ContainerField(132), LayoutImmutable, Blittable, ContainerFieldNameHash(201216672)]
		public float LiftForceSpringConstant { get { return m_LiftForceSpringConstant; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(LiftForceSpringConstant), this, m_LiftForceSpringConstant, value)) m_LiftForceSpringConstant = value; } } // 0x84 (132)
		
		protected float m_LiftForceDampingConstant = new float();
		[ContainerField(136), LayoutImmutable, Blittable, ContainerFieldNameHash(3660889641)]
		public float LiftForceDampingConstant { get { return m_LiftForceDampingConstant; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(LiftForceDampingConstant), this, m_LiftForceDampingConstant, value)) m_LiftForceDampingConstant = value; } } // 0x88 (136)
		
		protected float m_CyclicInputScaleRoll = new float();
		[ContainerField(140), LayoutImmutable, Blittable, ContainerFieldNameHash(3891841257)]
		public float CyclicInputScaleRoll { get { return m_CyclicInputScaleRoll; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(CyclicInputScaleRoll), this, m_CyclicInputScaleRoll, value)) m_CyclicInputScaleRoll = value; } } // 0x8C (140)
		
		protected float m_CyclicRollLiftMod = new float();
		[ContainerField(144), LayoutImmutable, Blittable, ContainerFieldNameHash(1157893238)]
		public float CyclicRollLiftMod { get { return m_CyclicRollLiftMod; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(CyclicRollLiftMod), this, m_CyclicRollLiftMod, value)) m_CyclicRollLiftMod = value; } } // 0x90 (144)
		
		protected float m_CyclicRollStrafeMod = new float();
		[ContainerField(148), LayoutImmutable, Blittable, ContainerFieldNameHash(2784120854)]
		public float CyclicRollStrafeMod { get { return m_CyclicRollStrafeMod; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(CyclicRollStrafeMod), this, m_CyclicRollStrafeMod, value)) m_CyclicRollStrafeMod = value; } } // 0x94 (148)
		
		protected float m_CyclicInputScalePitch = new float();
		[ContainerField(152), LayoutImmutable, Blittable, ContainerFieldNameHash(3869827346)]
		public float CyclicInputScalePitch { get { return m_CyclicInputScalePitch; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(CyclicInputScalePitch), this, m_CyclicInputScalePitch, value)) m_CyclicInputScalePitch = value; } } // 0x98 (152)
		
		protected float m_CyclicPitchLiftMod = new float();
		[ContainerField(156), LayoutImmutable, Blittable, ContainerFieldNameHash(908927597)]
		public float CyclicPitchLiftMod { get { return m_CyclicPitchLiftMod; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(CyclicPitchLiftMod), this, m_CyclicPitchLiftMod, value)) m_CyclicPitchLiftMod = value; } } // 0x9C (156)
		
		protected float m_CyclicPitchStrafeMod = new float();
		[ContainerField(160), LayoutImmutable, Blittable, ContainerFieldNameHash(1559244621)]
		public float CyclicPitchStrafeMod { get { return m_CyclicPitchStrafeMod; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(CyclicPitchStrafeMod), this, m_CyclicPitchStrafeMod, value)) m_CyclicPitchStrafeMod = value; } } // 0xA0 (160)
		
		protected float m_CyclicPitchStrafeBrakeMod = new float();
		[ContainerField(164), LayoutImmutable, Blittable, ContainerFieldNameHash(1510977458)]
		public float CyclicPitchStrafeBrakeMod { get { return m_CyclicPitchStrafeBrakeMod; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(CyclicPitchStrafeBrakeMod), this, m_CyclicPitchStrafeBrakeMod, value)) m_CyclicPitchStrafeBrakeMod = value; } } // 0xA4 (164)
		
		protected float m_CollectiveInputIdle = new float();
		[ContainerField(168), LayoutImmutable, Blittable, ContainerFieldNameHash(3489057395)]
		public float CollectiveInputIdle { get { return m_CollectiveInputIdle; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(CollectiveInputIdle), this, m_CollectiveInputIdle, value)) m_CollectiveInputIdle = value; } } // 0xA8 (168)
		
		protected float m_CollectiveThrottleInputScale = new float();
		[ContainerField(172), LayoutImmutable, Blittable, ContainerFieldNameHash(2328068935)]
		public float CollectiveThrottleInputScale { get { return m_CollectiveThrottleInputScale; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(CollectiveThrottleInputScale), this, m_CollectiveThrottleInputScale, value)) m_CollectiveThrottleInputScale = value; } } // 0xAC (172)
		
		protected float m_CollectiveBrakeInputScale = new float();
		[ContainerField(176), LayoutImmutable, Blittable, ContainerFieldNameHash(3062684400)]
		public float CollectiveBrakeInputScale { get { return m_CollectiveBrakeInputScale; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(CollectiveBrakeInputScale), this, m_CollectiveBrakeInputScale, value)) m_CollectiveBrakeInputScale = value; } } // 0xB0 (176)
		
		protected float m_DefaultAngleOfAttack = new float();
		[ContainerField(180), LayoutImmutable, Blittable, ContainerFieldNameHash(1125032846)]
		public float DefaultAngleOfAttack { get { return m_DefaultAngleOfAttack; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(DefaultAngleOfAttack), this, m_DefaultAngleOfAttack, value)) m_DefaultAngleOfAttack = value; } } // 0xB4 (180)
		
		protected float m_AttackAngleMod = new float();
		[ContainerField(184), LayoutImmutable, Blittable, ContainerFieldNameHash(947227178)]
		public float AttackAngleMod { get { return m_AttackAngleMod; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(AttackAngleMod), this, m_AttackAngleMod, value)) m_AttackAngleMod = value; } } // 0xB8 (184)
		
		protected float m_StabilizerMod = new float();
		[ContainerField(188), LayoutImmutable, Blittable, ContainerFieldNameHash(870578278)]
		public float StabilizerMod { get { return m_StabilizerMod; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(StabilizerMod), this, m_StabilizerMod, value)) m_StabilizerMod = value; } } // 0xBC (188)
		
		protected float m_HorisontalMinEffectVelocity = new float();
		[ContainerField(192), LayoutImmutable, Blittable, ContainerFieldNameHash(3650611512)]
		public float HorisontalMinEffectVelocity { get { return m_HorisontalMinEffectVelocity; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(HorisontalMinEffectVelocity), this, m_HorisontalMinEffectVelocity, value)) m_HorisontalMinEffectVelocity = value; } } // 0xC0 (192)
		
		protected float m_HorisontalMinEffectMod = new float();
		[ContainerField(196), LayoutImmutable, Blittable, ContainerFieldNameHash(2678032425)]
		public float HorisontalMinEffectMod { get { return m_HorisontalMinEffectMod; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(HorisontalMinEffectMod), this, m_HorisontalMinEffectMod, value)) m_HorisontalMinEffectMod = value; } } // 0xC4 (196)
		
		protected float m_PitchStrength = new float();
		[ContainerField(200), LayoutImmutable, Blittable, ContainerFieldNameHash(724430630)]
		public float PitchStrength { get { return m_PitchStrength; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(PitchStrength), this, m_PitchStrength, value)) m_PitchStrength = value; } } // 0xC8 (200)
		
		protected float m_PitchFromVel = new float();
		[ContainerField(204), LayoutImmutable, Blittable, ContainerFieldNameHash(3054994922)]
		public float PitchFromVel { get { return m_PitchFromVel; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(PitchFromVel), this, m_PitchFromVel, value)) m_PitchFromVel = value; } } // 0xCC (204)
		
		protected float m_GravityMod = new float();
		[ContainerField(208), LayoutImmutable, Blittable, ContainerFieldNameHash(3507401381)]
		public float GravityMod { get { return m_GravityMod; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(GravityMod), this, m_GravityMod, value)) m_GravityMod = value; } } // 0xD0 (208)
		
		protected float m_SPForwardStrength = new float();
		[ContainerField(212), LayoutImmutable, Blittable, ContainerFieldNameHash(439958200)]
		public float SPForwardStrength { get { return m_SPForwardStrength; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(SPForwardStrength), this, m_SPForwardStrength, value)) m_SPForwardStrength = value; } } // 0xD4 (212)
		
		protected float m_SPSidewaysStrength = new float();
		[ContainerField(216), LayoutImmutable, Blittable, ContainerFieldNameHash(3287536100)]
		public float SPSidewaysStrength { get { return m_SPSidewaysStrength; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(SPSidewaysStrength), this, m_SPSidewaysStrength, value)) m_SPSidewaysStrength = value; } } // 0xD8 (216)
		
		protected float m_SPVerticalStrength = new float();
		[ContainerField(220), LayoutImmutable, Blittable, ContainerFieldNameHash(3767334993)]
		public float SPVerticalStrength { get { return m_SPVerticalStrength; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(SPVerticalStrength), this, m_SPVerticalStrength, value)) m_SPVerticalStrength = value; } } // 0xDC (220)
		
		protected float m_VelocityFromPitch = new float();
		[ContainerField(224), LayoutImmutable, Blittable, ContainerFieldNameHash(2548692482)]
		public float VelocityFromPitch { get { return m_VelocityFromPitch; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(VelocityFromPitch), this, m_VelocityFromPitch, value)) m_VelocityFromPitch = value; } } // 0xE0 (224)
		
		protected float m_PitchLimit = new float();
		[ContainerField(228), LayoutImmutable, Blittable, ContainerFieldNameHash(3055348630)]
		public float PitchLimit { get { return m_PitchLimit; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(PitchLimit), this, m_PitchLimit, value)) m_PitchLimit = value; } } // 0xE4 (228)
		
		protected float m_BankingStrength = new float();
		[ContainerField(232), LayoutImmutable, Blittable, ContainerFieldNameHash(1620944870)]
		public float BankingStrength { get { return m_BankingStrength; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(BankingStrength), this, m_BankingStrength, value)) m_BankingStrength = value; } } // 0xE8 (232)
		
		protected float m_BankingLimit = new float();
		[ContainerField(236), LayoutImmutable, Blittable, ContainerFieldNameHash(3461970646)]
		public float BankingLimit { get { return m_BankingLimit; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(BankingLimit), this, m_BankingLimit, value)) m_BankingLimit = value; } } // 0xEC (236)
		
		protected float m_RollStrength = new float();
		[ContainerField(240), LayoutImmutable, Blittable, ContainerFieldNameHash(3312814269)]
		public float RollStrength { get { return m_RollStrength; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(RollStrength), this, m_RollStrength, value)) m_RollStrength = value; } } // 0xF0 (240)
		
		protected float m_PitchUpWhenBankStrength = new float();
		[ContainerField(244), LayoutImmutable, Blittable, ContainerFieldNameHash(1714831281)]
		public float PitchUpWhenBankStrength { get { return m_PitchUpWhenBankStrength; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(PitchUpWhenBankStrength), this, m_PitchUpWhenBankStrength, value)) m_PitchUpWhenBankStrength = value; } } // 0xF4 (244)
		
		protected float m_PitchUpWhenBankLimit = new float();
		[ContainerField(248), LayoutImmutable, Blittable, ContainerFieldNameHash(1223555233)]
		public float PitchUpWhenBankLimit { get { return m_PitchUpWhenBankLimit; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(PitchUpWhenBankLimit), this, m_PitchUpWhenBankLimit, value)) m_PitchUpWhenBankLimit = value; } } // 0xF8 (248)
		
		protected bool m_SPDefault = new bool();
		[ContainerField(252), LayoutImmutable, Blittable, ContainerFieldNameHash(2087493101)]
		public bool SPDefault { get { return m_SPDefault; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(SPDefault), this, m_SPDefault, value)) m_SPDefault = value; } } // 0xFC (252)
		
		protected bool m_EnableNewHelicopter = new bool();
		[ContainerField(253), LayoutImmutable, Blittable, ContainerFieldNameHash(4043707695)]
		public bool EnableNewHelicopter { get { return m_EnableNewHelicopter; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(EnableNewHelicopter), this, m_EnableNewHelicopter, value)) m_EnableNewHelicopter = value; } } // 0xFD (253)
		
		protected bool m_SPAllowed = new bool();
		[ContainerField(254), LayoutImmutable, Blittable, ContainerFieldNameHash(1786637822)]
		public bool SPAllowed { get { return m_SPAllowed; } set { if (OnPropertyChanging("PropellerEngineConfigData." + nameof(SPAllowed), this, m_SPAllowed, value)) m_SPAllowed = value; } } // 0xFE (254)
		
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
