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
using fb.Entity;

namespace fb.Physics;

[ContainerType(16, 128)]
public class DestructionPartComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public RefArray<GameObjectData> Objects { get; set; } = new();
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public uint PartIndex { get; set; } = 0;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public bool Fixed { get; set; } = false;
	
	[ContainerField(0x7d), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
	public bool Fragile { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Objects = p_EbxWriter.GetArrayWriter(Objects.GetType(), Objects.Count);
		p_Writer.Write(s_Objects.ArrayIndex);
		foreach (var s_Entry in Objects)
		{
			s_Objects.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(PartIndex);
		p_Writer.Write(Fixed);
		p_Writer.Write(Fragile);
		p_Writer.WriteNullBytes(2);
	}
}

