///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UIScreenshotCompData : 
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint ResizeImageWidth { get; set; } // 0x1C (28)
		
		[ContainerField(32)]
		public List<ScreenshotInfo> ScreenshotInfos { get; set; } = new List<ScreenshotInfo>(); // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public uint ResizeImageHeight { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public bool AutoResizeImage { get; set; } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 983449366:
					ResizeImageWidth = (uint) p_Value;
					break;

				case 4072764724:
					ScreenshotInfos = (List<ScreenshotInfo>) p_Value;
					break;

				case 2980493103:
					ResizeImageHeight = (uint) p_Value;
					break;

				case 767083359:
					AutoResizeImage = (bool) p_Value;
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
				case 983449366:
					return ResizeImageWidth;

				case 4072764724:
					return ScreenshotInfos;

				case 2980493103:
					return ResizeImageHeight;

				case 767083359:
					return AutoResizeImage;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 983449366:
					return typeof(UIScreenshotCompData).GetProperty(nameof(ResizeImageWidth));

				case 4072764724:
					return typeof(UIScreenshotCompData).GetProperty(nameof(ScreenshotInfos));

				case 2980493103:
					return typeof(UIScreenshotCompData).GetProperty(nameof(ResizeImageHeight));

				case 767083359:
					return typeof(UIScreenshotCompData).GetProperty(nameof(AutoResizeImage));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
