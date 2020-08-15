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
	public class MeshSettings : 
		DataContainer
	{
		protected string m_OverrideShadersShaderName = new string();
		[ContainerField(8), LayoutImmutable, ContainerFieldNameHash(2376973253)]
		public string OverrideShadersShaderName { get { return m_OverrideShadersShaderName; } set { if (OnPropertyChanging("MeshSettings." + nameof(OverrideShadersShaderName), this, m_OverrideShadersShaderName, value)) m_OverrideShadersShaderName = value; } } // 0x8 (8)
		
		protected string m_OverrideShadersMeshName = new string();
		[ContainerField(12), LayoutImmutable, ContainerFieldNameHash(3516849727)]
		public string OverrideShadersMeshName { get { return m_OverrideShadersMeshName; } set { if (OnPropertyChanging("MeshSettings." + nameof(OverrideShadersMeshName), this, m_OverrideShadersMeshName, value)) m_OverrideShadersMeshName = value; } } // 0xC (12)
		
		protected int m_ForceLod = new int();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(1152595167)]
		public int ForceLod { get { return m_ForceLod; } set { if (OnPropertyChanging("MeshSettings." + nameof(ForceLod), this, m_ForceLod, value)) m_ForceLod = value; } } // 0x10 (16)
		
		protected float m_GlobalLodScale = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(835399857)]
		public float GlobalLodScale { get { return m_GlobalLodScale; } set { if (OnPropertyChanging("MeshSettings." + nameof(GlobalLodScale), this, m_GlobalLodScale, value)) m_GlobalLodScale = value; } } // 0x14 (20)
		
		protected float m_ShadowDistanceScale = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(1873620728)]
		public float ShadowDistanceScale { get { return m_ShadowDistanceScale; } set { if (OnPropertyChanging("MeshSettings." + nameof(ShadowDistanceScale), this, m_ShadowDistanceScale, value)) m_ShadowDistanceScale = value; } } // 0x18 (24)
		
		protected bool m_LoadingEnabled = new bool();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(1695799750)]
		public bool LoadingEnabled { get { return m_LoadingEnabled; } set { if (OnPropertyChanging("MeshSettings." + nameof(LoadingEnabled), this, m_LoadingEnabled, value)) m_LoadingEnabled = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2376973253:
					OverrideShadersShaderName = (string) p_Value;
					break;

				case 3516849727:
					OverrideShadersMeshName = (string) p_Value;
					break;

				case 1152595167:
					ForceLod = (int) p_Value;
					break;

				case 835399857:
					GlobalLodScale = (float) p_Value;
					break;

				case 1873620728:
					ShadowDistanceScale = (float) p_Value;
					break;

				case 1695799750:
					LoadingEnabled = (bool) p_Value;
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
				case 2376973253:
					return OverrideShadersShaderName;

				case 3516849727:
					return OverrideShadersMeshName;

				case 1152595167:
					return ForceLod;

				case 835399857:
					return GlobalLodScale;

				case 1873620728:
					return ShadowDistanceScale;

				case 1695799750:
					return LoadingEnabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2376973253:
					return typeof(MeshSettings).GetProperty(nameof(OverrideShadersShaderName));

				case 3516849727:
					return typeof(MeshSettings).GetProperty(nameof(OverrideShadersMeshName));

				case 1152595167:
					return typeof(MeshSettings).GetProperty(nameof(ForceLod));

				case 835399857:
					return typeof(MeshSettings).GetProperty(nameof(GlobalLodScale));

				case 1873620728:
					return typeof(MeshSettings).GetProperty(nameof(ShadowDistanceScale));

				case 1695799750:
					return typeof(MeshSettings).GetProperty(nameof(LoadingEnabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
