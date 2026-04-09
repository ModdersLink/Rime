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
	public partial class UIAwardsScreenCompData :
		UIComponentData
	{
		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private RefArray<StatsCategoryBaseData> _TrackableAwardRow = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private RefArray<StatsCategoryBaseData> _TrackableAwardCol = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_TrackableAwardRow = p_EbxWriter.GetArrayWriter(TrackableAwardRow.GetType(), TrackableAwardRow.Count);
			p_Writer.Write(s_TrackableAwardRow.ArrayIndex);
			foreach (var s_Entry in TrackableAwardRow)
			{
				s_TrackableAwardRow.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_TrackableAwardCol = p_EbxWriter.GetArrayWriter(TrackableAwardCol.GetType(), TrackableAwardCol.Count);
			p_Writer.Write(s_TrackableAwardCol.ArrayIndex);
			foreach (var s_Entry in TrackableAwardCol)
			{
				s_TrackableAwardCol.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
