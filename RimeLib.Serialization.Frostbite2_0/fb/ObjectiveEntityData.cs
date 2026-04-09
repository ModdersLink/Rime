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
	[ContainerType(16, 144)]
	public partial class ObjectiveEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, JsonProperty(Order = 96)]
		private string _ObjectiveBriefSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, JsonProperty(Order = 100)]
		private string _ObjectiveSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private CtrRef<MissionObjectiveHudData> _HudData = new();

		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private ObjectiveType _ObjectiveType = new();

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _DisplayTime;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _DelayTime;

		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private SquadId _SquadId = new();

		[ObservableProperty]
		[property: ContainerField(124), JsonProperty(Order = 124)]
		private TeamId _TeamId = new();

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, JsonProperty(Order = 128)]
		private string _SuccessSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(132), JsonProperty(Order = 132)]
		private MessageReciever _Reciever = new();

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private bool _RetriggerSuccessOnShowObjective;

		[ObservableProperty]
		[property: ContainerField(137), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
		private bool _Tutorial;

		[ObservableProperty]
		[property: ContainerField(138), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
		private bool _DisplaySuccess;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(ObjectiveBriefSid));
			p_Writer.Write(p_EbxWriter.WriteString(ObjectiveSid));
			p_Writer.Write(p_EbxWriter.WriteImport(HudData));
			p_Writer.Write((int) ObjectiveType);
			p_Writer.Write(DisplayTime);
			p_Writer.Write(DelayTime);
			p_Writer.Write((int) SquadId);
			p_Writer.Write((int) TeamId);
			p_Writer.Write(p_EbxWriter.WriteString(SuccessSid));
			p_Writer.Write((int) Reciever);
			p_Writer.Write(RetriggerSuccessOnShowObjective);
			p_Writer.Write(Tutorial);
			p_Writer.Write(DisplaySuccess);
			p_Writer.WriteNullBytes(5);
		}
	}
}
