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
	[ContainerType(16)]
	public class PlanarReflectionComponentData : 
		ComponentData
	{
		protected BlurFilter m_VerticalBlurFilter = new BlurFilter();
		[ContainerField(96), ContainerFieldNameHash(1814002686)]
		public BlurFilter VerticalBlurFilter { get { return m_VerticalBlurFilter; } set { if (OnPropertyChanging("PlanarReflectionComponentData." + nameof(VerticalBlurFilter), this, m_VerticalBlurFilter, value)) m_VerticalBlurFilter = value; } } // 0x60 (96)
		
		protected float m_HorizontalDeviation = new float();
		[ContainerField(100), LayoutImmutable, Blittable, ContainerFieldNameHash(3316039832)]
		public float HorizontalDeviation { get { return m_HorizontalDeviation; } set { if (OnPropertyChanging("PlanarReflectionComponentData." + nameof(HorizontalDeviation), this, m_HorizontalDeviation, value)) m_HorizontalDeviation = value; } } // 0x64 (100)
		
		protected float m_GroundHeight = new float();
		[ContainerField(104), LayoutImmutable, Blittable, ContainerFieldNameHash(2719610687)]
		public float GroundHeight { get { return m_GroundHeight; } set { if (OnPropertyChanging("PlanarReflectionComponentData." + nameof(GroundHeight), this, m_GroundHeight, value)) m_GroundHeight = value; } } // 0x68 (104)
		
		protected float m_VerticalDeviation = new float();
		[ContainerField(108), LayoutImmutable, Blittable, ContainerFieldNameHash(2069073588)]
		public float VerticalDeviation { get { return m_VerticalDeviation; } set { if (OnPropertyChanging("PlanarReflectionComponentData." + nameof(VerticalDeviation), this, m_VerticalDeviation, value)) m_VerticalDeviation = value; } } // 0x6C (108)
		
		protected BlurFilter m_HorizontalBlurFilter = new BlurFilter();
		[ContainerField(112), ContainerFieldNameHash(3076987858)]
		public BlurFilter HorizontalBlurFilter { get { return m_HorizontalBlurFilter; } set { if (OnPropertyChanging("PlanarReflectionComponentData." + nameof(HorizontalBlurFilter), this, m_HorizontalBlurFilter, value)) m_HorizontalBlurFilter = value; } } // 0x70 (112)
		
		protected bool m_SkyRenderEnable = new bool();
		[ContainerField(116), LayoutImmutable, Blittable, ContainerFieldNameHash(1642488687)]
		public bool SkyRenderEnable { get { return m_SkyRenderEnable; } set { if (OnPropertyChanging("PlanarReflectionComponentData." + nameof(SkyRenderEnable), this, m_SkyRenderEnable, value)) m_SkyRenderEnable = value; } } // 0x74 (116)
		
		protected bool m_Enable = new bool();
		[ContainerField(117), LayoutImmutable, Blittable, ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("PlanarReflectionComponentData." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x75 (117)
		
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
