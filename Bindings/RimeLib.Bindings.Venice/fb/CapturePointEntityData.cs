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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(192), ContainerClass]
	public class CapturePointEntityData : 
		GameEntityData
	{
		protected int m_EnemyTicketLossWhenCaptured = new int();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(564231500)]
		public int EnemyTicketLossWhenCaptured { get { return m_EnemyTicketLossWhenCaptured; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(EnemyTicketLossWhenCaptured), this, m_EnemyTicketLossWhenCaptured, value)) m_EnemyTicketLossWhenCaptured = value; } } // 0x60 (96)
		
		protected int m_MinNrToTakeControl = new int();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3359967028)]
		public int MinNrToTakeControl { get { return m_MinNrToTakeControl; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(MinNrToTakeControl), this, m_MinNrToTakeControl, value)) m_MinNrToTakeControl = value; } } // 0x64 (100)
		
		protected RefArray<ObjectBlueprint> m_FlagTemplates = new RefArray<ObjectBlueprint>();
		[ContainerField(104), MemberInfoFlag(65), ContainerFieldNameHash(1208546634), ContainerRefArray]
		public RefArray<ObjectBlueprint> FlagTemplates { get { return m_FlagTemplates; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(FlagTemplates), this, m_FlagTemplates, value)) m_FlagTemplates = value; } } // 0x68 (104)
		
		protected CtrRef<ObjectBlueprint> m_CapturePoint = new CtrRef<ObjectBlueprint>();
		[ContainerField(108), MemberInfoFlag(53), ContainerFieldNameHash(3548539661), ContainerCtrRef]
		public CtrRef<ObjectBlueprint> CapturePoint { get { return m_CapturePoint; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(CapturePoint), this, m_CapturePoint, value)) m_CapturePoint = value; } } // 0x6C (108)
		
		protected TeamId m_InitialOwnerTeam = new TeamId();
		[ContainerField(112), MemberInfoFlag(137), ContainerFieldNameHash(2819378919)]
		public TeamId InitialOwnerTeam { get { return m_InitialOwnerTeam; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(InitialOwnerTeam), this, m_InitialOwnerTeam, value)) m_InitialOwnerTeam = value; } } // 0x70 (112)
		
		protected float m_CaptureRadius = new float();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1043301209)]
		public float CaptureRadius { get { return m_CaptureRadius; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(CaptureRadius), this, m_CaptureRadius, value)) m_CaptureRadius = value; } } // 0x74 (116)
		
		protected int m_MaxCaptureMultiplier = new int();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1211879326)]
		public int MaxCaptureMultiplier { get { return m_MaxCaptureMultiplier; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(MaxCaptureMultiplier), this, m_MaxCaptureMultiplier, value)) m_MaxCaptureMultiplier = value; } } // 0x78 (120)
		
		protected int m_AreaValue = new int();
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4217799545)]
		public int AreaValue { get { return m_AreaValue; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(AreaValue), this, m_AreaValue, value)) m_AreaValue = value; } } // 0x7C (124)
		
		protected uint m_SpawnMenuListOrdinal = new uint();
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(316937852)]
		public uint SpawnMenuListOrdinal { get { return m_SpawnMenuListOrdinal; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(SpawnMenuListOrdinal), this, m_SpawnMenuListOrdinal, value)) m_SpawnMenuListOrdinal = value; } } // 0x80 (128)
		
		protected List<AreaValueTeam> m_AreaValues = new List<AreaValueTeam>();
		[ContainerField(132), MemberInfoFlag(65), ContainerFieldNameHash(1748431594), ContainerArray]
		public List<AreaValueTeam> AreaValues { get { return m_AreaValues; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(AreaValues), this, m_AreaValues, value)) m_AreaValues = value; } } // 0x84 (132)
		
		protected int m_TimeToGetControl = new int();
		[ContainerField(136), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1506679642)]
		public int TimeToGetControl { get { return m_TimeToGetControl; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(TimeToGetControl), this, m_TimeToGetControl, value)) m_TimeToGetControl = value; } } // 0x88 (136)
		
		protected int m_TimeToLoseControl = new int();
		[ContainerField(140), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3830029753)]
		public int TimeToLoseControl { get { return m_TimeToLoseControl; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(TimeToLoseControl), this, m_TimeToLoseControl, value)) m_TimeToLoseControl = value; } } // 0x8C (140)
		
		protected float m_ReturnMultiplier = new float();
		[ContainerField(144), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(118486500)]
		public float ReturnMultiplier { get { return m_ReturnMultiplier; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(ReturnMultiplier), this, m_ReturnMultiplier, value)) m_ReturnMultiplier = value; } } // 0x90 (144)
		
		protected int m_OnlyTakeableByTeam = new int();
		[ContainerField(148), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(282816006)]
		public int OnlyTakeableByTeam { get { return m_OnlyTakeableByTeam; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(OnlyTakeableByTeam), this, m_OnlyTakeableByTeam, value)) m_OnlyTakeableByTeam = value; } } // 0x94 (148)
		
		protected float m_ShowRadius = new float();
		[ContainerField(152), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2284771454)]
		public float ShowRadius { get { return m_ShowRadius; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(ShowRadius), this, m_ShowRadius, value)) m_ShowRadius = value; } } // 0x98 (152)
		
		protected float m_HideRadius = new float();
		[ContainerField(156), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3315533693)]
		public float HideRadius { get { return m_HideRadius; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(HideRadius), this, m_HideRadius, value)) m_HideRadius = value; } } // 0x9C (156)
		
		protected float m_AddedMultiplierPerPlayer = new float();
		[ContainerField(160), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4214083802)]
		public float AddedMultiplierPerPlayer { get { return m_AddedMultiplierPerPlayer; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(AddedMultiplierPerPlayer), this, m_AddedMultiplierPerPlayer, value)) m_AddedMultiplierPerPlayer = value; } } // 0xA0 (160)
		
		protected float m_Modify3DIconVerticalOffset = new float();
		[ContainerField(164), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3848122358)]
		public float Modify3DIconVerticalOffset { get { return m_Modify3DIconVerticalOffset; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(Modify3DIconVerticalOffset), this, m_Modify3DIconVerticalOffset, value)) m_Modify3DIconVerticalOffset = value; } } // 0xA4 (164)
		
		protected CapturableType m_CapturableType = new CapturableType();
		[ContainerField(168), MemberInfoFlag(137), ContainerFieldNameHash(4032836214)]
		public CapturableType CapturableType { get { return m_CapturableType; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(CapturableType), this, m_CapturableType, value)) m_CapturableType = value; } } // 0xA8 (168)
		
		protected string m_IntruderWarningSID = string.Empty;
		[ContainerField(172), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(691558678)]
		public string IntruderWarningSID { get { return m_IntruderWarningSID; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(IntruderWarningSID), this, m_IntruderWarningSID, value)) m_IntruderWarningSID = value; } } // 0xAC (172)
		
		protected bool m_IsCapturedInUpperSphere = new bool();
		[ContainerField(176), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3699411299)]
		public bool IsCapturedInUpperSphere { get { return m_IsCapturedInUpperSphere; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(IsCapturedInUpperSphere), this, m_IsCapturedInUpperSphere, value)) m_IsCapturedInUpperSphere = value; } } // 0xB0 (176)
		
		protected bool m_DisableWhenLosingControl = new bool();
		[ContainerField(177), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2397507634)]
		public bool DisableWhenLosingControl { get { return m_DisableWhenLosingControl; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(DisableWhenLosingControl), this, m_DisableWhenLosingControl, value)) m_DisableWhenLosingControl = value; } } // 0xB1 (177)
		
		protected bool m_LoseControlWhenNotClose = new bool();
		[ContainerField(178), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(197053568)]
		public bool LoseControlWhenNotClose { get { return m_LoseControlWhenNotClose; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(LoseControlWhenNotClose), this, m_LoseControlWhenNotClose, value)) m_LoseControlWhenNotClose = value; } } // 0xB2 (178)
		
		protected bool m_DisableIfEnemyInside = new bool();
		[ContainerField(179), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2095022840)]
		public bool DisableIfEnemyInside { get { return m_DisableIfEnemyInside; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(DisableIfEnemyInside), this, m_DisableIfEnemyInside, value)) m_DisableIfEnemyInside = value; } } // 0xB3 (179)
		
		protected bool m_IsVisible = new bool();
		[ContainerField(180), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4174428017)]
		public bool IsVisible { get { return m_IsVisible; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(IsVisible), this, m_IsVisible, value)) m_IsVisible = value; } } // 0xB4 (180)
		
		protected bool m_ForceSnap = new bool();
		[ContainerField(181), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3675636116)]
		public bool ForceSnap { get { return m_ForceSnap; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(ForceSnap), this, m_ForceSnap, value)) m_ForceSnap = value; } } // 0xB5 (181)
		
		protected bool m_UseAreaValuesPerTeam = new bool();
		[ContainerField(182), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(404347571)]
		public bool UseAreaValuesPerTeam { get { return m_UseAreaValuesPerTeam; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(UseAreaValuesPerTeam), this, m_UseAreaValuesPerTeam, value)) m_UseAreaValuesPerTeam = value; } } // 0xB6 (182)
		
		protected bool m_IntruderWarning = new bool();
		[ContainerField(183), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3522568872)]
		public bool IntruderWarning { get { return m_IntruderWarning; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(IntruderWarning), this, m_IntruderWarning, value)) m_IntruderWarning = value; } } // 0xB7 (183)
		
		protected bool m_ShowOnMinimap = new bool();
		[ContainerField(184), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1450528952)]
		public bool ShowOnMinimap { get { return m_ShowOnMinimap; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(ShowOnMinimap), this, m_ShowOnMinimap, value)) m_ShowOnMinimap = value; } } // 0xB8 (184)
		
		protected bool m_HoistFlag = new bool();
		[ContainerField(185), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3775540640)]
		public bool HoistFlag { get { return m_HoistFlag; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(HoistFlag), this, m_HoistFlag, value)) m_HoistFlag = value; } } // 0xB9 (185)
		
		protected bool m_StartAtBottom = new bool();
		[ContainerField(186), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4122129279)]
		public bool StartAtBottom { get { return m_StartAtBottom; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(StartAtBottom), this, m_StartAtBottom, value)) m_StartAtBottom = value; } } // 0xBA (186)
		
		protected bool m_RemoveWhenCaptured = new bool();
		[ContainerField(187), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2265983223)]
		public bool RemoveWhenCaptured { get { return m_RemoveWhenCaptured; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(RemoveWhenCaptured), this, m_RemoveWhenCaptured, value)) m_RemoveWhenCaptured = value; } } // 0xBB (187)
		
		protected bool m_SeesawCapturing = new bool();
		[ContainerField(188), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3756225682)]
		public bool SeesawCapturing { get { return m_SeesawCapturing; } set { if (OnPropertyChanging("CapturePointEntityData." + nameof(SeesawCapturing), this, m_SeesawCapturing, value)) m_SeesawCapturing = value; } } // 0xBC (188)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 564231500:
					EnemyTicketLossWhenCaptured = (int) p_Value;
					break;

				case 3359967028:
					MinNrToTakeControl = (int) p_Value;
					break;

				case 1208546634:
					FlagTemplates = (RefArray<ObjectBlueprint>) p_Value;
					break;

				case 3548539661:
					CapturePoint = (CtrRef<ObjectBlueprint>) p_Value;
					break;

				case 2819378919:
					InitialOwnerTeam = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 1043301209:
					CaptureRadius = (float) p_Value;
					break;

				case 1211879326:
					MaxCaptureMultiplier = (int) p_Value;
					break;

				case 4217799545:
					AreaValue = (int) p_Value;
					break;

				case 316937852:
					SpawnMenuListOrdinal = (uint) p_Value;
					break;

				case 1748431594:
					AreaValues = (List<AreaValueTeam>) p_Value;
					break;

				case 1506679642:
					TimeToGetControl = (int) p_Value;
					break;

				case 3830029753:
					TimeToLoseControl = (int) p_Value;
					break;

				case 118486500:
					ReturnMultiplier = (float) p_Value;
					break;

				case 282816006:
					OnlyTakeableByTeam = (int) p_Value;
					break;

				case 2284771454:
					ShowRadius = (float) p_Value;
					break;

				case 3315533693:
					HideRadius = (float) p_Value;
					break;

				case 4214083802:
					AddedMultiplierPerPlayer = (float) p_Value;
					break;

				case 3848122358:
					Modify3DIconVerticalOffset = (float) p_Value;
					break;

				case 4032836214:
					CapturableType = (CapturableType) Enum.ToObject(typeof(CapturableType), p_Value);
					break;

				case 691558678:
					IntruderWarningSID = (string) p_Value;
					break;

				case 3699411299:
					IsCapturedInUpperSphere = (bool) p_Value;
					break;

				case 2397507634:
					DisableWhenLosingControl = (bool) p_Value;
					break;

				case 197053568:
					LoseControlWhenNotClose = (bool) p_Value;
					break;

				case 2095022840:
					DisableIfEnemyInside = (bool) p_Value;
					break;

				case 4174428017:
					IsVisible = (bool) p_Value;
					break;

				case 3675636116:
					ForceSnap = (bool) p_Value;
					break;

				case 404347571:
					UseAreaValuesPerTeam = (bool) p_Value;
					break;

				case 3522568872:
					IntruderWarning = (bool) p_Value;
					break;

				case 1450528952:
					ShowOnMinimap = (bool) p_Value;
					break;

				case 3775540640:
					HoistFlag = (bool) p_Value;
					break;

				case 4122129279:
					StartAtBottom = (bool) p_Value;
					break;

				case 2265983223:
					RemoveWhenCaptured = (bool) p_Value;
					break;

				case 3756225682:
					SeesawCapturing = (bool) p_Value;
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
				case 564231500:
					return EnemyTicketLossWhenCaptured;

				case 3359967028:
					return MinNrToTakeControl;

				case 1208546634:
					return FlagTemplates;

				case 3548539661:
					return CapturePoint;

				case 2819378919:
					return InitialOwnerTeam;

				case 1043301209:
					return CaptureRadius;

				case 1211879326:
					return MaxCaptureMultiplier;

				case 4217799545:
					return AreaValue;

				case 316937852:
					return SpawnMenuListOrdinal;

				case 1748431594:
					return AreaValues;

				case 1506679642:
					return TimeToGetControl;

				case 3830029753:
					return TimeToLoseControl;

				case 118486500:
					return ReturnMultiplier;

				case 282816006:
					return OnlyTakeableByTeam;

				case 2284771454:
					return ShowRadius;

				case 3315533693:
					return HideRadius;

				case 4214083802:
					return AddedMultiplierPerPlayer;

				case 3848122358:
					return Modify3DIconVerticalOffset;

				case 4032836214:
					return CapturableType;

				case 691558678:
					return IntruderWarningSID;

				case 3699411299:
					return IsCapturedInUpperSphere;

				case 2397507634:
					return DisableWhenLosingControl;

				case 197053568:
					return LoseControlWhenNotClose;

				case 2095022840:
					return DisableIfEnemyInside;

				case 4174428017:
					return IsVisible;

				case 3675636116:
					return ForceSnap;

				case 404347571:
					return UseAreaValuesPerTeam;

				case 3522568872:
					return IntruderWarning;

				case 1450528952:
					return ShowOnMinimap;

				case 3775540640:
					return HoistFlag;

				case 4122129279:
					return StartAtBottom;

				case 2265983223:
					return RemoveWhenCaptured;

				case 3756225682:
					return SeesawCapturing;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 564231500:
					return typeof(CapturePointEntityData).GetProperty(nameof(EnemyTicketLossWhenCaptured));

				case 3359967028:
					return typeof(CapturePointEntityData).GetProperty(nameof(MinNrToTakeControl));

				case 1208546634:
					return typeof(CapturePointEntityData).GetProperty(nameof(FlagTemplates));

				case 3548539661:
					return typeof(CapturePointEntityData).GetProperty(nameof(CapturePoint));

				case 2819378919:
					return typeof(CapturePointEntityData).GetProperty(nameof(InitialOwnerTeam));

				case 1043301209:
					return typeof(CapturePointEntityData).GetProperty(nameof(CaptureRadius));

				case 1211879326:
					return typeof(CapturePointEntityData).GetProperty(nameof(MaxCaptureMultiplier));

				case 4217799545:
					return typeof(CapturePointEntityData).GetProperty(nameof(AreaValue));

				case 316937852:
					return typeof(CapturePointEntityData).GetProperty(nameof(SpawnMenuListOrdinal));

				case 1748431594:
					return typeof(CapturePointEntityData).GetProperty(nameof(AreaValues));

				case 1506679642:
					return typeof(CapturePointEntityData).GetProperty(nameof(TimeToGetControl));

				case 3830029753:
					return typeof(CapturePointEntityData).GetProperty(nameof(TimeToLoseControl));

				case 118486500:
					return typeof(CapturePointEntityData).GetProperty(nameof(ReturnMultiplier));

				case 282816006:
					return typeof(CapturePointEntityData).GetProperty(nameof(OnlyTakeableByTeam));

				case 2284771454:
					return typeof(CapturePointEntityData).GetProperty(nameof(ShowRadius));

				case 3315533693:
					return typeof(CapturePointEntityData).GetProperty(nameof(HideRadius));

				case 4214083802:
					return typeof(CapturePointEntityData).GetProperty(nameof(AddedMultiplierPerPlayer));

				case 3848122358:
					return typeof(CapturePointEntityData).GetProperty(nameof(Modify3DIconVerticalOffset));

				case 4032836214:
					return typeof(CapturePointEntityData).GetProperty(nameof(CapturableType));

				case 691558678:
					return typeof(CapturePointEntityData).GetProperty(nameof(IntruderWarningSID));

				case 3699411299:
					return typeof(CapturePointEntityData).GetProperty(nameof(IsCapturedInUpperSphere));

				case 2397507634:
					return typeof(CapturePointEntityData).GetProperty(nameof(DisableWhenLosingControl));

				case 197053568:
					return typeof(CapturePointEntityData).GetProperty(nameof(LoseControlWhenNotClose));

				case 2095022840:
					return typeof(CapturePointEntityData).GetProperty(nameof(DisableIfEnemyInside));

				case 4174428017:
					return typeof(CapturePointEntityData).GetProperty(nameof(IsVisible));

				case 3675636116:
					return typeof(CapturePointEntityData).GetProperty(nameof(ForceSnap));

				case 404347571:
					return typeof(CapturePointEntityData).GetProperty(nameof(UseAreaValuesPerTeam));

				case 3522568872:
					return typeof(CapturePointEntityData).GetProperty(nameof(IntruderWarning));

				case 1450528952:
					return typeof(CapturePointEntityData).GetProperty(nameof(ShowOnMinimap));

				case 3775540640:
					return typeof(CapturePointEntityData).GetProperty(nameof(HoistFlag));

				case 4122129279:
					return typeof(CapturePointEntityData).GetProperty(nameof(StartAtBottom));

				case 2265983223:
					return typeof(CapturePointEntityData).GetProperty(nameof(RemoveWhenCaptured));

				case 3756225682:
					return typeof(CapturePointEntityData).GetProperty(nameof(SeesawCapturing));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
