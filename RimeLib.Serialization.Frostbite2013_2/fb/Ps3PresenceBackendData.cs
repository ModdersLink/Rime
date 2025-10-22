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

namespace fb.Online;

[ContainerType(8, 56)]
public class Ps3PresenceBackendData
	: fb.Online.PresenceBackendData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string CommunicationId { get; set; } = string.Empty;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string CommunicationSignature { get; set; } = string.Empty;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<Ps3ParentalLockAgeSettings> ParentalLockAgeSettings { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<Ps3ServiceSettings> ServiceSettings { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(CommunicationId));
		p_Writer.Write(p_EbxWriter.WriteString(CommunicationSignature));
		(RimeWriter Writer, uint ArrayIndex) s_ParentalLockAgeSettings = p_EbxWriter.GetArrayWriter(ParentalLockAgeSettings.GetType(), ParentalLockAgeSettings.Count);
		p_Writer.Write(s_ParentalLockAgeSettings.ArrayIndex);
		foreach (var s_Entry in ParentalLockAgeSettings)
		{
			s_Entry.Serialize(s_ParentalLockAgeSettings.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ServiceSettings = p_EbxWriter.GetArrayWriter(ServiceSettings.GetType(), ServiceSettings.Count);
		p_Writer.Write(s_ServiceSettings.ArrayIndex);
		foreach (var s_Entry in ServiceSettings)
		{
			s_Entry.Serialize(s_ServiceSettings.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

