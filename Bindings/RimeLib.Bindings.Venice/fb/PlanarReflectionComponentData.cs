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
    [ContainerType(16)]
	public class PlanarReflectionComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public BlurFilter VerticalBlurFilter { get; set; } = new BlurFilter(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float HorizontalDeviation { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float GroundHeight { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float VerticalDeviation { get; set; } // 0x6C (108)
		
		[ContainerField(112)]
		public BlurFilter HorizontalBlurFilter { get; set; } = new BlurFilter(); // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public bool SkyRenderEnable { get; set; } // 0x74 (116)
		
		[ContainerField(117), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x75 (117)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1814002686:
					VerticalBlurFilter = (BlurFilter) Enum.ToObject(typeof(BlurFilter), p_Value);
					break;

				case 3316039832:
					HorizontalDeviation = (float) p_Value;
					break;

				case 2719610687:
					GroundHeight = (float) p_Value;
					break;

				case 2069073588:
					VerticalDeviation = (float) p_Value;
					break;

				case 3076987858:
					HorizontalBlurFilter = (BlurFilter) Enum.ToObject(typeof(BlurFilter), p_Value);
					break;

				case 1642488687:
					SkyRenderEnable = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
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
				case 1814002686:
					return VerticalBlurFilter;

				case 3316039832:
					return HorizontalDeviation;

				case 2719610687:
					return GroundHeight;

				case 2069073588:
					return VerticalDeviation;

				case 3076987858:
					return HorizontalBlurFilter;

				case 1642488687:
					return SkyRenderEnable;

				case 2342790116:
					return Enable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1814002686:
					return typeof(PlanarReflectionComponentData).GetProperty(nameof(VerticalBlurFilter));

				case 3316039832:
					return typeof(PlanarReflectionComponentData).GetProperty(nameof(HorizontalDeviation));

				case 2719610687:
					return typeof(PlanarReflectionComponentData).GetProperty(nameof(GroundHeight));

				case 2069073588:
					return typeof(PlanarReflectionComponentData).GetProperty(nameof(VerticalDeviation));

				case 3076987858:
					return typeof(PlanarReflectionComponentData).GetProperty(nameof(HorizontalBlurFilter));

				case 1642488687:
					return typeof(PlanarReflectionComponentData).GetProperty(nameof(SkyRenderEnable));

				case 2342790116:
					return typeof(PlanarReflectionComponentData).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
