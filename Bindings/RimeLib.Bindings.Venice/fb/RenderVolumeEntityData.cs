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
	public class RenderVolumeEntityData : 
		SpatialEntityData
	{
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 UserMasks { get; set; } = new Vec4(); // 0x50 (80)
		
		[ContainerField(96)]
		public SurfaceShaderInstanceDataStruct Shader { get; set; } = new SurfaceShaderInstanceDataStruct(); // 0x60 (96)
		
		[ContainerField(116)]
		public RenderVolumeTransformType TransformType { get; set; } = new RenderVolumeTransformType(); // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public bool Enabled { get; set; } // 0x78 (120)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1589111411:
					UserMasks = (Vec4) p_Value;
					break;

				case 3352909900:
					Shader = (SurfaceShaderInstanceDataStruct) p_Value;
					break;

				case 3623123985:
					TransformType = (RenderVolumeTransformType) Enum.ToObject(typeof(RenderVolumeTransformType), p_Value);
					break;

				case 2662400:
					Enabled = (bool) p_Value;
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
				case 1589111411:
					return UserMasks;

				case 3352909900:
					return Shader;

				case 3623123985:
					return TransformType;

				case 2662400:
					return Enabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1589111411:
					return typeof(RenderVolumeEntityData).GetProperty(nameof(UserMasks));

				case 3352909900:
					return typeof(RenderVolumeEntityData).GetProperty(nameof(Shader));

				case 3623123985:
					return typeof(RenderVolumeEntityData).GetProperty(nameof(TransformType));

				case 2662400:
					return typeof(RenderVolumeEntityData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
