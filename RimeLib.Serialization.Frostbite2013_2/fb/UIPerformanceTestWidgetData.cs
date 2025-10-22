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
using fb.GameShared;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(8, 120)]
public class UIPerformanceTestWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float SecondsToProbe { get; set; } = 5.000f;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public List<UIPerformanceMetricSettings> Settings { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SecondsToProbe);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Settings = p_EbxWriter.GetArrayWriter(Settings.GetType(), Settings.Count);
		p_Writer.Write(s_Settings.ArrayIndex);
		foreach (var s_Entry in Settings)
		{
			s_Entry.Serialize(s_Settings.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

