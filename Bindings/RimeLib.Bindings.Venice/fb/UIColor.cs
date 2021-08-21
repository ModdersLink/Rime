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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 48)]
	public class UIColor : 
		DataContainer
	{
		protected Vec4 m_Color = new Vec4();
		[ContainerField(Name: "Color", Offset: 16, NameHash: 212387320, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Color { get { return m_Color; } set { if (OnPropertyChanging("UIColor." + nameof(Color), this, m_Color, value)) m_Color = value; } } // 0x10 (16)
		
		protected UIColorType m_ColorType = new UIColorType();
		[ContainerField(Name: "ColorType", Offset: 32, NameHash: 518124864, Flags: 137)]
		public UIColorType ColorType { get { return m_ColorType; } set { if (OnPropertyChanging("UIColor." + nameof(ColorType), this, m_ColorType, value)) m_ColorType = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 212387320:
					Color = (Vec4) p_Value;
					break;

				case 518124864:
					ColorType = (UIColorType) Enum.ToObject(typeof(UIColorType), p_Value);
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
				case 212387320:
					return Color;

				case 518124864:
					return ColorType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 212387320:
					return typeof(UIColor).GetProperty(nameof(Color));

				case 518124864:
					return typeof(UIColor).GetProperty(nameof(ColorType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
