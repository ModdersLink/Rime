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
	public partial class UIBundlesAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<UIBundleAssetState> _UIBundleAssetStateList = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_UIBundleAssetStateList = p_EbxWriter.GetArrayWriter(UIBundleAssetStateList.GetType(), UIBundleAssetStateList.Count);
			p_Writer.Write(s_UIBundleAssetStateList.ArrayIndex);
			foreach (var s_Entry in UIBundleAssetStateList)
			{
				s_Entry.Serialize(s_UIBundleAssetStateList.Writer, p_EbxWriter);
			}
		}
	}
}
