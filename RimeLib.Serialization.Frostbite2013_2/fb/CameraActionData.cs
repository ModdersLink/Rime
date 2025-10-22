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
public class CameraActionData
	: fb.GameShared.SimpleMovementActionBaseData
{
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public CameraMovementActionMode ActionMode { get; set; } = CameraMovementActionMode.CameraMovementActionMode_Start;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) ActionMode);
		p_Writer.WriteNullBytes(4);
	}
}

