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
	[ContainerType(4, 20)]
	public partial class HavokAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _Scale;

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private RefArray<DataContainer> _ExternalAssets = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Scale);
			(RimeWriter Writer, uint ArrayIndex) s_ExternalAssets = p_EbxWriter.GetArrayWriter(ExternalAssets.GetType(), ExternalAssets.Count);
			p_Writer.Write(s_ExternalAssets.ArrayIndex);
			foreach (var s_Entry in ExternalAssets)
			{
				s_ExternalAssets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
