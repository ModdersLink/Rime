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

namespace fb.VeniceShared;

[ContainerType(16, 448)]
public class SoldierEmoteComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public SoldierEmoteBinding Binding { get; set; } = new();
	
	[ContainerField(0x1b0), JsonProperty(Order = 432)]
	public RefArray<SoldierEmoteNetworkedMessageMapping> NetworkedMessageMappings { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Binding.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_NetworkedMessageMappings = p_EbxWriter.GetArrayWriter(NetworkedMessageMappings.GetType(), NetworkedMessageMappings.Count);
		p_Writer.Write(s_NetworkedMessageMappings.ArrayIndex);
		foreach (var s_Entry in NetworkedMessageMappings)
		{
			s_NetworkedMessageMappings.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(12);
	}
}

