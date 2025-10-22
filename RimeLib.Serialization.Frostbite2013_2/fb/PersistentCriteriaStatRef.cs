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

using fb.GameShared;
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(8, 48)]
public class PersistentCriteriaStatRef
	: fb.GameShared.AbstractPersistentStatRef
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<CriteriaData> Criteria { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<StatsCategoryBaseData> ParamX { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<StatsCategoryBaseData> ParamY { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<AwardData> CriteriaOwner { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Criteria));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ParamX));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ParamY));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CriteriaOwner));
		p_Writer.WriteNullBytes(4);
	}
}

