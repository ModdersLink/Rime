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

using fb.UI;
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(8, 64)]
public class UIAwardsScreenCompData
	: fb.UI.UIComponentData
{
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public RefArray<StatsCategoryBaseData> TrackableAwardRow { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public RefArray<StatsCategoryBaseData> TrackableAwardCol { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_TrackableAwardRow = p_EbxWriter.GetArrayWriter(TrackableAwardRow.GetType(), TrackableAwardRow.Count);
		p_Writer.Write(s_TrackableAwardRow.ArrayIndex);
		foreach (var s_Entry in TrackableAwardRow)
		{
			s_TrackableAwardRow.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_TrackableAwardCol = p_EbxWriter.GetArrayWriter(TrackableAwardCol.GetType(), TrackableAwardCol.Count);
		p_Writer.Write(s_TrackableAwardCol.ArrayIndex);
		foreach (var s_Entry in TrackableAwardCol)
		{
			s_TrackableAwardCol.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

