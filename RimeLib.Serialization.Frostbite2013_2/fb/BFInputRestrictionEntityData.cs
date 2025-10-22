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
using fb.Entity;
using fb.Core;

namespace fb.Venice;

[ContainerType(8, 32)]
public class BFInputRestrictionEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<InputConceptIdentifiers> InputConcepts { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_InputConcepts = p_EbxWriter.GetArrayWriter(InputConcepts.GetType(), InputConcepts.Count);
		p_Writer.Write(s_InputConcepts.ArrayIndex);
		foreach (var s_Entry in InputConcepts)
		{
			s_InputConcepts.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
	}
}

