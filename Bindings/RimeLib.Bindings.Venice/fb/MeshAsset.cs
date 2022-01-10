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
	[ContainerType(4, 40)]
	public class MeshAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<MeshLodGroup> LodGroup { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float LodScale { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float CullScale { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint NameHash { get; set; }

		[ContainerField(28)]
		public EnlightenType EnlightenType { get; set; } = new();

		[ContainerField(32)]
		public List<CtrRef<MeshMaterial>> Materials { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public bool OccluderHighPriority { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable]
		public bool StreamingEnable { get; set; }

		[ContainerField(38), LayoutImmutable, Blittable]
		public bool DestructionMaterialEnable { get; set; }

		[ContainerField(39), LayoutImmutable, Blittable]
		public bool OccluderMeshEnable { get; set; }

		public static void Deserialize(MeshAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.LodGroup.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.LodScale = p_Reader.ReadSingle();
			p_Instance.CullScale = p_Reader.ReadSingle();
			p_Instance.NameHash = p_Reader.ReadUInt32();
			p_Instance.EnlightenType = (EnlightenType) p_Reader.ReadInt32();
			p_Instance.Materials.Clear();
			(RimeReader Reader, uint Count) s_Materials = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Materials.Count; ++i)
			{
				var s_CtrRef = new CtrRef<MeshMaterial>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Materials.Reader.ReadUInt32()));
				p_Instance.Materials.Add(s_CtrRef);
			}
			
			s_Materials.Reader.Dispose();
			p_Instance.OccluderHighPriority = p_Reader.ReadBool();
			p_Instance.StreamingEnable = p_Reader.ReadBool();
			p_Instance.DestructionMaterialEnable = p_Reader.ReadBool();
			p_Instance.OccluderMeshEnable = p_Reader.ReadBool();
		}

	}
}
