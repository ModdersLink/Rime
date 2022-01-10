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
	[ContainerType(4, 52)]
	public class TerrainFillDecalData : 
		VisualVectorShapeData
	{
		[ContainerField(44)]
		public CtrRef<SurfaceShaderBaseAsset> Shader2d { get; set; } = new();

		[ContainerField(48)]
		public CtrRef<SurfaceShaderBaseAsset> Shader3dZOnly { get; set; } = new();

		public static void Deserialize(TerrainFillDecalData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Shader2d.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Shader3dZOnly.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
