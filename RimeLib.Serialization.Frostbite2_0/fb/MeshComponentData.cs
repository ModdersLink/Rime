///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 112)]
	public class MeshComponentData :
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public RefArray<BoneFakePhysicsData> BoneFakePhysics { get; set; } = new();

		[ContainerField(100), JsonProperty(Order = 100)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(104), JsonProperty(Order = 104)]
		public CtrRef<SkeletonAsset> Skeleton { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_BoneFakePhysics = p_EbxWriter.GetArrayWriter(BoneFakePhysics.GetType(), BoneFakePhysics.Count);
			p_Writer.Write(s_BoneFakePhysics.ArrayIndex);
			foreach (var s_Entry in BoneFakePhysics)
			{
				s_BoneFakePhysics.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
			p_Writer.Write(p_EbxWriter.WriteImport(Skeleton));
			p_Writer.WriteNullBytes(4);
		}
	}
}
