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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 12)]
	public class SubSkeleton :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public CtrRef<SkeletonAsset> Skeleton { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public List<int> BoneMap { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public List<LinearTransform> TransformMap { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Skeleton));
			(RimeWriter Writer, uint ArrayIndex) s_BoneMap = p_EbxWriter.GetArrayWriter(BoneMap.GetType(), BoneMap.Count);
			p_Writer.Write(s_BoneMap.ArrayIndex);
			foreach (var s_Entry in BoneMap)
			{
				s_BoneMap.Writer.Write(s_Entry);
			}
			(RimeWriter Writer, uint ArrayIndex) s_TransformMap = p_EbxWriter.GetArrayWriter(TransformMap.GetType(), TransformMap.Count);
			p_Writer.Write(s_TransformMap.ArrayIndex);
			foreach (var s_Entry in TransformMap)
			{
				s_Entry.Serialize(s_TransformMap.Writer, p_EbxWriter);
			}
		}
	}
}
