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

namespace fb.Entity;

[ContainerType(8, 72)]
public class DataContainerCollectionBlueprint
	: fb.Entity.Blueprint
{
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public RefArray<DataContainer> DataContainers { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_DataContainers = p_EbxWriter.GetArrayWriter(DataContainers.GetType(), DataContainers.Count);
		p_Writer.Write(s_DataContainers.ArrayIndex);
		foreach (var s_Entry in DataContainers)
		{
			s_DataContainers.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

