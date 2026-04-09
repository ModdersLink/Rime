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
	[ContainerType(4, 36)]
	public partial class RankLevelData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		private string _RankName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private uint _PointsNeeded;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		private string _ImageName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		private string _IconName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		private string _SoundName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private List<BasicUnlockInfo> _UnlockInfos = new();

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private int _RankNumber;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(p_EbxWriter.WriteString(RankName));
			p_Writer.Write(PointsNeeded);
			p_Writer.Write(p_EbxWriter.WriteString(ImageName));
			p_Writer.Write(p_EbxWriter.WriteString(IconName));
			p_Writer.Write(p_EbxWriter.WriteString(SoundName));
			(RimeWriter Writer, uint ArrayIndex) s_UnlockInfos = p_EbxWriter.GetArrayWriter(UnlockInfos.GetType(), UnlockInfos.Count);
			p_Writer.Write(s_UnlockInfos.ArrayIndex);
			foreach (var s_Entry in UnlockInfos)
			{
				s_Entry.Serialize(s_UnlockInfos.Writer, p_EbxWriter);
			}
			p_Writer.Write(RankNumber);
		}
	}
}
