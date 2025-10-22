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
using fb.GameShared;

namespace fb.BFAI2Data;

[ContainerType(8, 72)]
public class MoveSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<AntEnumeration> MoveStyle { get; set; } = new();
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public MoveSpeed MoveSpeed { get; set; } = fb.BFAI2Data.MoveSpeed.MoveSpeed_Run;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float FireTargetDistance { get; set; } = 20.000f;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<WalkSettings> Walk { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<SprintSettings> Sprint { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<StartStopSettings> StartStop { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float StartEvasiveThreshold { get; set; } = 0.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float StopEvasiveThreshold { get; set; } = 0.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public bool Fire { get; set; } = false;
	
	[ContainerField(0x41), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
	public bool IsEvasive { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(MoveStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) MoveSpeed);
		p_Writer.Write(FireTargetDistance);
		p_Writer.Write(p_EbxWriter.WriteImport(Walk));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Sprint));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(StartStop));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(StartEvasiveThreshold);
		p_Writer.Write(StopEvasiveThreshold);
		p_Writer.Write(Fire);
		p_Writer.Write(IsEvasive);
		p_Writer.WriteNullBytes(6);
	}
}

