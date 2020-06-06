///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SurfaceShaderInstanceDataStruct : FrostbiteContainer
	{
		[ContainerField(0)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new CtrRef<SurfaceShaderBaseAsset>(); // 0x0 (0)
		
		[ContainerField(4)]
		public List<BoolShaderParameter> BoolParameters { get; set; } = new List<BoolShaderParameter>(); // 0x4 (4)
		
		[ContainerField(8)]
		public List<VectorShaderParameter> VectorParameters { get; set; } = new List<VectorShaderParameter>(); // 0x8 (8)
		
		[ContainerField(12)]
		public List<VectorArrayShaderParameter> VectorArrayParameters { get; set; } = new List<VectorArrayShaderParameter>(); // 0xC (12)
		
		[ContainerField(16)]
		public List<TextureShaderParameter> TextureParameters { get; set; } = new List<TextureShaderParameter>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3352909900:
					Shader = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 1729647825:
					BoolParameters = (List<BoolShaderParameter>) p_Value;
					break;

				case 3213368934:
					VectorParameters = (List<VectorShaderParameter>) p_Value;
					break;

				case 2449140063:
					VectorArrayParameters = (List<VectorArrayShaderParameter>) p_Value;
					break;

				case 2131743936:
					TextureParameters = (List<TextureShaderParameter>) p_Value;
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
				case 3352909900:
					return Shader;

				case 1729647825:
					return BoolParameters;

				case 3213368934:
					return VectorParameters;

				case 2449140063:
					return VectorArrayParameters;

				case 2131743936:
					return TextureParameters;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3352909900:
					return typeof(SurfaceShaderInstanceDataStruct).GetProperty(nameof(Shader));

				case 1729647825:
					return typeof(SurfaceShaderInstanceDataStruct).GetProperty(nameof(BoolParameters));

				case 3213368934:
					return typeof(SurfaceShaderInstanceDataStruct).GetProperty(nameof(VectorParameters));

				case 2449140063:
					return typeof(SurfaceShaderInstanceDataStruct).GetProperty(nameof(VectorArrayParameters));

				case 2131743936:
					return typeof(SurfaceShaderInstanceDataStruct).GetProperty(nameof(TextureParameters));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
