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
	[ContainerType(4, 20)]
	public class MasterSkeletonAsset :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<SkeletonAsset> MasterSkeleton { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<SubSkeleton> SubSkeletons { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(MasterSkeleton));
			(RimeWriter Writer, uint ArrayIndex) s_SubSkeletons = p_EbxWriter.GetArrayWriter(SubSkeletons.GetType(), SubSkeletons.Count);
			p_Writer.Write(s_SubSkeletons.ArrayIndex);
			foreach (var s_Entry in SubSkeletons)
			{
				s_Entry.Serialize(s_SubSkeletons.Writer, p_EbxWriter);
			}
		}
	}
}
