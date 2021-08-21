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
	public class UIPartProperties : FrostbiteContainer
	{
		[ContainerField(Name: "Identifier", Offset: 0, NameHash: 3512790342, Flags: 137)]
		public UIPartIdentifier Identifier { get; set; } = new UIPartIdentifier(); // 0x0 (0)
		
		[ContainerField(Name: "Range", Offset: 4, NameHash: 230112826, Flags: 49469), LayoutImmutable, Blittable]
		public float Range { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "Frequency", Offset: 8, NameHash: 4112821953, Flags: 49469), LayoutImmutable, Blittable]
		public float Frequency { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "CompensateFreelook", Offset: 12, NameHash: 3705803663, Flags: 49325), LayoutImmutable, Blittable]
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
