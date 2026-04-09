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
	[ContainerType(4, 44)]
	public partial class AntTrackData :
		CustomSequenceTrackData
	{
		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private RefArray<AntTrackItemData> _AntTrackItemDatas = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_AntTrackItemDatas = p_EbxWriter.GetArrayWriter(AntTrackItemDatas.GetType(), AntTrackItemDatas.Count);
			p_Writer.Write(s_AntTrackItemDatas.ArrayIndex);
			foreach (var s_Entry in AntTrackItemDatas)
			{
				s_AntTrackItemDatas.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
