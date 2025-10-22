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

using fb.GameShared;
using fb.Core;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(8, 112)]
public class UIHitIndicatorWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public List<UIHitIndicatorIcon> HitIndicatorIcons { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_HitIndicatorIcons = p_EbxWriter.GetArrayWriter(HitIndicatorIcons.GetType(), HitIndicatorIcons.Count);
		p_Writer.Write(s_HitIndicatorIcons.ArrayIndex);
		foreach (var s_Entry in HitIndicatorIcons)
		{
			s_Entry.Serialize(s_HitIndicatorIcons.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

