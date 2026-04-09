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
	public partial class UICoopLevelDescription :
		LevelDescriptionComponent
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		private string _Debriefing = string.Empty;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private int _DevTime;

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private List<string> _UnlockedByLevels = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Debriefing));
			p_Writer.Write(DevTime);
			(RimeWriter Writer, uint ArrayIndex) s_UnlockedByLevels = p_EbxWriter.GetArrayWriter(UnlockedByLevels.GetType(), UnlockedByLevels.Count);
			p_Writer.Write(s_UnlockedByLevels.ArrayIndex);
			foreach (var s_Entry in UnlockedByLevels)
			{
				s_UnlockedByLevels.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
		}
	}
}
