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
	[ContainerType(4, 28)]
	public partial class GroupHavokAsset :
		HavokAsset
	{
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private List<AssetAabbs> _Aabb = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private List<ushort> _ExternalAssetScaleIndex = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Aabb = p_EbxWriter.GetArrayWriter(Aabb.GetType(), Aabb.Count);
			p_Writer.Write(s_Aabb.ArrayIndex);
			foreach (var s_Entry in Aabb)
			{
				s_Entry.Serialize(s_Aabb.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_ExternalAssetScaleIndex = p_EbxWriter.GetArrayWriter(ExternalAssetScaleIndex.GetType(), ExternalAssetScaleIndex.Count);
			p_Writer.Write(s_ExternalAssetScaleIndex.ArrayIndex);
			foreach (var s_Entry in ExternalAssetScaleIndex)
			{
				s_ExternalAssetScaleIndex.Writer.Write(s_Entry);
			}
		}
	}
}
