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
	[ContainerType(4)]
	public class ChildRotationBodyData : 
		RotationBodyData
	{
		protected float m_ForceModifier = new float();
		[ContainerField(56), LayoutImmutable, Blittable, ContainerFieldNameHash(1738357711)]
		public float ForceModifier { get { return m_ForceModifier; } set { if (OnPropertyChanging("ChildRotationBodyData." + nameof(ForceModifier), this, m_ForceModifier, value)) m_ForceModifier = value; } } // 0x38 (56)
		
		protected float m_ResetForceModifier = new float();
		[ContainerField(60), LayoutImmutable, Blittable, ContainerFieldNameHash(4210794010)]
		public float ResetForceModifier { get { return m_ResetForceModifier; } set { if (OnPropertyChanging("ChildRotationBodyData." + nameof(ResetForceModifier), this, m_ResetForceModifier, value)) m_ResetForceModifier = value; } } // 0x3C (60)
		
		protected float m_ResetForceInputThreshold = new float();
		[ContainerField(64), LayoutImmutable, Blittable, ContainerFieldNameHash(1759745836)]
		public float ResetForceInputThreshold { get { return m_ResetForceInputThreshold; } set { if (OnPropertyChanging("ChildRotationBodyData." + nameof(ResetForceInputThreshold), this, m_ResetForceInputThreshold, value)) m_ResetForceInputThreshold = value; } } // 0x40 (64)
		
		protected EntryInputActionEnum m_RotationInput = new EntryInputActionEnum();
		[ContainerField(68), ContainerFieldNameHash(832509767)]
		public EntryInputActionEnum RotationInput { get { return m_RotationInput; } set { if (OnPropertyChanging("ChildRotationBodyData." + nameof(RotationInput), this, m_RotationInput, value)) m_RotationInput = value; } } // 0x44 (68)
		
		protected float m_WorldSpaceLockEfficiency = new float();
		[ContainerField(72), LayoutImmutable, Blittable, ContainerFieldNameHash(4063999679)]
		public float WorldSpaceLockEfficiency { get { return m_WorldSpaceLockEfficiency; } set { if (OnPropertyChanging("ChildRotationBodyData." + nameof(WorldSpaceLockEfficiency), this, m_WorldSpaceLockEfficiency, value)) m_WorldSpaceLockEfficiency = value; } } // 0x48 (72)
		
		protected bool m_UseLinearInput = new bool();
		[ContainerField(76), LayoutImmutable, Blittable, ContainerFieldNameHash(330083213)]
		public bool UseLinearInput { get { return m_UseLinearInput; } set { if (OnPropertyChanging("ChildRotationBodyData." + nameof(UseLinearInput), this, m_UseLinearInput, value)) m_UseLinearInput = value; } } // 0x4C (76)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1738357711:
					ForceModifier = (float) p_Value;
					break;

				case 4210794010:
					ResetForceModifier = (float) p_Value;
					break;

				case 1759745836:
					ResetForceInputThreshold = (float) p_Value;
					break;

				case 832509767:
					RotationInput = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 4063999679:
					WorldSpaceLockEfficiency = (float) p_Value;
					break;

				case 330083213:
					UseLinearInput = (bool) p_Value;
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
				case 1738357711:
					return ForceModifier;

				case 4210794010:
					return ResetForceModifier;

				case 1759745836:
					return ResetForceInputThreshold;

				case 832509767:
					return RotationInput;

				case 4063999679:
					return WorldSpaceLockEfficiency;

				case 330083213:
					return UseLinearInput;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1738357711:
					return typeof(ChildRotationBodyData).GetProperty(nameof(ForceModifier));

				case 4210794010:
					return typeof(ChildRotationBodyData).GetProperty(nameof(ResetForceModifier));

				case 1759745836:
					return typeof(ChildRotationBodyData).GetProperty(nameof(ResetForceInputThreshold));

				case 832509767:
					return typeof(ChildRotationBodyData).GetProperty(nameof(RotationInput));

				case 4063999679:
					return typeof(ChildRotationBodyData).GetProperty(nameof(WorldSpaceLockEfficiency));

				case 330083213:
					return typeof(ChildRotationBodyData).GetProperty(nameof(UseLinearInput));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
