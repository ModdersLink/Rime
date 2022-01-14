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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 20)]
	public class InputCurveData :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public List<EntryInputActionEnum> AffectedInputs { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public List<Vec2> InputModifierCurve { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public bool HandleMultipleInputsAsSquare { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_AffectedInputs = p_EbxWriter.GetArrayWriter(AffectedInputs.GetType(), AffectedInputs.Count);
			p_Writer.Write(s_AffectedInputs.ArrayIndex);
			foreach (var s_Entry in AffectedInputs)
			{
				s_AffectedInputs.Writer.Write((int) s_Entry);
			}
			(RimeWriter Writer, uint ArrayIndex) s_InputModifierCurve = p_EbxWriter.GetArrayWriter(InputModifierCurve.GetType(), InputModifierCurve.Count);
			p_Writer.Write(s_InputModifierCurve.ArrayIndex);
			foreach (var s_Entry in InputModifierCurve)
			{
				s_Entry.Serialize(s_InputModifierCurve.Writer, p_EbxWriter);
			}
			p_Writer.Write(HandleMultipleInputsAsSquare);
			p_Writer.WriteNullBytes(3);
		}
	}
}
