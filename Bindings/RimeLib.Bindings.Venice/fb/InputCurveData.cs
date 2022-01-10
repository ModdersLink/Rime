///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 20)]
	public class InputCurveData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<EntryInputActionEnum> AffectedInputs { get; set; } = new();

		[ContainerField(12)]
		public List<Vec2> InputModifierCurve { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public bool HandleMultipleInputsAsSquare { get; set; }

		public static void Deserialize(InputCurveData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.AffectedInputs.Clear();
			(RimeReader Reader, uint Count) s_AffectedInputs = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_AffectedInputs.Count; ++i)
			{
				var s_Value = (EntryInputActionEnum) s_AffectedInputs.Reader.ReadInt32();
				p_Instance.AffectedInputs.Add(s_Value);
			}
			
			s_AffectedInputs.Reader.Dispose();
			p_Instance.InputModifierCurve.Clear();
			(RimeReader Reader, uint Count) s_InputModifierCurve = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InputModifierCurve.Count; ++i)
			{
				var s_Value = new Vec2();
				fb.Vec2.Deserialize(s_Value, s_InputModifierCurve.Reader, p_Parser);
				p_Instance.InputModifierCurve.Add(s_Value);
			}
			
			s_InputModifierCurve.Reader.Dispose();
			p_Instance.HandleMultipleInputsAsSquare = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
