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
	[ContainerType(4, 12)]
	public class SoldierMeshData
	{
		[ContainerField(0)]
		public CtrRef<SkinnedMeshAsset> Mesh { get; set; } = new();
		
		[ContainerField(4)]
		public CtrRef<ObjectBlueprint> MeshBlueprint { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public int RandomGroup { get; set; }
		
		public static void Deserialize(SoldierMeshData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Mesh.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MeshBlueprint.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.RandomGroup = p_Reader.ReadInt32();
		}
	}
}
