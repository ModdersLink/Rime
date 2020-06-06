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
	public class VisualVectorShapeData : 
		VectorShapeData
	{
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ErrorTolerance { get; set; } // 0x1C (28)
		
		[ContainerField(32)]
		public CtrRef<SurfaceShaderBaseAsset> Shader3d { get; set; } = new CtrRef<SurfaceShaderBaseAsset>(); // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public uint DrawOrderIndex { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float TessellationTriangleSize { get; set; } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3302753588:
					ErrorTolerance = (float) p_Value;
					break;

				case 596681147:
					Shader3d = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 274360149:
					DrawOrderIndex = (uint) p_Value;
					break;

				case 22509191:
					TessellationTriangleSize = (float) p_Value;
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
				case 3302753588:
					return ErrorTolerance;

				case 596681147:
					return Shader3d;

				case 274360149:
					return DrawOrderIndex;

				case 22509191:
					return TessellationTriangleSize;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3302753588:
					return typeof(VisualVectorShapeData).GetProperty(nameof(ErrorTolerance));

				case 596681147:
					return typeof(VisualVectorShapeData).GetProperty(nameof(Shader3d));

				case 274360149:
					return typeof(VisualVectorShapeData).GetProperty(nameof(DrawOrderIndex));

				case 22509191:
					return typeof(VisualVectorShapeData).GetProperty(nameof(TessellationTriangleSize));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
