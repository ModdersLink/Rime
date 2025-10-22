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

namespace fb.Origin;

[ContainerType(8, 88)]
public class OriginSettings
	: fb.Core.SystemSettings
{
	public OriginSettings()
	{
		//SystemSettings
		Name = @"Origin";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string ContentId { get; set; } = @"qatest_ebisu_sdk_pdlc";
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string Title { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string MultiplayerId { get; set; } = @"qatest_sdk_multiplayer";
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string Language { get; set; } = @"en_US";
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public OriginTokenType TokenType { get; set; } = OriginTokenType.OriginTokenType_Ticket;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string AuthCodeClientId { get; set; } = string.Empty;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool Enabled { get; set; } = true;
	
	[ContainerField(0x51), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
	public bool Log { get; set; } = false;
	
	[ContainerField(0x52), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
	public bool AllowProductionEnvironment { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(ContentId));
		p_Writer.Write(p_EbxWriter.WriteString(Title));
		p_Writer.Write(p_EbxWriter.WriteString(MultiplayerId));
		p_Writer.Write(p_EbxWriter.WriteString(Language));
		p_Writer.Write((int) TokenType);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(AuthCodeClientId));
		p_Writer.Write(Enabled);
		p_Writer.Write(Log);
		p_Writer.Write(AllowProductionEnvironment);
		p_Writer.WriteNullBytes(5);
	}
}

