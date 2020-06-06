///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UICrosshairDataBinding : 
		UIDataBinding
	{
		[ContainerField(8)]
		public UIDataSourceInfo Dispersion { get; set; } = new UIDataSourceInfo(); // 0x8 (8)
		
		[ContainerField(24)]
		public UIDataSourceInfo Zoomed { get; set; } = new UIDataSourceInfo(); // 0x18 (24)
		
		[ContainerField(40)]
		public UIDataSourceInfo Visibility { get; set; } = new UIDataSourceInfo(); // 0x28 (40)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float DispersionBaseOffset { get; set; } // 0x38 (56)
		
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
