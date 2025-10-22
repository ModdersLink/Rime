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

[ContainerType(8, 40)]
public class InputRecorderData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string FileNamePrefix { get; set; } = @"/temp/SoldierTest_";
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string FileName { get; set; } = string.Empty;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int ToggleRecordAction { get; set; } = 871087131;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool AutoIncrementFileName { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(FileNamePrefix));
		p_Writer.Write(p_EbxWriter.WriteString(FileName));
		p_Writer.Write(ToggleRecordAction);
		p_Writer.Write(AutoIncrementFileName);
		p_Writer.WriteNullBytes(3);
	}
}

