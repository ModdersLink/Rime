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
	[ContainerType(16, 160)]
	public partial class LifeCounterEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private int _StartingLifeCount;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _DisplayTime;

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private TeamId _TeamId = new();

		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private List<int> _LifeTresholdValues = new();

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private int _UiShowCountLowerThreshold;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private int _UiShowCountUpperThreshold;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private int _BaseCount;

		[ObservableProperty]
		[property: ContainerField(124), JsonProperty(Order = 124)]
		private List<float> _ReinforceTable = new();

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private int _ReinforceThreshold;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, JsonProperty(Order = 132)]
		private string _ReinforceMessageSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _FightHarderTreshold;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _DefensiveKillRadius;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _FallbackTime;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, JsonProperty(Order = 148)]
		private string _FightHarderMessageSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private bool _Attacker;

		[ObservableProperty]
		[property: ContainerField(153), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
		private bool _SetBestSquadSpawner;

		[ObservableProperty]
		[property: ContainerField(154), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
		private bool _SimpleReinforce;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(StartingLifeCount);
			p_Writer.Write(DisplayTime);
			p_Writer.Write((int) TeamId);
			(RimeWriter Writer, uint ArrayIndex) s_LifeTresholdValues = p_EbxWriter.GetArrayWriter(LifeTresholdValues.GetType(), LifeTresholdValues.Count);
			p_Writer.Write(s_LifeTresholdValues.ArrayIndex);
			foreach (var s_Entry in LifeTresholdValues)
			{
				s_LifeTresholdValues.Writer.Write(s_Entry);
			}
			p_Writer.Write(UiShowCountLowerThreshold);
			p_Writer.Write(UiShowCountUpperThreshold);
			p_Writer.Write(BaseCount);
			(RimeWriter Writer, uint ArrayIndex) s_ReinforceTable = p_EbxWriter.GetArrayWriter(ReinforceTable.GetType(), ReinforceTable.Count);
			p_Writer.Write(s_ReinforceTable.ArrayIndex);
			foreach (var s_Entry in ReinforceTable)
			{
				s_ReinforceTable.Writer.Write(s_Entry);
			}
			p_Writer.Write(ReinforceThreshold);
			p_Writer.Write(p_EbxWriter.WriteString(ReinforceMessageSid));
			p_Writer.Write(FightHarderTreshold);
			p_Writer.Write(DefensiveKillRadius);
			p_Writer.Write(FallbackTime);
			p_Writer.Write(p_EbxWriter.WriteString(FightHarderMessageSid));
			p_Writer.Write(Attacker);
			p_Writer.Write(SetBestSquadSpawner);
			p_Writer.Write(SimpleReinforce);
			p_Writer.WriteNullBytes(5);
		}
	}
}
