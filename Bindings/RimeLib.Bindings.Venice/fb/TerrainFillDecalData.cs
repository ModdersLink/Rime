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
	public class TerrainFillDecalData : 
		VisualVectorShapeData
	{
		[ContainerField(44)]
		public CtrRef<SurfaceShaderBaseAsset> Shader2d { get; set; } = new CtrRef<SurfaceShaderBaseAsset>(); // 0x2C (44)
		
		[ContainerField(48)]
		public CtrRef<SurfaceShaderBaseAsset> Shader3dZOnly { get; set; } = new CtrRef<SurfaceShaderBaseAsset>(); // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 596681178:
					Shader2d = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 585356309:
					Shader3dZOnly = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
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
				case 596681178:
					return Shader2d;

				case 585356309:
					return Shader3dZOnly;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 596681178:
					return typeof(TerrainFillDecalData).GetProperty(nameof(Shader2d));

				case 585356309:
					return typeof(TerrainFillDecalData).GetProperty(nameof(Shader3dZOnly));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
