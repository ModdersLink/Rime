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

namespace fb.Entity;

[ContainerType(8, 80)]
public class TimelineEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<TimelineData> TimelineData { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public UpdatePass ClientUpdatePass { get; set; } = UpdatePass.UpdatePass_PostFrame;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public UpdatePass ServerUpdatePass { get; set; } = UpdatePass.UpdatePass_PreSim;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float InitTime { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float StartTime { get; set; } = 0.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float EndTime { get; set; } = 10.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float JumpTime { get; set; } = 0.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float PlaybackRate { get; set; } = 1.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float ExternalTime { get; set; } = 0.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public bool AutoPlay { get; set; } = false;
	
	[ContainerField(0x49), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
	public bool AutoInitConnectedProperties { get; set; } = false;
	
	[ContainerField(0x4a), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
	public bool ResetOnFinished { get; set; } = true;
	
	[ContainerField(0x4b), LayoutImmutable, Blittable, JsonProperty(Order = 75)]
	public bool AllowAnimationCarryForward { get; set; } = false;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public bool Looping { get; set; } = false;
	
	[ContainerField(0x4d), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
	public bool Infinite { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(TimelineData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) ClientUpdatePass);
		p_Writer.Write((int) ServerUpdatePass);
		p_Writer.Write(InitTime);
		p_Writer.Write(StartTime);
		p_Writer.Write(EndTime);
		p_Writer.Write(JumpTime);
		p_Writer.Write(PlaybackRate);
		p_Writer.Write(ExternalTime);
		p_Writer.Write(AutoPlay);
		p_Writer.Write(AutoInitConnectedProperties);
		p_Writer.Write(ResetOnFinished);
		p_Writer.Write(AllowAnimationCarryForward);
		p_Writer.Write(Looping);
		p_Writer.Write(Infinite);
		p_Writer.WriteNullBytes(2);
	}
}

