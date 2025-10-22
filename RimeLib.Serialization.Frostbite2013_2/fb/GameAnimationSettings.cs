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

namespace fb.GameShared;

[ContainerType(8, 96)]
public class GameAnimationSettings
	: fb.Core.SystemSettings
{
	public GameAnimationSettings()
	{
		//SystemSettings
		Name = @"GameAnimation";
	}
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<string> AntOnClientOnlyGamemodes { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float TemporalLoddingFirstDeltaTime { get; set; } = 0.020f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float TemporalLoddingSecondDeltaTime { get; set; } = 0.040f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float TemporalLoddingThirdDeltaTime { get; set; } = 0.060f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float TemporalLoddingFourthDeltaTime { get; set; } = 0.080f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float TemporalLoddingFifthDeltaTime { get; set; } = 0.100f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float TemporalLoddingSixthDeltaTime { get; set; } = 0.120f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float TemporalLoddingFirstDistance { get; set; } = 2.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float TemporalLoddingSecondDistance { get; set; } = 30.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float TemporalLoddingThirdDistance { get; set; } = 60.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float TemporalLoddingFourthDistance { get; set; } = 90.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float TemporalLoddingFifthDistance { get; set; } = 120.000f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float TemporalLoddingSixthDistance { get; set; } = 150.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float TemporalLoddingFarDistance { get; set; } = 208.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public bool UseAnimationDrivenCharacter { get; set; } = false;
	
	[ContainerField(0x5d), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
	public bool ServerEnable { get; set; } = true;
	
	[ContainerField(0x5e), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
	public bool ClientEnable { get; set; } = true;
	
	[ContainerField(0x5f), LayoutImmutable, Blittable, JsonProperty(Order = 95)]
	public bool UseRawGamepadInput { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_AntOnClientOnlyGamemodes = p_EbxWriter.GetArrayWriter(AntOnClientOnlyGamemodes.GetType(), AntOnClientOnlyGamemodes.Count);
		p_Writer.Write(s_AntOnClientOnlyGamemodes.ArrayIndex);
		foreach (var s_Entry in AntOnClientOnlyGamemodes)
		{
			s_AntOnClientOnlyGamemodes.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(TemporalLoddingFirstDeltaTime);
		p_Writer.Write(TemporalLoddingSecondDeltaTime);
		p_Writer.Write(TemporalLoddingThirdDeltaTime);
		p_Writer.Write(TemporalLoddingFourthDeltaTime);
		p_Writer.Write(TemporalLoddingFifthDeltaTime);
		p_Writer.Write(TemporalLoddingSixthDeltaTime);
		p_Writer.Write(TemporalLoddingFirstDistance);
		p_Writer.Write(TemporalLoddingSecondDistance);
		p_Writer.Write(TemporalLoddingThirdDistance);
		p_Writer.Write(TemporalLoddingFourthDistance);
		p_Writer.Write(TemporalLoddingFifthDistance);
		p_Writer.Write(TemporalLoddingSixthDistance);
		p_Writer.Write(TemporalLoddingFarDistance);
		p_Writer.Write(UseAnimationDrivenCharacter);
		p_Writer.Write(ServerEnable);
		p_Writer.Write(ClientEnable);
		p_Writer.Write(UseRawGamepadInput);
	}
}

