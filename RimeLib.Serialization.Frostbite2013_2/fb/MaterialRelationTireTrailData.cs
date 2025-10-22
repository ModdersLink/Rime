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

using fb.Entity;
using fb.Core;

namespace fb.TireTrails;

[ContainerType(8, 24)]
public class MaterialRelationTireTrailData
	: fb.Entity.PhysicsMaterialRelationPropertyData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<RibbonVolumeTemplateData> ContactTrail { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(ContactTrail));
		p_Writer.WriteNullBytes(4);
	}
}

