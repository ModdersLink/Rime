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
public class InputCurveData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<int> AffectedInputs { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<Vec2> InputModifierCurve { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public bool HandleMultipleInputsAsSquare { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_AffectedInputs = p_EbxWriter.GetArrayWriter(AffectedInputs.GetType(), AffectedInputs.Count);
		p_Writer.Write(s_AffectedInputs.ArrayIndex);
		foreach (var s_Entry in AffectedInputs)
		{
			s_AffectedInputs.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InputModifierCurve = p_EbxWriter.GetArrayWriter(InputModifierCurve.GetType(), InputModifierCurve.Count);
		p_Writer.Write(s_InputModifierCurve.ArrayIndex);
		foreach (var s_Entry in InputModifierCurve)
		{
			s_Entry.Serialize(s_InputModifierCurve.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(HandleMultipleInputsAsSquare);
		p_Writer.WriteNullBytes(7);
	}
}

