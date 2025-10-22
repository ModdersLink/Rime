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

[ContainerType(8, 56)]
public class WindowSettings
	: fb.Core.SystemSettings
{
	public WindowSettings()
	{
		//SystemSettings
		Name = @"Window";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int PosX { get; set; } = 0;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public int PosY { get; set; } = 0;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint Width { get; set; } = 0;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public uint Height { get; set; } = 0;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool AutoSize { get; set; } = false;
	
	[ContainerField(0x31), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
	public bool FullscreenAutoSize { get; set; } = true;
	
	[ContainerField(0x32), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
	public bool EnableEscape { get; set; } = true;
	
	[ContainerField(0x33), LayoutImmutable, Blittable, JsonProperty(Order = 51)]
	public bool EnableInputOnActivate { get; set; } = true;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public bool HibernateOnClose { get; set; } = false;
	
	[ContainerField(0x35), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
	public bool Hidden { get; set; } = false;
	
	[ContainerField(0x36), LayoutImmutable, Blittable, JsonProperty(Order = 54)]
	public bool Minimized { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(PosX);
		p_Writer.Write(PosY);
		p_Writer.Write(Width);
		p_Writer.Write(Height);
		p_Writer.Write(AutoSize);
		p_Writer.Write(FullscreenAutoSize);
		p_Writer.Write(EnableEscape);
		p_Writer.Write(EnableInputOnActivate);
		p_Writer.Write(HibernateOnClose);
		p_Writer.Write(Hidden);
		p_Writer.Write(Minimized);
		p_Writer.WriteNullBytes(1);
	}
}

