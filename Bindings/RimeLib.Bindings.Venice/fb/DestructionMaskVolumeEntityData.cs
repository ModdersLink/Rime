///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class DestructionMaskVolumeEntityData : 
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 DustAccumulationCurve { get; set; } = new Vec4(); // 0x60 (96)
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 ShaderUserMasks { get; set; } = new Vec4(); // 0x70 (112)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float DustAccumulationLifeTime { get; set; } // 0x80 (128)
		
		[ContainerField(132)]
		public SurfaceShaderInstanceDataStruct Shader { get; set; } = new SurfaceShaderInstanceDataStruct(); // 0x84 (132)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float Radius { get; set; } // 0x98 (152)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2881902809:
					DustAccumulationCurve = (Vec4) p_Value;
					break;

				case 739662234:
					ShaderUserMasks = (Vec4) p_Value;
					break;

				case 3645148381:
					DustAccumulationLifeTime = (float) p_Value;
					break;

				case 3352909900:
					Shader = (SurfaceShaderInstanceDataStruct) p_Value;
					break;

				case 3298407133:
					Radius = (float) p_Value;
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
				case 2881902809:
					return DustAccumulationCurve;

				case 739662234:
					return ShaderUserMasks;

				case 3645148381:
					return DustAccumulationLifeTime;

				case 3352909900:
					return Shader;

				case 3298407133:
					return Radius;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2881902809:
					return typeof(DestructionMaskVolumeEntityData).GetProperty(nameof(DustAccumulationCurve));

				case 739662234:
					return typeof(DestructionMaskVolumeEntityData).GetProperty(nameof(ShaderUserMasks));

				case 3645148381:
					return typeof(DestructionMaskVolumeEntityData).GetProperty(nameof(DustAccumulationLifeTime));

				case 3352909900:
					return typeof(DestructionMaskVolumeEntityData).GetProperty(nameof(Shader));

				case 3298407133:
					return typeof(DestructionMaskVolumeEntityData).GetProperty(nameof(Radius));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
