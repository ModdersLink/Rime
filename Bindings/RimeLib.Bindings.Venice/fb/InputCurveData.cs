///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class InputCurveData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<EntryInputActionEnum> AffectedInputs { get; set; } = new List<EntryInputActionEnum>(); // 0x8 (8)
		
		[ContainerField(12)]
		public List<Vec2> InputModifierCurve { get; set; } = new List<Vec2>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool HandleMultipleInputsAsSquare { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 337107346:
					if (p_Value.GetType() == typeof (List<uint>))
						AffectedInputs = ((List<uint>) p_Value).Select(x => (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), x)).ToList();
					else
						AffectedInputs = (List<EntryInputActionEnum>) p_Value;
					break;

				case 1217881747:
					InputModifierCurve = (List<Vec2>) p_Value;
					break;

				case 1190597481:
					HandleMultipleInputsAsSquare = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 337107346:
					return AffectedInputs;

				case 1217881747:
					return InputModifierCurve;

				case 1190597481:
					return HandleMultipleInputsAsSquare;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 337107346:
					return typeof(InputCurveData).GetProperty(nameof(AffectedInputs));

				case 1217881747:
					return typeof(InputCurveData).GetProperty(nameof(InputModifierCurve));

				case 1190597481:
					return typeof(InputCurveData).GetProperty(nameof(HandleMultipleInputsAsSquare));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
