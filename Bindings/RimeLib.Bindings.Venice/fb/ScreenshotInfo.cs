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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 32)]
	public class ScreenshotInfo : FrostbiteContainer
	{
		[ContainerField(Name: "Name", Offset: 0, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "CropImageY1", Offset: 4, NameHash: 3713821508, Flags: 49421), LayoutImmutable, Blittable]
		public uint CropImageY1 { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "CropImageX1", Offset: 8, NameHash: 3713821541, Flags: 49421), LayoutImmutable, Blittable]
		public uint CropImageX1 { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "CropImageX2", Offset: 12, NameHash: 3713821542, Flags: 49421), LayoutImmutable, Blittable]
		public uint CropImageX2 { get; set; } // 0xC (12)
		
		[ContainerField(Name: "CropImageY2", Offset: 16, NameHash: 3713821511, Flags: 49421), LayoutImmutable, Blittable]
		public uint CropImageY2 { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "ResizeOutputImageHeight", Offset: 20, NameHash: 2676658224, Flags: 49421), LayoutImmutable, Blittable]
		public uint ResizeOutputImageHeight { get; set; } // 0x14 (20)
		
		[ContainerField(Name: "ResizeOutputImageWidth", Offset: 24, NameHash: 228904617, Flags: 49421), LayoutImmutable, Blittable]
		public uint ResizeOutputImageWidth { get; set; } // 0x18 (24)
		
		[ContainerField(Name: "ResizeOutputImage", Offset: 28, NameHash: 204807471, Flags: 49325), LayoutImmutable, Blittable]
		public bool ResizeOutputImage { get; set; } // 0x1C (28)
		
		[ContainerField(Name: "CropImage", Offset: 29, NameHash: 713322252, Flags: 49325), LayoutImmutable, Blittable]
		public bool CropImage { get; set; } // 0x1D (29)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 3713821508:
					CropImageY1 = (uint) p_Value;
					break;

				case 3713821541:
					CropImageX1 = (uint) p_Value;
					break;

				case 3713821542:
					CropImageX2 = (uint) p_Value;
					break;

				case 3713821511:
					CropImageY2 = (uint) p_Value;
					break;

				case 2676658224:
					ResizeOutputImageHeight = (uint) p_Value;
					break;

				case 228904617:
					ResizeOutputImageWidth = (uint) p_Value;
					break;

				case 204807471:
					ResizeOutputImage = (bool) p_Value;
					break;

				case 713322252:
					CropImage = (bool) p_Value;
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
				case 2088949890:
					return Name;

				case 3713821508:
					return CropImageY1;

				case 3713821541:
					return CropImageX1;

				case 3713821542:
					return CropImageX2;

				case 3713821511:
					return CropImageY2;

				case 2676658224:
					return ResizeOutputImageHeight;

				case 228904617:
					return ResizeOutputImageWidth;

				case 204807471:
					return ResizeOutputImage;

				case 713322252:
					return CropImage;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(ScreenshotInfo).GetProperty(nameof(Name));

				case 3713821508:
					return typeof(ScreenshotInfo).GetProperty(nameof(CropImageY1));

				case 3713821541:
					return typeof(ScreenshotInfo).GetProperty(nameof(CropImageX1));

				case 3713821542:
					return typeof(ScreenshotInfo).GetProperty(nameof(CropImageX2));

				case 3713821511:
					return typeof(ScreenshotInfo).GetProperty(nameof(CropImageY2));

				case 2676658224:
					return typeof(ScreenshotInfo).GetProperty(nameof(ResizeOutputImageHeight));

				case 228904617:
					return typeof(ScreenshotInfo).GetProperty(nameof(ResizeOutputImageWidth));

				case 204807471:
					return typeof(ScreenshotInfo).GetProperty(nameof(ResizeOutputImage));

				case 713322252:
					return typeof(ScreenshotInfo).GetProperty(nameof(CropImage));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
