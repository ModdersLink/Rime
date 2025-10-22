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
using fb.Render;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 64)]
public class SaveEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<TextureAsset> SaveScreenTexture { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string LevelName { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string SaveFileName { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string SaveNameSID { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public bool CheckForHumanPlayer { get; set; } = true;
	
	[ContainerField(0x39), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
	public bool ForceNotifyAllEntitiesOnLoad { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(SaveScreenTexture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(LevelName));
		p_Writer.Write(p_EbxWriter.WriteString(SaveFileName));
		p_Writer.Write(p_EbxWriter.WriteString(SaveNameSID));
		p_Writer.Write(CheckForHumanPlayer);
		p_Writer.Write(ForceNotifyAllEntitiesOnLoad);
		p_Writer.WriteNullBytes(6);
	}
}

