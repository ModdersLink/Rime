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

namespace fb.BFAI2Data;

[ContainerType(8, 72)]
public class SquadMovementSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<CoverQueryData> IdleCoverQuery { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<CoverQueryData> AlertedCoverQuery { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<CoverQueryData> FriendlyAreaCoverQuery { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<MoveSettings> MoveSettings { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<CoverControlSettings> CoverSettings { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float MaxAcceptableDistanceToHuman { get; set; } = 20.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float MaxAcceptableHeightDifferenceToHuman { get; set; } = 2.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float CoverCompromisedTimer { get; set; } = 10.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public bool InvalidateOpenCoverIfAlerted { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(IdleCoverQuery));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AlertedCoverQuery));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FriendlyAreaCoverQuery));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(MoveSettings));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CoverSettings));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MaxAcceptableDistanceToHuman);
		p_Writer.Write(MaxAcceptableHeightDifferenceToHuman);
		p_Writer.Write(CoverCompromisedTimer);
		p_Writer.Write(InvalidateOpenCoverIfAlerted);
		p_Writer.WriteNullBytes(3);
	}
}

