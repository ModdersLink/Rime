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
	public class UIImageDataBinding : 
		UIDataBinding
	{
		protected string m_StaticImageUrl = string.Empty;
		[ContainerField(8), LayoutImmutable, ContainerFieldNameHash(1907338737)]
		public string StaticImageUrl { get { return m_StaticImageUrl; } set { if (OnPropertyChanging("UIImageDataBinding." + nameof(StaticImageUrl), this, m_StaticImageUrl, value)) m_StaticImageUrl = value; } } // 0x8 (8)
		
		protected UIDataSourceInfo m_ImageData = new UIDataSourceInfo();
		[ContainerField(12), ContainerFieldNameHash(2678906194)]
		public UIDataSourceInfo ImageData { get { return m_ImageData; } set { if (OnPropertyChanging("UIImageDataBinding." + nameof(ImageData), this, m_ImageData, value)) m_ImageData = value; } } // 0xC (12)
		
		protected UIDataSourceInfo m_Visibility = new UIDataSourceInfo();
		[ContainerField(28), ContainerFieldNameHash(1708270083)]
		public UIDataSourceInfo Visibility { get { return m_Visibility; } set { if (OnPropertyChanging("UIImageDataBinding." + nameof(Visibility), this, m_Visibility, value)) m_Visibility = value; } } // 0x1C (28)
		
		protected bool m_Visible = new bool();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(901540267)]
		public bool Visible { get { return m_Visible; } set { if (OnPropertyChanging("UIImageDataBinding." + nameof(Visible), this, m_Visible, value)) m_Visible = value; } } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1907338737:
					StaticImageUrl = (string) p_Value;
					break;

				case 2678906194:
					ImageData = (UIDataSourceInfo) p_Value;
					break;

				case 1708270083:
					Visibility = (UIDataSourceInfo) p_Value;
					break;

				case 901540267:
					Visible = (bool) p_Value;
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
				case 1907338737:
					return StaticImageUrl;

				case 2678906194:
					return ImageData;

				case 1708270083:
					return Visibility;

				case 901540267:
					return Visible;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1907338737:
					return typeof(UIImageDataBinding).GetProperty(nameof(StaticImageUrl));

				case 2678906194:
					return typeof(UIImageDataBinding).GetProperty(nameof(ImageData));

				case 1708270083:
					return typeof(UIImageDataBinding).GetProperty(nameof(Visibility));

				case 901540267:
					return typeof(UIImageDataBinding).GetProperty(nameof(Visible));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
