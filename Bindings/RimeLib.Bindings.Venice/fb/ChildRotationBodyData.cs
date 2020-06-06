///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class ChildRotationBodyData : 
		RotationBodyData
	{
		[ContainerField(56), LayoutImmutable, Blittable]
		public float ForceModifier { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float ResetForceModifier { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float ResetForceInputThreshold { get; set; } // 0x40 (64)
		
		[ContainerField(68)]
		public EntryInputActionEnum RotationInput { get; set; } = new EntryInputActionEnum(); // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float WorldSpaceLockEfficiency { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public bool UseLinearInput { get; set; } // 0x4C (76)
		
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
