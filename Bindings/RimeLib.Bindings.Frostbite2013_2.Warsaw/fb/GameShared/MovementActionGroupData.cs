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

[ContainerType(8, 32)]
public class MovementActionGroupData
	: fb.GameShared.MovementActionData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public RefArray<MovementActionData> Actions { get; set; } = new();
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public bool RunSimultaneously { get; set; } = false;
	
	[ContainerField(0x19), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
	public bool RestartChildren { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Actions = p_EbxWriter.GetArrayWriter(Actions.GetType(), Actions.Count);
		p_Writer.Write(s_Actions.ArrayIndex);
		foreach (var s_Entry in Actions)
		{
			s_Actions.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(RunSimultaneously);
		p_Writer.Write(RestartChildren);
		p_Writer.WriteNullBytes(6);
	}
}

