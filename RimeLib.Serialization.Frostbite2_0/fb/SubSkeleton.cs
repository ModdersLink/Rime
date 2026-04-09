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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 12)]
	public partial class SubSkeleton :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private CtrRef<SkeletonAsset> _Skeleton = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private List<int> _BoneMap = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private List<LinearTransform> _TransformMap = new();
		
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
