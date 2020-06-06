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
	public class ShaderGraph : 
		SurfaceShaderBaseAsset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint MaxSubMaterialCount { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool GammaCorrectionEnable { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2130556957:
					MaxSubMaterialCount = (uint) p_Value;
					break;

				case 315798933:
					GammaCorrectionEnable = (bool) p_Value;
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
				case 2130556957:
					return MaxSubMaterialCount;

				case 315798933:
					return GammaCorrectionEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2130556957:
					return typeof(ShaderGraph).GetProperty(nameof(MaxSubMaterialCount));

				case 315798933:
					return typeof(ShaderGraph).GetProperty(nameof(GammaCorrectionEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
