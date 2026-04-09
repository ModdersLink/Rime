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
	public partial class PropertyTrackData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private int _Id;

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<int> _Times = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(Id);
			(RimeWriter Writer, uint ArrayIndex) s_Times = p_EbxWriter.GetArrayWriter(Times.GetType(), Times.Count);
			p_Writer.Write(s_Times.ArrayIndex);
			foreach (var s_Entry in Times)
			{
				s_Times.Writer.Write(s_Entry);
			}
		}
	}
}
