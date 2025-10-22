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

namespace fb.VeniceShared;

[ContainerType(8, 48)]
public class SpectatorViewData
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public int Priority { get; set; } = 1;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public int ViewIndex { get; set; } = 0;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<SpectatorViewComponentData> ViewComponents { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool AllowSpectatorCameraInput { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Priority);
		p_Writer.Write(ViewIndex);
		(RimeWriter Writer, uint ArrayIndex) s_ViewComponents = p_EbxWriter.GetArrayWriter(ViewComponents.GetType(), ViewComponents.Count);
		p_Writer.Write(s_ViewComponents.ArrayIndex);
		foreach (var s_Entry in ViewComponents)
		{
			s_ViewComponents.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AllowSpectatorCameraInput);
		p_Writer.WriteNullBytes(7);
	}
}

