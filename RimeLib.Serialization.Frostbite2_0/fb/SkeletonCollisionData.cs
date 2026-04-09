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
	[ContainerType(4, 16)]
	public partial class SkeletonCollisionData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private CtrRef<SkeletonAsset> _SkeletonAsset = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<BoneCollisionData> _BoneCollisionData = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(p_EbxWriter.WriteImport(SkeletonAsset));
			(RimeWriter Writer, uint ArrayIndex) s_BoneCollisionData = p_EbxWriter.GetArrayWriter(BoneCollisionData.GetType(), BoneCollisionData.Count);
			p_Writer.Write(s_BoneCollisionData.ArrayIndex);
			foreach (var s_Entry in BoneCollisionData)
			{
				s_Entry.Serialize(s_BoneCollisionData.Writer, p_EbxWriter);
			}
		}
	}
}
