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

[ContainerType(8, 48)]
public class InputActionsData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string NameSid { get; set; } = string.Empty;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public InputConceptIdentifiers ConceptIdentifier { get; set; } = InputConceptIdentifiers.ConceptUndefined;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public InputConceptIdentifiers CopyKeyBindingFrom { get; set; } = InputConceptIdentifiers.ConceptUndefined;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<InputActionData> InputActions { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool HideInKeyBindings { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(NameSid));
		p_Writer.Write((int) ConceptIdentifier);
		p_Writer.Write((int) CopyKeyBindingFrom);
		(RimeWriter Writer, uint ArrayIndex) s_InputActions = p_EbxWriter.GetArrayWriter(InputActions.GetType(), InputActions.Count);
		p_Writer.Write(s_InputActions.ArrayIndex);
		foreach (var s_Entry in InputActions)
		{
			s_InputActions.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(HideInKeyBindings);
		p_Writer.WriteNullBytes(7);
	}
}

