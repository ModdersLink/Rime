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

namespace fb.UI;

[ContainerType(8, 56)]
public class InstanceOutputNode
	: fb.UI.UINodeData
{
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<UINodePort> In { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public int Id { get; set; } = 0;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public bool DestroyGraph { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(In));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Id);
		p_Writer.Write(DestroyGraph);
		p_Writer.WriteNullBytes(3);
	}
}

