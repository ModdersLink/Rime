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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 44)]
	public class VisualVectorShapeData : 
		VectorShapeData
	{
		protected float m_ErrorTolerance = new float();
		[ContainerField(Name: "ErrorTolerance", Offset: 28, NameHash: 3302753588, Flags: 49469), LayoutImmutable, Blittable]
		public float ErrorTolerance { get { return m_ErrorTolerance; } set { if (OnPropertyChanging("VisualVectorShapeData." + nameof(ErrorTolerance), this, m_ErrorTolerance, value)) m_ErrorTolerance = value; } } // 0x1C (28)
		
		protected CtrRef<SurfaceShaderBaseAsset> m_Shader3d = new CtrRef<SurfaceShaderBaseAsset>();
		[ContainerField(Name: "Shader3d", Offset: 32, NameHash: 596681147, Flags: 53)]
		public CtrRef<SurfaceShaderBaseAsset> Shader3d { get { return m_Shader3d; } set { if (OnPropertyChanging("VisualVectorShapeData." + nameof(Shader3d), this, m_Shader3d, value)) m_Shader3d = value; } } // 0x20 (32)
		
		protected uint m_DrawOrderIndex = new uint();
		[ContainerField(Name: "DrawOrderIndex", Offset: 36, NameHash: 274360149, Flags: 49421), LayoutImmutable, Blittable]
		public uint DrawOrderIndex { get { return m_DrawOrderIndex; } set { if (OnPropertyChanging("VisualVectorShapeData." + nameof(DrawOrderIndex), this, m_DrawOrderIndex, value)) m_DrawOrderIndex = value; } } // 0x24 (36)
		
		protected float m_TessellationTriangleSize = new float();
		[ContainerField(Name: "TessellationTriangleSize", Offset: 40, NameHash: 22509191, Flags: 49469), LayoutImmutable, Blittable]
		public float TessellationTriangleSize { get { return m_TessellationTriangleSize; } set { if (OnPropertyChanging("VisualVectorShapeData." + nameof(TessellationTriangleSize), this, m_TessellationTriangleSize, value)) m_TessellationTriangleSize = value; } } // 0x28 (40)
		
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
