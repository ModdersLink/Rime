///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(20), ContainerClass]
	public class InputCurveData : 
		DataContainer
	{
		protected List<EntryInputActionEnum> m_AffectedInputs = new List<EntryInputActionEnum>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(337107346), ContainerArray]
		public List<EntryInputActionEnum> AffectedInputs { get { return m_AffectedInputs; } set { if (OnPropertyChanging("InputCurveData." + nameof(AffectedInputs), this, m_AffectedInputs, value)) m_AffectedInputs = value; } } // 0x8 (8)
		
		protected List<Vec2> m_InputModifierCurve = new List<Vec2>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(1217881747), ContainerArray]
		public List<Vec2> InputModifierCurve { get { return m_InputModifierCurve; } set { if (OnPropertyChanging("InputCurveData." + nameof(InputModifierCurve), this, m_InputModifierCurve, value)) m_InputModifierCurve = value; } } // 0xC (12)
		
		protected bool m_HandleMultipleInputsAsSquare = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1190597481)]
		public bool HandleMultipleInputsAsSquare { get { return m_HandleMultipleInputsAsSquare; } set { if (OnPropertyChanging("InputCurveData." + nameof(HandleMultipleInputsAsSquare), this, m_HandleMultipleInputsAsSquare, value)) m_HandleMultipleInputsAsSquare = value; } } // 0x10 (16)
		
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
