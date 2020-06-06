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
	public class UIPartProperties : FrostbiteContainer
	{
		[ContainerField(0)]
		public UIPartIdentifier Identifier { get; set; } = new UIPartIdentifier(); // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float Range { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Frequency { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool CompensateFreelook { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3512790342:
						Identifier = (UIPartIdentifier) Enum.ToObject(typeof(UIPartIdentifier), p_Value);
					break;

				case 230112826:
					Range = (float) p_Value;
					break;

				case 4112821953:
					Frequency = (float) p_Value;
					break;

				case 3705803663:
					CompensateFreelook = (bool) p_Value;
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
				case 3512790342:
					return Identifier;

				case 230112826:
					return Range;

				case 4112821953:
					return Frequency;

				case 3705803663:
					return CompensateFreelook;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3512790342:
					return typeof(UIPartProperties).GetProperty(nameof(Identifier));

				case 230112826:
					return typeof(UIPartProperties).GetProperty(nameof(Range));

				case 4112821953:
					return typeof(UIPartProperties).GetProperty(nameof(Frequency));

				case 3705803663:
					return typeof(UIPartProperties).GetProperty(nameof(CompensateFreelook));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
