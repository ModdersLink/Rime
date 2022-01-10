///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 44)]
	public class VisualVectorShapeData : 
		VectorShapeData
	{
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ErrorTolerance { get; set; }

		[ContainerField(32)]
		public CtrRef<SurfaceShaderBaseAsset> Shader3d { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public uint DrawOrderIndex { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float TessellationTriangleSize { get; set; }

		public static void Deserialize(VisualVectorShapeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ErrorTolerance = p_Reader.ReadSingle();
			p_Instance.Shader3d.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.DrawOrderIndex = p_Reader.ReadUInt32();
			p_Instance.TessellationTriangleSize = p_Reader.ReadSingle();
		}

	}
}
