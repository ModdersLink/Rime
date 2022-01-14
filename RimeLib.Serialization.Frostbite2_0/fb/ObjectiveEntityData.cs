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
	[ContainerType(16, 144)]
	public class ObjectiveEntityData :
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, JsonProperty(Order = 96)]
		public string ObjectiveBriefSid { get; set; } = string.Empty;

		[ContainerField(100), LayoutImmutable, JsonProperty(Order = 100)]
		public string ObjectiveSid { get; set; } = string.Empty;

		[ContainerField(104), JsonProperty(Order = 104)]
		public CtrRef<MissionObjectiveHudData> HudData { get; set; } = new();

		[ContainerField(108), JsonProperty(Order = 108)]
		public ObjectiveType ObjectiveType { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float DisplayTime { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float DelayTime { get; set; }

		[ContainerField(120), JsonProperty(Order = 120)]
		public SquadId SquadId { get; set; } = new();

		[ContainerField(124), JsonProperty(Order = 124)]
		public TeamId TeamId { get; set; } = new();

		[ContainerField(128), LayoutImmutable, JsonProperty(Order = 128)]
		public string SuccessSid { get; set; } = string.Empty;

		[ContainerField(132), JsonProperty(Order = 132)]
		public MessageReciever Reciever { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public bool RetriggerSuccessOnShowObjective { get; set; }

		[ContainerField(137), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
		public bool Tutorial { get; set; }

		[ContainerField(138), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
		public bool DisplaySuccess { get; set; }

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
