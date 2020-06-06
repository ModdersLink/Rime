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
	public class MeshSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string OverrideShadersShaderName { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable]
		public string OverrideShadersMeshName { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int ForceLod { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float GlobalLodScale { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float ShadowDistanceScale { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool LoadingEnabled { get; set; } // 0x1C (28)
		
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
