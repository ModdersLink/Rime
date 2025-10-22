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

[ContainerType(8, 56)]
public class FrontEndComponentData
	: fb.UI.UIComponentData
{
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<UIStreamInstallGroup> Groups { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Groups = p_EbxWriter.GetArrayWriter(Groups.GetType(), Groups.Count);
		p_Writer.Write(s_Groups.ArrayIndex);
		foreach (var s_Entry in Groups)
		{
			s_Entry.Serialize(s_Groups.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

