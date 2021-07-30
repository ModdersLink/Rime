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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 44)]
	public class UIScreenshotCompData : 
		UIComponentData
	{
		protected uint m_ResizeImageWidth = new uint();
		[ContainerField(Name: "ResizeImageWidth", Offset: 28, NameHash: 983449366, Flags: 49421), LayoutImmutable, Blittable]
		public uint ResizeImageWidth { get { return m_ResizeImageWidth; } set { if (OnPropertyChanging("UIScreenshotCompData." + nameof(ResizeImageWidth), this, m_ResizeImageWidth, value)) m_ResizeImageWidth = value; } } // 0x1C (28)
		
		protected List<ScreenshotInfo> m_ScreenshotInfos = new List<ScreenshotInfo>();
		[ContainerField(Name: "ScreenshotInfos", Offset: 32, NameHash: 4072764724, Flags: 65)]
		public List<ScreenshotInfo> ScreenshotInfos { get { return m_ScreenshotInfos; } set { if (OnPropertyChanging("UIScreenshotCompData." + nameof(ScreenshotInfos), this, m_ScreenshotInfos, value)) m_ScreenshotInfos = value; } } // 0x20 (32)
		
		protected uint m_ResizeImageHeight = new uint();
		[ContainerField(Name: "ResizeImageHeight", Offset: 36, NameHash: 2980493103, Flags: 49421), LayoutImmutable, Blittable]
		public uint ResizeImageHeight { get { return m_ResizeImageHeight; } set { if (OnPropertyChanging("UIScreenshotCompData." + nameof(ResizeImageHeight), this, m_ResizeImageHeight, value)) m_ResizeImageHeight = value; } } // 0x24 (36)
		
		protected bool m_AutoResizeImage = new bool();
		[ContainerField(Name: "AutoResizeImage", Offset: 40, NameHash: 767083359, Flags: 49325), LayoutImmutable, Blittable]
		public bool AutoResizeImage { get { return m_AutoResizeImage; } set { if (OnPropertyChanging("UIScreenshotCompData." + nameof(AutoResizeImage), this, m_AutoResizeImage, value)) m_AutoResizeImage = value; } } // 0x28 (40)
		
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
