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
	[ContainerType(16, 160)]
	public class DestructionMaskVolumeEntityData : 
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 DustAccumulationCurve { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 ShaderUserMasks { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable]
		public float DustAccumulationLifeTime { get; set; }

		[ContainerField(132)]
		public SurfaceShaderInstanceDataStruct Shader { get; set; } = new();

		[ContainerField(152), LayoutImmutable, Blittable]
		public float Radius { get; set; }

		public static void Deserialize(DestructionMaskVolumeEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec4.Deserialize(p_Instance.DustAccumulationCurve, p_Reader, p_Parser);
			fb.Vec4.Deserialize(p_Instance.ShaderUserMasks, p_Reader, p_Parser);
			p_Instance.DustAccumulationLifeTime = p_Reader.ReadSingle();
			fb.SurfaceShaderInstanceDataStruct.Deserialize(p_Instance.Shader, p_Reader, p_Parser);
			p_Instance.Radius = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
