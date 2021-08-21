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
	public class VisionBoxSettings : FrostbiteContainer
	{
		[ContainerField(Name: "DecreaseXz", Offset: 0, NameHash: 4108635749, Flags: 49469), LayoutImmutable, Blittable]
		public float DecreaseXz { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "LowerTop", Offset: 4, NameHash: 2449544077, Flags: 49469), LayoutImmutable, Blittable]
		public float LowerTop { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "RaiseBottom", Offset: 8, NameHash: 4168639462, Flags: 49469), LayoutImmutable, Blittable]
		public float RaiseBottom { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "RaiseBottomHuman", Offset: 12, NameHash: 266392633, Flags: 49469), LayoutImmutable, Blittable]
		public float RaiseBottomHuman { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4108635749:
					DecreaseXz = (float) p_Value;
					break;

				case 2449544077:
					LowerTop = (float) p_Value;
					break;

				case 4168639462:
					RaiseBottom = (float) p_Value;
					break;

				case 266392633:
					RaiseBottomHuman = (float) p_Value;
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
				case 4108635749:
					return DecreaseXz;

				case 2449544077:
					return LowerTop;

				case 4168639462:
					return RaiseBottom;

				case 266392633:
					return RaiseBottomHuman;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4108635749:
					return typeof(VisionBoxSettings).GetProperty(nameof(DecreaseXz));

				case 2449544077:
					return typeof(VisionBoxSettings).GetProperty(nameof(LowerTop));

				case 4168639462:
					return typeof(VisionBoxSettings).GetProperty(nameof(RaiseBottom));

				case 266392633:
					return typeof(VisionBoxSettings).GetProperty(nameof(RaiseBottomHuman));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
