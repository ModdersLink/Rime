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

namespace fb.GameClient;

[ContainerType(8, 56)]
public class UIActionEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public int ActionKey { get; set; } = 0;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<string> Params { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<Asset> ActionAsset { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<string> PropertyParams { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ActionKey);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Params = p_EbxWriter.GetArrayWriter(Params.GetType(), Params.Count);
		p_Writer.Write(s_Params.ArrayIndex);
		foreach (var s_Entry in Params)
		{
			s_Params.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ActionAsset));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PropertyParams = p_EbxWriter.GetArrayWriter(PropertyParams.GetType(), PropertyParams.Count);
		p_Writer.Write(s_PropertyParams.ArrayIndex);
		foreach (var s_Entry in PropertyParams)
		{
			s_PropertyParams.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

