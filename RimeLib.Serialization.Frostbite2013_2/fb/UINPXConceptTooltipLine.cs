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

namespace fb.VeniceShared;

[ContainerType(8, 40)]
public class UINPXConceptTooltipLine
	: fb.VeniceShared.UINPXLine
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string ActionMapsId { get; set; } = string.Empty;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public InputConceptIdentifiers ConceptIdentifier { get; set; } = InputConceptIdentifiers.ConceptMoveFB;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public UIInputActionAxisDisplay Axis { get; set; } = UIInputActionAxisDisplay.UIInputActionAxisDisplay_Positive;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string Description { get; set; } = string.Empty;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(ActionMapsId));
		p_Writer.Write((int) ConceptIdentifier);
		p_Writer.Write((int) Axis);
		p_Writer.Write(p_EbxWriter.WriteString(Description));
	}
}

