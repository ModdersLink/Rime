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
	[ContainerType(4, 20)]
	public class SurfaceShaderInstanceDataStruct
	{
		[ContainerField(0)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new();
		
		[ContainerField(4)]
		public List<BoolShaderParameter> BoolParameters { get; set; } = new();
		
		[ContainerField(8)]
		public List<VectorShaderParameter> VectorParameters { get; set; } = new();
		
		[ContainerField(12)]
		public List<VectorArrayShaderParameter> VectorArrayParameters { get; set; } = new();
		
		[ContainerField(16)]
		public List<TextureShaderParameter> TextureParameters { get; set; } = new();
		
	}
}
