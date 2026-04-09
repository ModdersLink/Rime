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
	[ContainerType(16, 192)]
	public partial class CapturePointEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private int _EnemyTicketLossWhenCaptured;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private int _MinNrToTakeControl;

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private RefArray<ObjectBlueprint> _FlagTemplates = new();

		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private CtrRef<ObjectBlueprint> _CapturePoint = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private TeamId _InitialOwnerTeam = new();

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _CaptureRadius;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private int _MaxCaptureMultiplier;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private int _AreaValue;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private uint _SpawnMenuListOrdinal;

		[ObservableProperty]
		[property: ContainerField(132), JsonProperty(Order = 132)]
		private List<AreaValueTeam> _AreaValues = new();

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private int _TimeToGetControl;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private int _TimeToLoseControl;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _ReturnMultiplier;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private int _OnlyTakeableByTeam;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _ShowRadius;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private float _HideRadius;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _AddedMultiplierPerPlayer;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _Modify3DIconVerticalOffset;

		[ObservableProperty]
		[property: ContainerField(168), JsonProperty(Order = 168)]
		private CapturableType _CapturableType = new();

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, JsonProperty(Order = 172)]
		private string _IntruderWarningSID = string.Empty;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private bool _IsCapturedInUpperSphere;

		[ObservableProperty]
		[property: ContainerField(177), LayoutImmutable, Blittable, JsonProperty(Order = 177)]
		private bool _DisableWhenLosingControl;

		[ObservableProperty]
		[property: ContainerField(178), LayoutImmutable, Blittable, JsonProperty(Order = 178)]
		private bool _LoseControlWhenNotClose;

		[ObservableProperty]
		[property: ContainerField(179), LayoutImmutable, Blittable, JsonProperty(Order = 179)]
		private bool _DisableIfEnemyInside;

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private bool _IsVisible;

		[ObservableProperty]
		[property: ContainerField(181), LayoutImmutable, Blittable, JsonProperty(Order = 181)]
		private bool _ForceSnap;

		[ObservableProperty]
		[property: ContainerField(182), LayoutImmutable, Blittable, JsonProperty(Order = 182)]
		private bool _UseAreaValuesPerTeam;

		[ObservableProperty]
		[property: ContainerField(183), LayoutImmutable, Blittable, JsonProperty(Order = 183)]
		private bool _IntruderWarning;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private bool _ShowOnMinimap;

		[ObservableProperty]
		[property: ContainerField(185), LayoutImmutable, Blittable, JsonProperty(Order = 185)]
		private bool _HoistFlag;

		[ObservableProperty]
		[property: ContainerField(186), LayoutImmutable, Blittable, JsonProperty(Order = 186)]
		private bool _StartAtBottom;

		[ObservableProperty]
		[property: ContainerField(187), LayoutImmutable, Blittable, JsonProperty(Order = 187)]
		private bool _RemoveWhenCaptured;

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private bool _SeesawCapturing;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(EnemyTicketLossWhenCaptured);
			p_Writer.Write(MinNrToTakeControl);
			(RimeWriter Writer, uint ArrayIndex) s_FlagTemplates = p_EbxWriter.GetArrayWriter(FlagTemplates.GetType(), FlagTemplates.Count);
			p_Writer.Write(s_FlagTemplates.ArrayIndex);
			foreach (var s_Entry in FlagTemplates)
			{
				s_FlagTemplates.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(CapturePoint));
			p_Writer.Write((int) InitialOwnerTeam);
			p_Writer.Write(CaptureRadius);
			p_Writer.Write(MaxCaptureMultiplier);
			p_Writer.Write(AreaValue);
			p_Writer.Write(SpawnMenuListOrdinal);
			(RimeWriter Writer, uint ArrayIndex) s_AreaValues = p_EbxWriter.GetArrayWriter(AreaValues.GetType(), AreaValues.Count);
			p_Writer.Write(s_AreaValues.ArrayIndex);
			foreach (var s_Entry in AreaValues)
			{
				s_Entry.Serialize(s_AreaValues.Writer, p_EbxWriter);
			}
			p_Writer.Write(TimeToGetControl);
			p_Writer.Write(TimeToLoseControl);
			p_Writer.Write(ReturnMultiplier);
			p_Writer.Write(OnlyTakeableByTeam);
			p_Writer.Write(ShowRadius);
			p_Writer.Write(HideRadius);
			p_Writer.Write(AddedMultiplierPerPlayer);
			p_Writer.Write(Modify3DIconVerticalOffset);
			p_Writer.Write((int) CapturableType);
			p_Writer.Write(p_EbxWriter.WriteString(IntruderWarningSID));
			p_Writer.Write(IsCapturedInUpperSphere);
			p_Writer.Write(DisableWhenLosingControl);
			p_Writer.Write(LoseControlWhenNotClose);
			p_Writer.Write(DisableIfEnemyInside);
			p_Writer.Write(IsVisible);
			p_Writer.Write(ForceSnap);
			p_Writer.Write(UseAreaValuesPerTeam);
			p_Writer.Write(IntruderWarning);
			p_Writer.Write(ShowOnMinimap);
			p_Writer.Write(HoistFlag);
			p_Writer.Write(StartAtBottom);
			p_Writer.Write(RemoveWhenCaptured);
			p_Writer.Write(SeesawCapturing);
			p_Writer.WriteNullBytes(3);
		}
	}
}
