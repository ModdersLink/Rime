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

using fb.Core;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 88)]
public class ObjectiveEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<MissionObjectiveHudData> HudData { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public ObjectiveType ObjectiveType { get; set; } = fb.GameShared.ObjectiveType.OTPrimary;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float DisplayTime { get; set; } = -1.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float DelayTime { get; set; } = 0.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string ObjectiveSid { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string ObjectiveBriefSid { get; set; } = string.Empty;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string SuccessSid { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public MessageReciever Reciever { get; set; } = MessageReciever.MrAll;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public TeamId TeamId { get; set; } = fb.GameShared.TeamId.TeamNeutral;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public SquadId SquadId { get; set; } = fb.GameShared.SquadId.SquadNone;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public bool Tutorial { get; set; } = false;
	
	[ContainerField(0x55), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
	public bool RetriggerSuccessOnShowObjective { get; set; } = false;
	
	[ContainerField(0x56), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
	public bool DisplaySuccess { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(HudData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) ObjectiveType);
		p_Writer.Write(DisplayTime);
		p_Writer.Write(DelayTime);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(ObjectiveSid));
		p_Writer.Write(p_EbxWriter.WriteString(ObjectiveBriefSid));
		p_Writer.Write(p_EbxWriter.WriteString(SuccessSid));
		p_Writer.Write((int) Reciever);
		p_Writer.Write((int) TeamId);
		p_Writer.Write((int) SquadId);
		p_Writer.Write(Tutorial);
		p_Writer.Write(RetriggerSuccessOnShowObjective);
		p_Writer.Write(DisplaySuccess);
		p_Writer.WriteNullBytes(1);
	}
}

