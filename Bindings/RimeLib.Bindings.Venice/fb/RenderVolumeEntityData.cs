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
	[ContainerType(16, 128)]
	public class RenderVolumeEntityData : 
		SpatialEntityData
	{
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 UserMasks { get; set; } = new();

		[ContainerField(96)]
		public SurfaceShaderInstanceDataStruct Shader { get; set; } = new();

		[ContainerField(116)]
		public RenderVolumeTransformType TransformType { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public bool Enabled { get; set; }

		public static void Deserialize(RenderVolumeEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec4.Deserialize(p_Instance.UserMasks, p_Reader, p_Parser);
			fb.SurfaceShaderInstanceDataStruct.Deserialize(p_Instance.Shader, p_Reader, p_Parser);
			p_Instance.TransformType = (RenderVolumeTransformType) p_Reader.ReadInt32();
			p_Instance.Enabled = p_Reader.ReadBool();
			p_Reader.Seek(7, SeekOrigin.Current);
		}

	}
}
