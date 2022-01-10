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
	[ContainerType(16, 144)]
	public class BreakableModelEntityData : 
		GamePhysicsEntityData
	{
		[ContainerField(112)]
		public CtrRef<SurfaceShaderBaseAsset> DecalVolumeShader { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable]
		public float DecalVolumeScaleFactor { get; set; }

		[ContainerField(120)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable]
		public uint BoneCount { get; set; }

		[ContainerField(128)]
		public CtrRef<EdgeModelLightMapData> EdgeModelLightMapData { get; set; } = new();

		public static void Deserialize(BreakableModelEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DecalVolumeShader.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.DecalVolumeScaleFactor = p_Reader.ReadSingle();
			p_Instance.Mesh.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.BoneCount = p_Reader.ReadUInt32();
			p_Instance.EdgeModelLightMapData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
