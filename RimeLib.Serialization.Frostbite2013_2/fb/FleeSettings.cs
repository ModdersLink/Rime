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

[ContainerType(8, 40)]
public class FleeSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<CoverQueryData> CoverQuery { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<MoveSettings> MoveSettings { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<CoverControlSettings> CoverSettings { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(CoverQuery));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(MoveSettings));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CoverSettings));
		p_Writer.WriteNullBytes(4);
	}
}

