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
	[ContainerType(16, 112)]
	public class EdgeModelComponentData : 
		DestructionEdgeModelComponentData
	{
		[ContainerField(96)]
		public List<CtrRef<RigidMeshAsset>> RigidMeshes { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public uint MaxInstanceCount { get; set; }

		public static void Deserialize(EdgeModelComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.RigidMeshes.Clear();
			(RimeReader Reader, uint Count) s_RigidMeshes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_RigidMeshes.Count; ++i)
			{
				var s_CtrRef = new CtrRef<RigidMeshAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_RigidMeshes.Reader.ReadUInt32()));
				p_Instance.RigidMeshes.Add(s_CtrRef);
			}
			
			s_RigidMeshes.Reader.Dispose();
			p_Instance.MaxInstanceCount = p_Reader.ReadUInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
