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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 16)]
	public class SpeedModifierData : FrostbiteContainer
	{
		[ContainerField(Name: "ForwardConstant", Offset: 0, NameHash: 2157259040, Flags: 49469), LayoutImmutable, Blittable]
		public float ForwardConstant { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "BackwardConstant", Offset: 4, NameHash: 3889204528, Flags: 49469), LayoutImmutable, Blittable]
		public float BackwardConstant { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "LeftConstant", Offset: 8, NameHash: 1018853792, Flags: 49469), LayoutImmutable, Blittable]
		public float LeftConstant { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "RightConstant", Offset: 12, NameHash: 1227925723, Flags: 49469), LayoutImmutable, Blittable]
		public float RightConstant { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2157259040:
					ForwardConstant = (float) p_Value;
					break;

				case 3889204528:
					BackwardConstant = (float) p_Value;
					break;

				case 1018853792:
					LeftConstant = (float) p_Value;
					break;

				case 1227925723:
					RightConstant = (float) p_Value;
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
				case 2157259040:
					return ForwardConstant;

				case 3889204528:
					return BackwardConstant;

				case 1018853792:
					return LeftConstant;

				case 1227925723:
					return RightConstant;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2157259040:
					return typeof(SpeedModifierData).GetProperty(nameof(ForwardConstant));

				case 3889204528:
					return typeof(SpeedModifierData).GetProperty(nameof(BackwardConstant));

				case 1018853792:
					return typeof(SpeedModifierData).GetProperty(nameof(LeftConstant));

				case 1227925723:
					return typeof(SpeedModifierData).GetProperty(nameof(RightConstant));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
