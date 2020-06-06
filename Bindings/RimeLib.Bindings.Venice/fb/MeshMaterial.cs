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
	public class MeshMaterial : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<SurfaceShaderInstanceData> ShaderInstance { get; set; } = new CtrRef<SurfaceShaderInstanceData>(); // 0x8 (8)
		
		[ContainerField(12)]
		public SurfaceShaderInstanceDataStruct Shader { get; set; } = new SurfaceShaderInstanceDataStruct(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 963778021:
					ShaderInstance = (CtrRef<SurfaceShaderInstanceData>) p_Value;
					break;

				case 3352909900:
					Shader = (SurfaceShaderInstanceDataStruct) p_Value;
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
				case 963778021:
					return ShaderInstance;

				case 3352909900:
					return Shader;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 963778021:
					return typeof(MeshMaterial).GetProperty(nameof(ShaderInstance));

				case 3352909900:
					return typeof(MeshMaterial).GetProperty(nameof(Shader));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
