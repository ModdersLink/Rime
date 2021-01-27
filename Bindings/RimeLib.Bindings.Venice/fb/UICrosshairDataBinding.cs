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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 60)]
	public class UICrosshairDataBinding : 
		UIDataBinding
	{
		protected UIDataSourceInfo m_Dispersion = new UIDataSourceInfo();
		[ContainerField(Name: "Dispersion", Offset: 8, NameHash: 1858542823, Flags: 41)]
		public UIDataSourceInfo Dispersion { get { return m_Dispersion; } set { if (OnPropertyChanging("UICrosshairDataBinding." + nameof(Dispersion), this, m_Dispersion, value)) m_Dispersion = value; } } // 0x8 (8)
		
		protected UIDataSourceInfo m_Zoomed = new UIDataSourceInfo();
		[ContainerField(Name: "Zoomed", Offset: 24, NameHash: 3600216371, Flags: 41)]
		public UIDataSourceInfo Zoomed { get { return m_Zoomed; } set { if (OnPropertyChanging("UICrosshairDataBinding." + nameof(Zoomed), this, m_Zoomed, value)) m_Zoomed = value; } } // 0x18 (24)
		
		protected UIDataSourceInfo m_Visibility = new UIDataSourceInfo();
		[ContainerField(Name: "Visibility", Offset: 40, NameHash: 1708270083, Flags: 41)]
		public UIDataSourceInfo Visibility { get { return m_Visibility; } set { if (OnPropertyChanging("UICrosshairDataBinding." + nameof(Visibility), this, m_Visibility, value)) m_Visibility = value; } } // 0x28 (40)
		
		protected float m_DispersionBaseOffset = new float();
		[ContainerField(Name: "DispersionBaseOffset", Offset: 56, NameHash: 1903973791, Flags: 49469), LayoutImmutable, Blittable]
		public float DispersionBaseOffset { get { return m_DispersionBaseOffset; } set { if (OnPropertyChanging("UICrosshairDataBinding." + nameof(DispersionBaseOffset), this, m_DispersionBaseOffset, value)) m_DispersionBaseOffset = value; } } // 0x38 (56)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1858542823:
					Dispersion = (UIDataSourceInfo) p_Value;
					break;

				case 3600216371:
					Zoomed = (UIDataSourceInfo) p_Value;
					break;

				case 1708270083:
					Visibility = (UIDataSourceInfo) p_Value;
					break;

				case 1903973791:
					DispersionBaseOffset = (float) p_Value;
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
				case 1858542823:
					return Dispersion;

				case 3600216371:
					return Zoomed;

				case 1708270083:
					return Visibility;

				case 1903973791:
					return DispersionBaseOffset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1858542823:
					return typeof(UICrosshairDataBinding).GetProperty(nameof(Dispersion));

				case 3600216371:
					return typeof(UICrosshairDataBinding).GetProperty(nameof(Zoomed));

				case 1708270083:
					return typeof(UICrosshairDataBinding).GetProperty(nameof(Visibility));

				case 1903973791:
					return typeof(UICrosshairDataBinding).GetProperty(nameof(DispersionBaseOffset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
