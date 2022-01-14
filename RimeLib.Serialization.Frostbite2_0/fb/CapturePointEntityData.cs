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
	[ContainerType(16, 192)]
	public class CapturePointEntityData :
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public int EnemyTicketLossWhenCaptured { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public int MinNrToTakeControl { get; set; }

		[ContainerField(104), JsonProperty(Order = 104)]
		public RefArray<ObjectBlueprint> FlagTemplates { get; set; } = new();

		[ContainerField(108), JsonProperty(Order = 108)]
		public CtrRef<ObjectBlueprint> CapturePoint { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public TeamId InitialOwnerTeam { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float CaptureRadius { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public int MaxCaptureMultiplier { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public int AreaValue { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public uint SpawnMenuListOrdinal { get; set; }

		[ContainerField(132), JsonProperty(Order = 132)]
		public List<AreaValueTeam> AreaValues { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public int TimeToGetControl { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public int TimeToLoseControl { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float ReturnMultiplier { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public int OnlyTakeableByTeam { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float ShowRadius { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public float HideRadius { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float AddedMultiplierPerPlayer { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float Modify3DIconVerticalOffset { get; set; }

		[ContainerField(168), JsonProperty(Order = 168)]
		public CapturableType CapturableType { get; set; } = new();

		[ContainerField(172), LayoutImmutable, JsonProperty(Order = 172)]
		public string IntruderWarningSID { get; set; } = string.Empty;

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public bool IsCapturedInUpperSphere { get; set; }

		[ContainerField(177), LayoutImmutable, Blittable, JsonProperty(Order = 177)]
		public bool DisableWhenLosingControl { get; set; }

		[ContainerField(178), LayoutImmutable, Blittable, JsonProperty(Order = 178)]
		public bool LoseControlWhenNotClose { get; set; }

		[ContainerField(179), LayoutImmutable, Blittable, JsonProperty(Order = 179)]
		public bool DisableIfEnemyInside { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public bool IsVisible { get; set; }

		[ContainerField(181), LayoutImmutable, Blittable, JsonProperty(Order = 181)]
		public bool ForceSnap { get; set; }

		[ContainerField(182), LayoutImmutable, Blittable, JsonProperty(Order = 182)]
		public bool UseAreaValuesPerTeam { get; set; }

		[ContainerField(183), LayoutImmutable, Blittable, JsonProperty(Order = 183)]
		public bool IntruderWarning { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public bool ShowOnMinimap { get; set; }

		[ContainerField(185), LayoutImmutable, Blittable, JsonProperty(Order = 185)]
		public bool HoistFlag { get; set; }

		[ContainerField(186), LayoutImmutable, Blittable, JsonProperty(Order = 186)]
		public bool StartAtBottom { get; set; }

		[ContainerField(187), LayoutImmutable, Blittable, JsonProperty(Order = 187)]
		public bool RemoveWhenCaptured { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public bool SeesawCapturing { get; set; }

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
