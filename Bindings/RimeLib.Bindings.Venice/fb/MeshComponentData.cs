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
	public class MeshComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public List<CtrRef<BoneFakePhysicsData>> BoneFakePhysics { get; set; } = new();

		[ContainerField(100)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(104)]
		public CtrRef<SkeletonAsset> Skeleton { get; set; } = new();

		public static void Deserialize(MeshComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.BoneFakePhysics.Clear();
			(RimeReader Reader, uint Count) s_BoneFakePhysics = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_BoneFakePhysics.Count; ++i)
			{
				var s_CtrRef = new CtrRef<BoneFakePhysicsData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_BoneFakePhysics.Reader.ReadUInt32()));
				p_Instance.BoneFakePhysics.Add(s_CtrRef);
			}
			
			s_BoneFakePhysics.Reader.Dispose();
			p_Instance.Mesh.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Skeleton.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
