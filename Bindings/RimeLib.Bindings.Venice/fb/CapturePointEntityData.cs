///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class CapturePointEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public int EnemyTicketLossWhenCaptured { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public int MinNrToTakeControl { get; set; } // 0x64 (100)
		
		[ContainerField(104)]
		public RefArray<ObjectBlueprint> FlagTemplates { get; set; } = new RefArray<ObjectBlueprint>(); // 0x68 (104)
		
		[ContainerField(108)]
		public CtrRef<ObjectBlueprint> CapturePoint { get; set; } = new CtrRef<ObjectBlueprint>(); // 0x6C (108)
		
		[ContainerField(112)]
		public TeamId InitialOwnerTeam { get; set; } = new TeamId(); // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float CaptureRadius { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public int MaxCaptureMultiplier { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public int AreaValue { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public uint SpawnMenuListOrdinal { get; set; } // 0x80 (128)
		
		[ContainerField(132)]
		public List<AreaValueTeam> AreaValues { get; set; } = new List<AreaValueTeam>(); // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public int TimeToGetControl { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public int TimeToLoseControl { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float ReturnMultiplier { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public int OnlyTakeableByTeam { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float ShowRadius { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float HideRadius { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float AddedMultiplierPerPlayer { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float Modify3DIconVerticalOffset { get; set; } // 0xA4 (164)
		
		[ContainerField(168)]
		public CapturableType CapturableType { get; set; } = new CapturableType(); // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable]
		public string IntruderWarningSID { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public bool IsCapturedInUpperSphere { get; set; } // 0xB0 (176)
		
		[ContainerField(177), LayoutImmutable, Blittable]
		public bool DisableWhenLosingControl { get; set; } // 0xB1 (177)
		
		[ContainerField(178), LayoutImmutable, Blittable]
		public bool LoseControlWhenNotClose { get; set; } // 0xB2 (178)
		
		[ContainerField(179), LayoutImmutable, Blittable]
		public bool DisableIfEnemyInside { get; set; } // 0xB3 (179)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public bool IsVisible { get; set; } // 0xB4 (180)
		
		[ContainerField(181), LayoutImmutable, Blittable]
		public bool ForceSnap { get; set; } // 0xB5 (181)
		
		[ContainerField(182), LayoutImmutable, Blittable]
		public bool UseAreaValuesPerTeam { get; set; } // 0xB6 (182)
		
		[ContainerField(183), LayoutImmutable, Blittable]
		public bool IntruderWarning { get; set; } // 0xB7 (183)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public bool ShowOnMinimap { get; set; } // 0xB8 (184)
		
		[ContainerField(185), LayoutImmutable, Blittable]
		public bool HoistFlag { get; set; } // 0xB9 (185)
		
		[ContainerField(186), LayoutImmutable, Blittable]
		public bool StartAtBottom { get; set; } // 0xBA (186)
		
		[ContainerField(187), LayoutImmutable, Blittable]
		public bool RemoveWhenCaptured { get; set; } // 0xBB (187)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public bool SeesawCapturing { get; set; } // 0xBC (188)
		
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
